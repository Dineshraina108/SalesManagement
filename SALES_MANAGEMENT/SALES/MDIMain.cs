using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SALES;

namespace SALES
{
    public partial class MDIMain : Form
    {
        public MDIMain()
        {
            InitializeComponent();
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
        }

        private void mnuSalesNew_Click(object sender, EventArgs e)
        {
            //ShowScreen(new frmSales(UserAction.CREATE, 0), FormWindowState.Normal);

            frmSales frm = new frmSales(UserAction.CREATE, 0);
            frm.Show();
        }

        private void mnuSalesModify_Click(object sender, EventArgs e)
        {
            // ShowScreen(new frmSalesDetails(UserAction.MODIFY), FormWindowState.Normal);
            frmSalesDetails frm = new frmSalesDetails(UserAction.MODIFY);
            frm.Show();

        }

        private void mnuSalesCancel_Click(object sender, EventArgs e)
        {
            frmSalesDetails frm = new frmSalesDetails(UserAction.CANCEL);
            frm.Show();
        }

        private void mnuRprtSales_Click(object sender, EventArgs e)
        {

        }

        public void ShowScreen(Form frm, FormWindowState WindowState)
        {
            frm.MdiParent = this;
            frm.WindowState = WindowState;
           // frm.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            if (WindowState == FormWindowState.Normal)
            {
                frm.StartPosition = FormStartPosition.CenterScreen;
            }

            frm.Show();
        }
    }
}
