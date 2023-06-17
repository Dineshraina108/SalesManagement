using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Common;
using MessageLibrary;

namespace SALES
{
    public partial class frmSales : Form, ICustomForm
    {
        UserAction Action = new UserAction();
        long lngSaleId;
        bool blnLeavingGrid = false;
        bool blnCancelEdit;

        public bool CancelEdit
        {
            get { return blnCancelEdit; }
            set { blnCancelEdit = value; }
        }

        public frmSales()
        {
            InitializeComponent();
        }

        public frmSales(UserAction action, long SaleId) : this()
        {
            lngSaleId = SaleId;
            Action = action;
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            try
            {
                General.SetControlStyle(this.Controls);
                General.CustomRadGridBehaviour(this);

                Load_Taxs();

                if (Action == UserAction.CREATE)
                    dtpSalesDate.Value = DateTime.Now.Date;
                else if(Action == UserAction.CANCEL)
                {
                    Load_Sale_Detail();
                    pnlTop.Enabled = false;
                    pnlGrid.Enabled = false;
                    txtTotal.Enabled = false;
                    btnSave.Text = "CANCEL";
                }
                else
                {
                    Load_Sale_Detail();
                }
            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

        private void txtCustName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                dtpSalesDate.Focus();
            }
        }

        private void dtpSalesDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtBillNo.Focus();
            }
        }

        private void txtBillNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                ddlTax.Focus();
            }
        }

        private void ddlTax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if(Action == UserAction. CREATE || Action == UserAction.MODIFY)
                {
                    grdSalesDetails.Rows.AddNew();
                    grdSalesDetails.CurrentRow = grdSalesDetails.Rows[0];
                    grdSalesDetails.CurrentColumn = grdSalesDetails.Columns["ITEM_NO"];
                    grdSalesDetails.BeginEdit();
                }
            }
        }

        private void txtTotal_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void grdSalesDetails_CellEditorInitialized(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

        private void grdSalesDetails_CellEndEdit(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            bool blnAddNewRow = true;
            try
            {
                if (blnCancelEdit)
                {
                    blnCancelEdit = false;
                    grdSalesDetails.Focus();
                    return;
                }

                if (blnLeavingGrid)
                {
                    blnLeavingGrid = false;
                    return;
                }

                RadGridFunctionality.MoveNextColumn(ref grdSalesDetails, blnAddNewRow, txtTotal, null);
            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

        private void grdSalesDetails_CellValidating(object sender, Telerik.WinControls.UI.CellValidatingEventArgs e)
        {
            try
            {
                if (blnLeavingGrid)
                {
                    grdSalesDetails.CancelEdit();
                    return;
                }
            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

        private void grdSalesDetails_UserDeletingRow(object sender, Telerik.WinControls.UI.GridViewRowCancelEventArgs e)
        {
            try
            {
                if (!ConfirmDelete(grdSalesDetails.CurrentRow.Cells["SALE_DTS_ID"].Value.GetStringValue()))
                {
                    e.Cancel = true;
                    return;
                }

                Deleted_Items();
            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

        private void grdSalesDetails_Leave(object sender, EventArgs e)
        {
            blnLeavingGrid = true;
        }

        private void grdSalesDetails_ViewCellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            Color foreColor = e.CellElement.ForeColor;

            try
            {
                if (e.CellElement is GridSummaryCellElement)
                {
                    Font fnt = new Font(grdSalesDetails.Font.FontFamily, 9, FontStyle.Bold);
                    e.CellElement.Font = fnt;
                    e.CellElement.TextAlignment = ContentAlignment.MiddleRight;
                    e.CellElement.ForeColor = Color.Brown;
                }
            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

        private void grdSalesDetails_ViewRowFormatting(object sender, Telerik.WinControls.UI.RowFormattingEventArgs e)
        {
            try
            {
                if (e.RowElement is GridTableHeaderRowElement)
                {
                    Font fnt = new Font(grdSalesDetails.Font.FontFamily, 10, FontStyle.Bold);

                    e.RowElement.DrawFill = true;
                    e.RowElement.GradientStyle = GradientStyles.Solid;
                    e.RowElement.BackColor = Color.Transparent;
                    e.RowElement.ForeColor = Color.DarkMagenta;
                    e.RowElement.RowInfo.Height = 25;
                    e.RowElement.Font = fnt;
                }
            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            grdSalesDetails.Rows.AddNew();
            grdSalesDetails.CurrentRow = grdSalesDetails.Rows[grdSalesDetails.Rows.Count -1];
            grdSalesDetails.CurrentColumn = grdSalesDetails.Columns["ITEM_NO"];
            grdSalesDetails.CurrentRow.Cells["SALE_DTS_ID"].Value = 0;
            grdSalesDetails.BeginEdit();
            grdSalesDetails.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (grdSalesDetails.Rows.Count > 0)
                {
                    if (ConfirmDelete(grdSalesDetails.CurrentRow.Cells["SALE_DTS_ID"].Value.GetStringValue()))
                    {
                        Deleted_Items();
                        grdSalesDetails.Rows.RemoveAt(grdSalesDetails.CurrentRow.Index);
                    }
                        
                     grdSalesDetails.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtSaleMaster, dtSaleDts;
            string[] strParameters;
            string[] strValues;
            long lngUpdatedRecords = 0;
            long SaleId = 0;

            try
            {
                if (Action == UserAction.CREATE)
                {
                    if (isValid())
                    {
                        strParameters = new string[] { "CUSTOMER_NAME", "BILL_NO", "SALE_DATE", "TAX", "TOTAL_AMOUNT" };


                        strValues = new string[] { txtCustName.Text, txtBillNo.Text,dtpSalesDate.Value.ToShortDateString(),
                                                   string.Format("{0:0}", ddlTax.Text.ToDouble()),
                                                   string.Format("{0:0.00}", txtTotal.Text.ToDouble())};

                        dtSaleMaster = Utilities.CreateDataTable(strParameters, strValues);

                        strParameters = new string[] { "ITEM_NO", "ITEM_NAME", "QTY", "PRICE" };

                        dtSaleDts = Utilities.CreateDataTable(grdSalesDetails, strParameters);

                        if (dtSaleMaster.HasRecords() && dtSaleDts.HasRecords())
                        {
                            SaleId = BL_Sales.Create_Sale(dtSaleMaster, dtSaleDts);

                            if (SaleId > 0)
                            {
                                MyMessage.ShowMessage("Sale saved successfully", MessageBoxButtons.OK, MessageType.Success);
                                pnlTop.Enabled = false;
                                pnlGrid.Enabled = false;
                                txtTotal.Enabled = false;
                                btnSave.Enabled = false;
                                btnClear.Focus();
                            }
                            else
                            {
                                MyMessage.ShowMessage("Failed to save Sale", MessageBoxButtons.OK, MessageType.Failed);
                            }
                        }
                        else
                        {
                            MyMessage.ShowMessage("Sale details not available", MessageBoxButtons.OK, MessageType.Warning);
                        }
                    }
                }
                else if (Action == UserAction.MODIFY)
                {
                    if (isValid())
                    {
                        strParameters = new string[] {"SALE_ID", "CUSTOMER_NAME", "BILL_NO", "SALE_DATE", "TAX", "TOTAL_AMOUNT" };


                        strValues = new string[] { lngSaleId.ToString(), txtCustName.Text, txtBillNo.Text,dtpSalesDate.Value.ToShortDateString(),
                                                   string.Format("{0:0}", ddlTax.Text.ToDouble()),
                                                   string.Format("{0:0.00}", txtTotal.Text.ToDouble())};

                        dtSaleMaster = Utilities.CreateDataTable(strParameters, strValues);

                        strParameters = new string[] { "ITEM_NO", "ITEM_NAME", "QTY", "PRICE" , "SALE_DTS_ID"};

                        dtSaleDts = Utilities.CreateDataTable(grdSalesDetails, strParameters);

                        if (dtSaleMaster.HasRecords() && dtSaleDts.HasRecords())
                        {
                            lngUpdatedRecords = BL_Sales.Modify_Sale(dtSaleMaster, dtSaleDts);

                            if (lngUpdatedRecords > 0)
                            {
                                MyMessage.ShowMessage("Sales Details updated successfully", MessageBoxButtons.OK, MessageType.Success);
                                this.Close();
                            }
                            else if (lngUpdatedRecords == 0)
                            {
                                MyMessage.ShowMessage("Failed to update Sale Details", MessageBoxButtons.OK, MessageType.Failed);
                            }
                        }
                        else
                        {
                            MyMessage.ShowMessage("Sale Details not update without details", MessageBoxButtons.OK, MessageType.Warning);
                        }
                    }
                }
                else if (Action == UserAction.CANCEL)
                {
                    if (MyMessage.ShowMessage("Are you sure Confirm cancel \n the Sale ? ", MessageBoxButtons.YesNo, MessageType.Question) == DialogResult.Yes)
                    {
                        bool Result = BL_Sales.Cancel_Sale(lngSaleId, 0); 

                        if (Result)
                        {
                            MyMessage.ShowMessage("Sale cancelled successfully", MessageBoxButtons.OK, MessageType.Success);
                            this.Close();
                        }
                        else 
                        {
                            MyMessage.ShowMessage("Failed to Cancel sale", MessageBoxButtons.OK, MessageType.Failed);
                        }
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtCustName.Text = "";
                dtpSalesDate.Value = DateTime.Now.Date;
                txtBillNo.Text = "";
                ddlTax.SelectedIndex = 0;
                txtTotal.Text = "";
                grdSalesDetails.DataSource = null;
                pnlGrid.Update();
                txtCustName.Focus();
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

        public void Load_Taxs()
        {
            DataTable dtTaxs = new DataTable();

            try
            {
                dtTaxs = BL_Sales.Get_Taxs();

                if(dtTaxs.Rows.Count > 0)
                {
                    ddlTax.DataSource = dtTaxs;
                    ddlTax.ValueMember = "ID";
                    ddlTax.DisplayMember = "TAX_PERC";
                    ddlTax.SelectedIndex = 0;
                }
                else
                    MessageBox.Show("No Tax are available");
            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

        private bool ConfirmDelete(string saleDtsId)
        {
            DialogResult DResult = new DialogResult();
            try
            {
                if (grdSalesDetails.Rows.Count == 1)
                {
                    DResult = MessageBox.Show("You cannot delete all the items.\n Should have atleast one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (saleDtsId != "")
                {
                    DResult = MessageBox.Show("Do you want to Delete this item ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DResult == DialogResult.Yes)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool isValid()
        {
            bool blnValid = true;

            try
            {
                if (txtCustName.Text == "")
                {
                    MyMessage.ShowMessage("Customer Name cannot be empty", MessageBoxButtons.OK, MessageType.Warning);
                    txtCustName.Focus();
                    blnValid = false;
                }

                if (dtpSalesDate.Value == dtpSalesDate.MinDate)
                {
                    MyMessage.ShowMessage("Sale Date not valid", MessageBoxButtons.OK, MessageType.Warning);
                    dtpSalesDate.Focus();
                    blnValid = false;
                }

                if (txtBillNo.Text == "")
                {
                    MyMessage.ShowMessage("Bill No cannot be empty", MessageBoxButtons.OK, MessageType.Warning);
                    txtBillNo.Focus();
                    blnValid = false;
                }

                if (ddlTax.SelectedIndex == -1)
                {
                    MyMessage.ShowMessage("Tax  cannot be empty", MessageBoxButtons.OK, MessageType.Warning);
                    ddlTax.Focus();
                    blnValid = false;
                }

                if (txtTotal.Text == "")
                {
                    MyMessage.ShowMessage("Total Amount cannot be empty", MessageBoxButtons.OK, MessageType.Warning);
                    txtTotal.Focus();
                    blnValid = false;
                }

                if (grdSalesDetails.Rows.Count == 0)
                {
                    MyMessage.ShowMessage("Sale details cannot be empty", MessageBoxButtons.OK, MessageType.Warning);
                    blnValid = false;
                }
                else
                {
                    if (grdSalesDetails.Rows.Count > 0)
                    {
                        foreach (GridViewRowInfo row in grdSalesDetails.Rows)
                        {
                            if (row.Cells["ITEM_NO"].Value.ToLong() <= 0)
                            {
                                MyMessage.ShowMessage("Item No cannot be empty ", MessageBoxButtons.OK, MessageType.Warning);
                                grdSalesDetails.CurrentRow = row;
                                grdSalesDetails.CurrentColumn = grdSalesDetails.Columns["ITEM_NO"];
                                grdSalesDetails.Focus();
                                grdSalesDetails.BeginEdit();
                                blnValid = false;
                            }
                            else if(row.Cells["ITEM_NAME"].Value.ToString() == "")
                            {
                                MyMessage.ShowMessage("Item NAME cannot be empty ", MessageBoxButtons.OK, MessageType.Warning);
                                grdSalesDetails.CurrentRow = row;
                                grdSalesDetails.CurrentColumn = grdSalesDetails.Columns["ITEM_NAME"];
                                grdSalesDetails.Focus();
                                grdSalesDetails.BeginEdit();
                                blnValid = false;
                            }
                            else if(row.Cells["QTY"].Value.ToDouble() <= 0)
                            {
                                MyMessage.ShowMessage("Qty cannot be empty ", MessageBoxButtons.OK, MessageType.Warning);
                                grdSalesDetails.CurrentRow = row;
                                grdSalesDetails.CurrentColumn = grdSalesDetails.Columns["QTY"];
                                grdSalesDetails.Focus();
                                grdSalesDetails.BeginEdit();
                                blnValid = false;
                            }
                            else if (row.Cells["PRICE"].Value.ToDouble() <= 0)
                            {
                                MyMessage.ShowMessage("Price cannot be empty ", MessageBoxButtons.OK, MessageType.Warning);
                                grdSalesDetails.CurrentRow = row;
                                grdSalesDetails.CurrentColumn = grdSalesDetails.Columns["PRICE"];
                                grdSalesDetails.Focus();
                                grdSalesDetails.BeginEdit();
                                blnValid = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                blnValid = false;
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }

            return blnValid;
        }

        private void Deleted_Items()
        {
            long SaleDtsId = 0;

            try
            {
                SaleDtsId = grdSalesDetails.CurrentRow.Cells["SALE_DTS_ID"].Value.ToLong();

                bool Result = BL_Sales.Cancel_Sale(lngSaleId, SaleDtsId);

                if (Result)
                {
                    MyMessage.ShowMessage("Item removed successfully", MessageBoxButtons.OK, MessageType.Success);
                }
                else
                {
                    MyMessage.ShowMessage("Failed to Remove item", MessageBoxButtons.OK, MessageType.Failed);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_Sale_Detail()
        {
            DataTable dtSales;

            try
            {
                dtSales = BL_Sales.Get_Sales(lngSaleId, "", "");

                if (dtSales.HasRecords())
                {
                    txtCustName.Text = dtSales.Rows[0]["CUSTOMER_NAME"].ToString();
                    txtBillNo.Text = dtSales.Rows[0]["BILL_NO"].ToString();
                    dtpSalesDate.Text= dtSales.Rows[0]["SALE_DATE"].ToString();
                    ddlTax.SelectedIndex = ddlTax.FindString(dtSales.Rows[0]["TAX"].ToString()) ;
                    txtTotal.Text= dtSales.Rows[0]["TOTAL_AMOUNT"].ToString();

                    grdSalesDetails.DataSource = dtSales;

                }
            }
            catch (Exception ex)
            {
                MyMessage.ShowMessage(ex.Message, MessageBoxButtons.OK, MessageType.Exception);
            }
        }

    }
}
