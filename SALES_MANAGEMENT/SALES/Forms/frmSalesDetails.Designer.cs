namespace SALES
{
    partial class frmSalesDetails
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
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn1 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn2 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn3 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn4 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn5 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn6 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn7 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn8 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn9 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn10 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn11 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn12 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewBrowseColumn gridViewBrowseColumn13 = new Telerik.WinControls.UI.GridViewBrowseColumn();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem1 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.grdSalesMaster = new Telerik.WinControls.UI.RadGridView();
            this.grdSalesDetails = new Telerik.WinControls.UI.GridViewTemplate();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSalesFromDate = new System.Windows.Forms.Label();
            this.dtpSalesDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblSalesToDate = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtpSalesFromDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rpnlHeader = new Telerik.WinControls.UI.RadPanel();
            this.pnlMain.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesMaster.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSalesDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSalesFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpnlHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.pnlMiddle);
            this.pnlMain.Controls.Add(this.rpnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1197, 486);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.pnlGrid);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 42);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1197, 444);
            this.pnlMiddle.TabIndex = 2;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.btnView);
            this.pnlGrid.Controls.Add(this.grdSalesMaster);
            this.pnlGrid.Controls.Add(this.btnClear);
            this.pnlGrid.Controls.Add(this.lblSalesFromDate);
            this.pnlGrid.Controls.Add(this.dtpSalesDate);
            this.pnlGrid.Controls.Add(this.lblSalesToDate);
            this.pnlGrid.Controls.Add(this.btnExit);
            this.pnlGrid.Controls.Add(this.dtpSalesFromDate);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1197, 444);
            this.pnlGrid.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.SteelBlue;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(424, 14);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(64, 24);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // grdSalesMaster
            // 
            this.grdSalesMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSalesMaster.AutoGenerateHierarchy = true;
            this.grdSalesMaster.BackColor = System.Drawing.Color.Transparent;
            this.grdSalesMaster.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSalesMaster.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.grdSalesMaster.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grdSalesMaster.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdSalesMaster.Location = new System.Drawing.Point(14, 56);
            // 
            // 
            // 
            this.grdSalesMaster.MasterTemplate.AllowAddNewRow = false;
            this.grdSalesMaster.MasterTemplate.AllowColumnReorder = false;
            this.grdSalesMaster.MasterTemplate.AllowDeleteRow = false;
            this.grdSalesMaster.MasterTemplate.AllowDragToGroup = false;
            this.grdSalesMaster.MasterTemplate.AllowEditRow = false;
            this.grdSalesMaster.MasterTemplate.AutoExpandGroups = true;
            this.grdSalesMaster.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewBrowseColumn1.EnableExpressionEditor = false;
            gridViewBrowseColumn1.FieldName = "CUSTOMER_NAME";
            gridViewBrowseColumn1.HeaderText = "CUSTOMER NAME";
            gridViewBrowseColumn1.Name = "CUSTOMER_NAME";
            gridViewBrowseColumn1.ReadOnly = true;
            gridViewBrowseColumn1.Width = 365;
            gridViewBrowseColumn2.EnableExpressionEditor = false;
            gridViewBrowseColumn2.FieldName = "SALE_DATE";
            gridViewBrowseColumn2.HeaderText = "SALES DATE";
            gridViewBrowseColumn2.Name = "SALE_DATE";
            gridViewBrowseColumn2.ReadOnly = true;
            gridViewBrowseColumn2.Width = 182;
            gridViewBrowseColumn3.EnableExpressionEditor = false;
            gridViewBrowseColumn3.FieldName = "BILL_NO";
            gridViewBrowseColumn3.HeaderText = "BILL NO";
            gridViewBrowseColumn3.Name = "BILL_NO";
            gridViewBrowseColumn3.ReadOnly = true;
            gridViewBrowseColumn3.Width = 182;
            gridViewBrowseColumn4.EnableExpressionEditor = false;
            gridViewBrowseColumn4.FieldName = "TAX";
            gridViewBrowseColumn4.HeaderText = "TAX";
            gridViewBrowseColumn4.Name = "TAX";
            gridViewBrowseColumn4.ReadOnly = true;
            gridViewBrowseColumn4.Width = 182;
            gridViewBrowseColumn5.EnableExpressionEditor = false;
            gridViewBrowseColumn5.FieldName = "TOTAL_AMOUNT";
            gridViewBrowseColumn5.HeaderText = "TOTAL AMOUNT";
            gridViewBrowseColumn5.Name = "TOTAL_AMOUNT";
            gridViewBrowseColumn5.ReadOnly = true;
            gridViewBrowseColumn5.Width = 222;
            gridViewBrowseColumn6.EnableExpressionEditor = false;
            gridViewBrowseColumn6.FieldName = "SALE_ID";
            gridViewBrowseColumn6.HeaderText = "SALE ID";
            gridViewBrowseColumn6.IsVisible = false;
            gridViewBrowseColumn6.Name = "SALE_ID";
            gridViewBrowseColumn6.ReadOnly = true;
            this.grdSalesMaster.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewBrowseColumn1,
            gridViewBrowseColumn2,
            gridViewBrowseColumn3,
            gridViewBrowseColumn4,
            gridViewBrowseColumn5,
            gridViewBrowseColumn6});
            this.grdSalesMaster.MasterTemplate.EnableAlternatingRowColor = true;
            this.grdSalesMaster.MasterTemplate.EnableFiltering = true;
            this.grdSalesMaster.MasterTemplate.EnableGrouping = false;
            this.grdSalesMaster.MasterTemplate.Templates.AddRange(new Telerik.WinControls.UI.GridViewTemplate[] {
            this.grdSalesDetails});
            this.grdSalesMaster.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.grdSalesMaster.Name = "grdSalesMaster";
            this.grdSalesMaster.ReadOnly = true;
            this.grdSalesMaster.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdSalesMaster.ShowGroupPanel = false;
            this.grdSalesMaster.Size = new System.Drawing.Size(1171, 376);
            this.grdSalesMaster.TabIndex = 6;
            this.grdSalesMaster.ViewRowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.grdSalesMaster_ViewRowFormatting);
            this.grdSalesMaster.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.grdSalesMaster_ViewCellFormatting);
            this.grdSalesMaster.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.grdSalesMaster_CellDoubleClick);
            // 
            // grdSalesDetails
            // 
            this.grdSalesDetails.AllowAddNewRow = false;
            this.grdSalesDetails.AllowDeleteRow = false;
            this.grdSalesDetails.AllowEditRow = false;
            this.grdSalesDetails.AutoExpandGroups = true;
            this.grdSalesDetails.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewBrowseColumn7.EnableExpressionEditor = false;
            gridViewBrowseColumn7.FieldName = "BILL_NO";
            gridViewBrowseColumn7.HeaderText = "BILL NO";
            gridViewBrowseColumn7.Name = "BILL_NO";
            gridViewBrowseColumn7.ReadOnly = true;
            gridViewBrowseColumn7.Width = 91;
            gridViewBrowseColumn8.EnableExpressionEditor = false;
            gridViewBrowseColumn8.FieldName = "ITEM_NO";
            gridViewBrowseColumn8.HeaderText = "ITEM NO";
            gridViewBrowseColumn8.Name = "ITEM_NO";
            gridViewBrowseColumn8.ReadOnly = true;
            gridViewBrowseColumn8.Width = 91;
            gridViewBrowseColumn9.EnableExpressionEditor = false;
            gridViewBrowseColumn9.FieldName = "ITEM_NAME";
            gridViewBrowseColumn9.HeaderText = "ITEM NAME";
            gridViewBrowseColumn9.Name = "ITEM_NAME";
            gridViewBrowseColumn9.ReadOnly = true;
            gridViewBrowseColumn9.Width = 181;
            gridViewBrowseColumn10.EnableExpressionEditor = false;
            gridViewBrowseColumn10.FieldName = "QTY";
            gridViewBrowseColumn10.HeaderText = "QUANTITY";
            gridViewBrowseColumn10.Name = "QTY";
            gridViewBrowseColumn10.ReadOnly = true;
            gridViewBrowseColumn10.Width = 91;
            gridViewBrowseColumn11.EnableExpressionEditor = false;
            gridViewBrowseColumn11.FieldName = "PRICE";
            gridViewBrowseColumn11.HeaderText = "PRICE";
            gridViewBrowseColumn11.Name = "PRICE";
            gridViewBrowseColumn11.ReadOnly = true;
            gridViewBrowseColumn11.Width = 91;
            gridViewBrowseColumn12.EnableExpressionEditor = false;
            gridViewBrowseColumn12.FieldName = "SALE_DTS_ID";
            gridViewBrowseColumn12.HeaderText = "SALE_DTS_ID";
            gridViewBrowseColumn12.IsVisible = false;
            gridViewBrowseColumn12.Name = "SALE_DTS_ID";
            gridViewBrowseColumn12.ReadOnly = true;
            gridViewBrowseColumn13.EnableExpressionEditor = false;
            gridViewBrowseColumn13.FieldName = "SALE_ID_FK";
            gridViewBrowseColumn13.HeaderText = "SALE_ID_FK";
            gridViewBrowseColumn13.IsVisible = false;
            gridViewBrowseColumn13.Name = "SALE_ID_FK";
            gridViewBrowseColumn13.ReadOnly = true;
            gridViewBrowseColumn13.Width = 44;
            this.grdSalesDetails.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewBrowseColumn7,
            gridViewBrowseColumn8,
            gridViewBrowseColumn9,
            gridViewBrowseColumn10,
            gridViewBrowseColumn11,
            gridViewBrowseColumn12,
            gridViewBrowseColumn13});
            this.grdSalesDetails.EnableAlternatingRowColor = true;
            this.grdSalesDetails.EnableFiltering = true;
            this.grdSalesDetails.EnableGrouping = false;
            this.grdSalesDetails.ReadOnly = true;
            gridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem1.AggregateExpression = null;
            gridViewSummaryItem1.FormatString = "{0}";
            gridViewSummaryItem1.Name = "PRICE";
            this.grdSalesDetails.SummaryRowsBottom.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1}));
            this.grdSalesDetails.ViewDefinition = tableViewDefinition1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(504, 14);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 24);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSalesFromDate
            // 
            this.lblSalesFromDate.AutoSize = true;
            this.lblSalesFromDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesFromDate.ForeColor = System.Drawing.Color.Navy;
            this.lblSalesFromDate.Location = new System.Drawing.Point(12, 14);
            this.lblSalesFromDate.Name = "lblSalesFromDate";
            this.lblSalesFromDate.Size = new System.Drawing.Size(92, 21);
            this.lblSalesFromDate.TabIndex = 4;
            this.lblSalesFromDate.Text = "Sales From";
            // 
            // dtpSalesDate
            // 
            this.dtpSalesDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalesDate.Location = new System.Drawing.Point(289, 14);
            this.dtpSalesDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSalesDate.Name = "dtpSalesDate";
            this.dtpSalesDate.Size = new System.Drawing.Size(106, 27);
            this.dtpSalesDate.TabIndex = 2;
            this.dtpSalesDate.TabStop = false;
            this.dtpSalesDate.Text = "16-06-2023";
            this.dtpSalesDate.Value = new System.DateTime(2023, 6, 16, 9, 32, 36, 325);
            this.dtpSalesDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpSalesDate_KeyDown);
            // 
            // lblSalesToDate
            // 
            this.lblSalesToDate.AutoSize = true;
            this.lblSalesToDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesToDate.ForeColor = System.Drawing.Color.Navy;
            this.lblSalesToDate.Location = new System.Drawing.Point(252, 14);
            this.lblSalesToDate.Name = "lblSalesToDate";
            this.lblSalesToDate.Size = new System.Drawing.Size(28, 21);
            this.lblSalesToDate.TabIndex = 4;
            this.lblSalesToDate.Text = "To";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(583, 14);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtpSalesFromDate
            // 
            this.dtpSalesFromDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalesFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalesFromDate.Location = new System.Drawing.Point(119, 14);
            this.dtpSalesFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpSalesFromDate.Name = "dtpSalesFromDate";
            this.dtpSalesFromDate.Size = new System.Drawing.Size(116, 27);
            this.dtpSalesFromDate.TabIndex = 1;
            this.dtpSalesFromDate.TabStop = false;
            this.dtpSalesFromDate.Text = "16-06-2023";
            this.dtpSalesFromDate.Value = new System.DateTime(2023, 6, 16, 9, 32, 36, 325);
            this.dtpSalesFromDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpSalesFromDate_KeyDown);
            // 
            // rpnlHeader
            // 
            this.rpnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.rpnlHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpnlHeader.ForeColor = System.Drawing.Color.DarkMagenta;
            this.rpnlHeader.Location = new System.Drawing.Point(0, 0);
            this.rpnlHeader.Name = "rpnlHeader";
            this.rpnlHeader.Size = new System.Drawing.Size(1197, 42);
            this.rpnlHeader.TabIndex = 1;
            this.rpnlHeader.Text = "SALES DETAILS";
            this.rpnlHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSalesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1197, 486);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSalesDetails";
            this.Text = "Sales Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSalesDetails_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMiddle.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesMaster.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSalesDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSalesFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpnlHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private Telerik.WinControls.UI.RadPanel rpnlHeader;
        private System.Windows.Forms.Panel pnlMiddle;
        private Telerik.WinControls.UI.RadDateTimePicker dtpSalesDate;
        private Telerik.WinControls.UI.RadDateTimePicker dtpSalesFromDate;
        private System.Windows.Forms.Label lblSalesToDate;
        private System.Windows.Forms.Label lblSalesFromDate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlGrid;
        private Telerik.WinControls.UI.RadGridView grdSalesMaster;
        private Telerik.WinControls.UI.GridViewTemplate grdSalesDetails;
    }
}