using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using MessageLibrary;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace SALES
{
    public partial class frmSalesDetails : Form
    {
        UserAction Action;
        public frmSalesDetails()
        {
            InitializeComponent();
        }

        public frmSalesDetails(UserAction action) :this()
        {
            Action = action;
        }

        private void frmSalesDetails_Load(object sender, EventArgs e)
        {
            try
            {
                General.SetControlStyle(this.Controls);

                dtpSalesFromDate.Value = DateTime.Now.AddDays(-10);
                dtpSalesDate.Value = DateTime.Now;

                this.ActiveControl = dtpSalesFromDate;
            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

        private void dtpSalesFromDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                dtpSalesDate.Focus();
            }
        }

        private void dtpSalesDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                btnView.Focus();
            }
        }

        private void grdSalesMaster_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            long lngSaleId = grdSalesMaster.CurrentRow.Cells["SALE_ID"].Value.ToLong();

            try
            {
                if (Action == UserAction.MODIFY || Action == UserAction.CANCEL)
                {
                    frmSales frm = new frmSales(Action, lngSaleId);
                    frm.ShowDialog();
                }
               
                Load_Sale_Details();
            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

        private void grdSalesMaster_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            try
            {
                Color foreColor = e.CellElement.ForeColor;

                if (e.CellElement is GridSummaryCellElement | e.CellElement is GridGroupContentCellElement)
                {
                    if (e.CellElement is GridSummaryCellElement)
                    {
                        Font fnt = new Font(grdSalesMaster.Font.FontFamily, 9, FontStyle.Bold);
                        e.CellElement.Font = fnt;
                        e.CellElement.TextAlignment = ContentAlignment.MiddleRight;
                        e.CellElement.ForeColor = Color.Brown;
                    }
                }
            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

        private void grdSalesMaster_ViewRowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            try
            {
                if (e.RowElement is GridTableHeaderRowElement)
                {
                    Font font = new Font(grdSalesMaster.Font.FontFamily, 9, FontStyle.Bold);

                    e.RowElement.DrawFill = true;
                    e.RowElement.GradientStyle = GradientStyles.Solid;
                    e.RowElement.BackColor = Color.Transparent;
                    e.RowElement.ForeColor = Color.CadetBlue;
                    e.RowElement.RowInfo.Height = 30;
                    e.RowElement.Font = font;
                }
            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Load_Sale_Details();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                dtpSalesFromDate.Value = DateTime.Now.AddDays(-10);
                dtpSalesDate.Value = DateTime.Now;
                grdSalesMaster.DataSource = null;

            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Load_Sale_Details()
        {
            string strFromDate, strToDate;
            DataSet dsSales = new DataSet();
            DataView dvSaleMas, dvSaleDts;
            DataTable dtSaleDetails;

            try
            {
                strFromDate = dtpSalesFromDate.Value.ToShortDateString();
                strToDate = dtpSalesDate.Value.ToShortDateString();

                dtSaleDetails = BL_Sales.Get_Sales(0, strFromDate, strToDate);

                if (!dtSaleDetails.HasRecords())
                {
                    MyMessage.ShowMessage("Sale details not available", MessageBoxButtons.OK, MessageType.Information);
                    return;
                }

                this.grdSalesMaster.AutoGenerateHierarchy = true;

                dvSaleMas = dtSaleDetails.DefaultView.ToTable(true, "SALE_ID", "CUSTOMER_NAME", "SALE_DATE","BILL_NO", "TAX", "TOTAL_AMOUNT").DefaultView;
                dvSaleDts = dtSaleDetails.DefaultView.ToTable(true, "ITEM_NO", "ITEM_NAME", "QTY", "PRICE", "SALE_ID_FK", "SALE_DTS_ID").DefaultView;

                dsSales.Tables.Add(dvSaleMas.ToTable("SALE_MAS"));
                dsSales.Tables.Add(dvSaleDts.ToTable("SALE_DTS"));

                DataRelation relation = new DataRelation("SALE_ID", dsSales.Tables["SALE_MAS"].Columns["SALE_ID"], dsSales.Tables["SALE_DTS"].Columns["SALE_ID_FK"]);

                dsSales.Relations.Add(relation);
                grdSalesMaster.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                grdSalesMaster.DataSource = dsSales;
                grdSalesMaster.DataMember = "SALE_MAS";
                grdSalesDetails.DataSource = dsSales.Tables[1];

                //grdInvDts.DataMember = "INV_DTS";
                grdSalesMaster.Columns["SALE_DATE"].FormatString = "{0:dd/MM/yyyy}";
                grdSalesMaster.Columns["TOTAL_AMOUNT"].FormatString = "{0:#####0.00}";
                grdSalesMaster.Columns["SALE_ID"].IsVisible = false;

                GridViewTemplateCollection Sale_Dts = grdSalesMaster.Templates;

                if (Sale_Dts.Count > 0)
                {
                    foreach (GridViewTemplate Sale_Details in Sale_Dts)
                    {
                        Sale_Details.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                        // Received_Details.BestFitColumns(BestFitColumnMode.AllCells);
                        Sale_Details.Columns["SALE_DTS_ID"].IsVisible = false;
                        Sale_Details.Columns["SALE_ID_FK"].IsVisible = false;
                        Sale_Details.Columns["ITEM_NAME"].WrapText = true;
                        Sale_Details.Columns["QTY"].FormatString = "{0:0}";
                        Sale_Details.Columns["PRICE"].FormatString = "{0:#####0.00}";
                        Sale_Details.AllowAddNewRow = false;
                        Sale_Details.AllowDeleteRow = false;
                    }
                }

                this.grdSalesMaster.GridNavigator.SelectFirstRow();
            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

    }
}
