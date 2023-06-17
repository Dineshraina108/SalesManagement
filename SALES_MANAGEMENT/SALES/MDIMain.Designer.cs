namespace SALES
{
    partial class MDIMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.stsbar = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblCurrentDate = new Telerik.WinControls.UI.RadLabelElement();
            this.lblDate = new Telerik.WinControls.UI.RadLabelElement();
            this.MenuBar = new Telerik.WinControls.UI.RadMenu();
            this.mnuSales = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuSalesNew = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuSalesModify = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuSalesCancel = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuReports = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuRprtSales = new Telerik.WinControls.UI.RadMenuItem();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stsbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.stsbar);
            this.pnlMain.Controls.Add(this.MenuBar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1210, 483);
            this.pnlMain.TabIndex = 4;
            // 
            // stsbar
            // 
            this.stsbar.BackColor = System.Drawing.Color.LightCyan;
            this.stsbar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stsbar.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblCurrentDate,
            this.lblDate});
            this.stsbar.Location = new System.Drawing.Point(0, 459);
            this.stsbar.Name = "stsbar";
            this.stsbar.Size = new System.Drawing.Size(1210, 24);
            this.stsbar.TabIndex = 1;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.stsbar.SetSpring(this.lblCurrentDate, false);
            this.lblCurrentDate.Text = "Current Date and Time :";
            this.lblCurrentDate.TextWrap = true;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(17)))), ((int)(((byte)(231)))));
            this.lblDate.Name = "lblDate";
            this.stsbar.SetSpring(this.lblDate, false);
            this.lblDate.Text = "";
            this.lblDate.TextWrap = true;
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.Color.LightCyan;
            this.MenuBar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBar.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.mnuSales,
            this.mnuReports});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1210, 20);
            this.MenuBar.TabIndex = 0;
            // 
            // mnuSales
            // 
            this.mnuSales.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.mnuSalesNew,
            this.mnuSalesModify,
            this.mnuSalesCancel});
            this.mnuSales.Name = "mnuSales";
            this.mnuSales.Text = "Sales";
            // 
            // mnuSalesNew
            // 
            this.mnuSalesNew.Name = "mnuSalesNew";
            this.mnuSalesNew.Text = "New";
            this.mnuSalesNew.Click += new System.EventHandler(this.mnuSalesNew_Click);
            // 
            // mnuSalesModify
            // 
            this.mnuSalesModify.Name = "mnuSalesModify";
            this.mnuSalesModify.Text = "Modify";
            this.mnuSalesModify.Click += new System.EventHandler(this.mnuSalesModify_Click);
            // 
            // mnuSalesCancel
            // 
            this.mnuSalesCancel.Name = "mnuSalesCancel";
            this.mnuSalesCancel.Text = "Cancel";
            this.mnuSalesCancel.Click += new System.EventHandler(this.mnuSalesCancel_Click);
            // 
            // mnuReports
            // 
            this.mnuReports.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.mnuRprtSales});
            this.mnuReports.Name = "mnuReports";
            this.mnuReports.Text = "Reports";
            // 
            // mnuRprtSales
            // 
            this.mnuRprtSales.Name = "mnuRprtSales";
            this.mnuRprtSales.Text = "Sales Report";
            this.mnuRprtSales.Click += new System.EventHandler(this.mnuRprtSales_Click);
            // 
            // MDIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1210, 483);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MDIMain";
            this.Text = "SALES MANAGEMENT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stsbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBar)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private Telerik.WinControls.UI.RadMenu MenuBar;
        private Telerik.WinControls.UI.RadMenuItem mnuSales;
        private Telerik.WinControls.UI.RadMenuItem mnuSalesNew;
        private Telerik.WinControls.UI.RadMenuItem mnuSalesModify;
        private Telerik.WinControls.UI.RadMenuItem mnuSalesCancel;
        private Telerik.WinControls.UI.RadMenuItem mnuReports;
        private Telerik.WinControls.UI.RadMenuItem mnuRprtSales;
        private Telerik.WinControls.UI.RadStatusStrip stsbar;
        private Telerik.WinControls.UI.RadLabelElement lblCurrentDate;
        private Telerik.WinControls.UI.RadLabelElement lblDate;
    }
}



