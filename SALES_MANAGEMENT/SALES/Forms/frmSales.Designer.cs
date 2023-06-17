namespace SALES
{
    partial class frmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewSummaryItem gridViewSummaryItem1 = new Telerik.WinControls.UI.GridViewSummaryItem();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grdSalesDetails = new Telerik.WinControls.UI.RadGridView();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.flpnlButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.ddlTax = new System.Windows.Forms.ComboBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.dtpSalesDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblSalesDate = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.rpnlHeader = new Telerik.WinControls.UI.RadPanel();
            this.pnlMain.SuspendLayout();
            this.pnlMiddle.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesDetails.MasterTemplate)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.flpnlButtons.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSalesDate)).BeginInit();
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
            this.pnlMain.Size = new System.Drawing.Size(1005, 478);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.Controls.Add(this.pnlGrid);
            this.pnlMiddle.Controls.Add(this.pnlBottom);
            this.pnlMiddle.Controls.Add(this.pnlTop);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Location = new System.Drawing.Point(0, 42);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1005, 436);
            this.pnlMiddle.TabIndex = 1;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.pnlRight);
            this.pnlGrid.Controls.Add(this.grdSalesDetails);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 43);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1005, 355);
            this.pnlGrid.TabIndex = 2;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.btnRemove);
            this.pnlRight.Controls.Add(this.btnAdd);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(890, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(115, 355);
            this.pnlRight.TabIndex = 6;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(17, 166);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 51);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(15, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 50);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grdSalesDetails
            // 
            this.grdSalesDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSalesDetails.AutoScroll = true;
            this.grdSalesDetails.BackColor = System.Drawing.Color.Transparent;
            this.grdSalesDetails.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnEnter;
            this.grdSalesDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdSalesDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdSalesDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grdSalesDetails.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdSalesDetails.Location = new System.Drawing.Point(14, 6);
            // 
            // 
            // 
            this.grdSalesDetails.MasterTemplate.AllowAddNewRow = false;
            this.grdSalesDetails.MasterTemplate.AllowColumnReorder = false;
            this.grdSalesDetails.MasterTemplate.AllowColumnResize = false;
            this.grdSalesDetails.MasterTemplate.AllowDeleteRow = false;
            this.grdSalesDetails.MasterTemplate.AllowDragToGroup = false;
            this.grdSalesDetails.MasterTemplate.AutoExpandGroups = true;
            this.grdSalesDetails.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "BILL_NO";
            gridViewTextBoxColumn1.HeaderText = "BILL NO";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "BILL_NO";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 90;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ITEM_NO";
            gridViewDecimalColumn1.HeaderText = "ITEM NO";
            gridViewDecimalColumn1.Name = "ITEM_NO";
            gridViewDecimalColumn1.Width = 154;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ITEM_NAME";
            gridViewTextBoxColumn2.HeaderText = "ITEM NAME";
            gridViewTextBoxColumn2.Name = "ITEM_NAME";
            gridViewTextBoxColumn2.Width = 384;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "QTY";
            gridViewDecimalColumn2.HeaderText = "QUANTITY";
            gridViewDecimalColumn2.Name = "QTY";
            gridViewDecimalColumn2.Width = 154;
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "PRICE";
            gridViewDecimalColumn3.HeaderText = "PRICE";
            gridViewDecimalColumn3.Name = "PRICE";
            gridViewDecimalColumn3.Width = 160;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "SALE_DTS_ID";
            gridViewTextBoxColumn3.HeaderText = "SALE_DTS_ID";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "SALE_DTS_ID";
            gridViewTextBoxColumn3.ReadOnly = true;
            this.grdSalesDetails.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewDecimalColumn3,
            gridViewTextBoxColumn3});
            this.grdSalesDetails.MasterTemplate.EnableAlternatingRowColor = true;
            this.grdSalesDetails.MasterTemplate.EnableGrouping = false;
            this.grdSalesDetails.MasterTemplate.EnableSorting = false;
            this.grdSalesDetails.MasterTemplate.ShowFilteringRow = false;
            gridViewSummaryItem1.Aggregate = Telerik.WinControls.UI.GridAggregateFunction.Sum;
            gridViewSummaryItem1.AggregateExpression = null;
            gridViewSummaryItem1.FormatString = "{0}";
            gridViewSummaryItem1.Name = "PRICE";
            this.grdSalesDetails.MasterTemplate.SummaryRowsBottom.Add(new Telerik.WinControls.UI.GridViewSummaryRowItem(new Telerik.WinControls.UI.GridViewSummaryItem[] {
                gridViewSummaryItem1}));
            this.grdSalesDetails.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.grdSalesDetails.Name = "grdSalesDetails";
            this.grdSalesDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grdSalesDetails.ShowGroupPanel = false;
            this.grdSalesDetails.Size = new System.Drawing.Size(870, 343);
            this.grdSalesDetails.TabIndex = 5;
            this.grdSalesDetails.ViewRowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.grdSalesDetails_ViewRowFormatting);
            this.grdSalesDetails.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.grdSalesDetails_ViewCellFormatting);
            this.grdSalesDetails.CellEditorInitialized += new Telerik.WinControls.UI.GridViewCellEventHandler(this.grdSalesDetails_CellEditorInitialized);
            this.grdSalesDetails.CellEndEdit += new Telerik.WinControls.UI.GridViewCellEventHandler(this.grdSalesDetails_CellEndEdit);
            this.grdSalesDetails.CellValidating += new Telerik.WinControls.UI.CellValidatingEventHandler(this.grdSalesDetails_CellValidating);
            this.grdSalesDetails.UserDeletingRow += new Telerik.WinControls.UI.GridViewRowCancelEventHandler(this.grdSalesDetails_UserDeletingRow);
            this.grdSalesDetails.Leave += new System.EventHandler(this.grdSalesDetails_Leave);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.txtTotal);
            this.pnlBottom.Controls.Add(this.lblTotal);
            this.pnlBottom.Controls.Add(this.flpnlButtons);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 398);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1005, 38);
            this.pnlBottom.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(125, 6);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(172, 25);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotal_KeyDown);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Navy;
            this.lblTotal.Location = new System.Drawing.Point(79, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 17);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total";
            // 
            // flpnlButtons
            // 
            this.flpnlButtons.Controls.Add(this.btnSave);
            this.flpnlButtons.Controls.Add(this.btnClear);
            this.flpnlButtons.Controls.Add(this.btnExit);
            this.flpnlButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpnlButtons.Location = new System.Drawing.Point(755, 0);
            this.flpnlButtons.Name = "flpnlButtons";
            this.flpnlButtons.Size = new System.Drawing.Size(250, 38);
            this.flpnlButtons.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.ForestGreen;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(84, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(165, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.ddlTax);
            this.pnlTop.Controls.Add(this.lblTax);
            this.pnlTop.Controls.Add(this.txtBillNo);
            this.pnlTop.Controls.Add(this.lblBillNo);
            this.pnlTop.Controls.Add(this.dtpSalesDate);
            this.pnlTop.Controls.Add(this.lblSalesDate);
            this.pnlTop.Controls.Add(this.txtCustName);
            this.pnlTop.Controls.Add(this.lblCustName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1005, 43);
            this.pnlTop.TabIndex = 0;
            // 
            // ddlTax
            // 
            this.ddlTax.FormattingEnabled = true;
            this.ddlTax.Location = new System.Drawing.Point(938, 9);
            this.ddlTax.Name = "ddlTax";
            this.ddlTax.Size = new System.Drawing.Size(53, 25);
            this.ddlTax.TabIndex = 4;
            this.ddlTax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ddlTax_KeyDown);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.Color.Navy;
            this.lblTax.Location = new System.Drawing.Point(902, 13);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(29, 17);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "Tax";
            // 
            // txtBillNo
            // 
            this.txtBillNo.Location = new System.Drawing.Point(784, 9);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(100, 25);
            this.txtBillNo.TabIndex = 3;
            this.txtBillNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBillNo_KeyDown);
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillNo.ForeColor = System.Drawing.Color.Navy;
            this.lblBillNo.Location = new System.Drawing.Point(728, 13);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(50, 17);
            this.lblBillNo.TabIndex = 4;
            this.lblBillNo.Text = "Bill No";
            // 
            // dtpSalesDate
            // 
            this.dtpSalesDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSalesDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalesDate.Location = new System.Drawing.Point(605, 10);
            this.dtpSalesDate.Name = "dtpSalesDate";
            this.dtpSalesDate.Size = new System.Drawing.Size(105, 23);
            this.dtpSalesDate.TabIndex = 2;
            this.dtpSalesDate.TabStop = false;
            this.dtpSalesDate.Text = "16-06-2023";
            this.dtpSalesDate.Value = new System.DateTime(2023, 6, 16, 9, 32, 36, 325);
            this.dtpSalesDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpSalesDate_KeyDown);
            // 
            // lblSalesDate
            // 
            this.lblSalesDate.AutoSize = true;
            this.lblSalesDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesDate.ForeColor = System.Drawing.Color.Navy;
            this.lblSalesDate.Location = new System.Drawing.Point(526, 11);
            this.lblSalesDate.Name = "lblSalesDate";
            this.lblSalesDate.Size = new System.Drawing.Size(72, 17);
            this.lblSalesDate.TabIndex = 2;
            this.lblSalesDate.Text = "Sales Date";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(125, 10);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(384, 25);
            this.txtCustName.TabIndex = 1;
            this.txtCustName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustName_KeyDown);
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.ForeColor = System.Drawing.Color.Navy;
            this.lblCustName.Location = new System.Drawing.Point(11, 11);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(107, 17);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "Customer Name";
            // 
            // rpnlHeader
            // 
            this.rpnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.rpnlHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rpnlHeader.ForeColor = System.Drawing.Color.DarkMagenta;
            this.rpnlHeader.Location = new System.Drawing.Point(0, 0);
            this.rpnlHeader.Name = "rpnlHeader";
            this.rpnlHeader.Size = new System.Drawing.Size(1005, 42);
            this.rpnlHeader.TabIndex = 0;
            this.rpnlHeader.Text = "SALES ENTRY";
            this.rpnlHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1005, 478);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSales";
            this.Text = "Sales Entry";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMiddle.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesDetails.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesDetails)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.flpnlButtons.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpSalesDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpnlHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private Telerik.WinControls.UI.RadPanel rpnlHeader;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustName;
        private Telerik.WinControls.UI.RadDateTimePicker dtpSalesDate;
        private System.Windows.Forms.Label lblSalesDate;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.ComboBox ddlTax;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.FlowLayoutPanel flpnlButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlGrid;
        private Telerik.WinControls.UI.RadGridView grdSalesDetails;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
    }
}