namespace Centennial_Catering_System
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.posToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sctnerPOS = new System.Windows.Forms.SplitContainer();
            this.tabctrlPOS = new System.Windows.Forms.TabControl();
            this.tabPgFood = new System.Windows.Forms.TabPage();
            this.tlpFood = new System.Windows.Forms.TableLayoutPanel();
            this.tabPBeverages = new System.Windows.Forms.TabPage();
            this.tlpBeverage = new System.Windows.Forms.TableLayoutPanel();
            this.tabPDessert = new System.Windows.Forms.TabPage();
            this.tlpDessert = new System.Windows.Forms.TableLayoutPanel();
            this.tabPSides = new System.Windows.Forms.TabPage();
            this.tlpSide = new System.Windows.Forms.TableLayoutPanel();
            this.lbCusIDResult = new System.Windows.Forms.Label();
            this.btnCusIDSearch = new System.Windows.Forms.Button();
            this.tbxCusID = new System.Windows.Forms.TextBox();
            this.lbCusID = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.lbTax = new System.Windows.Forms.Label();
            this.lbSubtotalText = new System.Windows.Forms.Label();
            this.lbTaxText = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotalText = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.lbBillNO = new System.Windows.Forms.Label();
            this.lbBill = new System.Windows.Forms.Label();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.colItemImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateringDBDataSet = new Centennial_Catering_System.CateringDBDataSet();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sctnerPOS)).BeginInit();
            this.sctnerPOS.Panel1.SuspendLayout();
            this.sctnerPOS.Panel2.SuspendLayout();
            this.sctnerPOS.SuspendLayout();
            this.tabctrlPOS.SuspendLayout();
            this.tabPgFood.SuspendLayout();
            this.tabPBeverages.SuspendLayout();
            this.tabPDessert.SuspendLayout();
            this.tabPSides.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cateringDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.customerInfoToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 1176);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // posToolStripMenuItem
            // 
            this.posToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.posToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("posToolStripMenuItem.Image")));
            this.posToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.posToolStripMenuItem.Name = "posToolStripMenuItem";
            this.posToolStripMenuItem.Size = new System.Drawing.Size(233, 140);
            this.posToolStripMenuItem.Text = "POS";
            this.posToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.posToolStripMenuItem.Click += new System.EventHandler(this.pOSToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.managementToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("managementToolStripMenuItem.Image")));
            this.managementToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(233, 140);
            this.managementToolStripMenuItem.Text = "MANAGEMENT";
            this.managementToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.managementToolStripMenuItem.Click += new System.EventHandler(this.mANAGEMENTToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.statisticsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("statisticsToolStripMenuItem.Image")));
            this.statisticsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(233, 140);
            this.statisticsToolStripMenuItem.Text = "STATISTICS";
            this.statisticsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // customerInfoToolStripMenuItem
            // 
            this.customerInfoToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.customerInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("customerInfoToolStripMenuItem.Image")));
            this.customerInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.customerInfoToolStripMenuItem.Name = "customerInfoToolStripMenuItem";
            this.customerInfoToolStripMenuItem.Size = new System.Drawing.Size(233, 140);
            this.customerInfoToolStripMenuItem.Text = "CUSTOMER INFO";
            this.customerInfoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.customerInfoToolStripMenuItem.Click += new System.EventHandler(this.customerInfoToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(233, 140);
            this.logoutToolStripMenuItem.Text = "LOGOUT";
            this.logoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // sctnerPOS
            // 
            this.sctnerPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sctnerPOS.Location = new System.Drawing.Point(246, 0);
            this.sctnerPOS.Margin = new System.Windows.Forms.Padding(4);
            this.sctnerPOS.Name = "sctnerPOS";
            // 
            // sctnerPOS.Panel1
            // 
            this.sctnerPOS.Panel1.Controls.Add(this.tabctrlPOS);
            // 
            // sctnerPOS.Panel2
            // 
            this.sctnerPOS.Panel2.Controls.Add(this.lbCusIDResult);
            this.sctnerPOS.Panel2.Controls.Add(this.btnCusIDSearch);
            this.sctnerPOS.Panel2.Controls.Add(this.tbxCusID);
            this.sctnerPOS.Panel2.Controls.Add(this.lbCusID);
            this.sctnerPOS.Panel2.Controls.Add(this.lbSubtotal);
            this.sctnerPOS.Panel2.Controls.Add(this.lbTax);
            this.sctnerPOS.Panel2.Controls.Add(this.lbSubtotalText);
            this.sctnerPOS.Panel2.Controls.Add(this.lbTaxText);
            this.sctnerPOS.Panel2.Controls.Add(this.lbTotal);
            this.sctnerPOS.Panel2.Controls.Add(this.lbTotalText);
            this.sctnerPOS.Panel2.Controls.Add(this.btnCheckout);
            this.sctnerPOS.Panel2.Controls.Add(this.btnClearAll);
            this.sctnerPOS.Panel2.Controls.Add(this.btnDecrease);
            this.sctnerPOS.Panel2.Controls.Add(this.lbBillNO);
            this.sctnerPOS.Panel2.Controls.Add(this.lbBill);
            this.sctnerPOS.Panel2.Controls.Add(this.dgvBill);
            this.sctnerPOS.Size = new System.Drawing.Size(1730, 1176);
            this.sctnerPOS.SplitterDistance = 900;
            this.sctnerPOS.TabIndex = 1;
            // 
            // tabctrlPOS
            // 
            this.tabctrlPOS.Controls.Add(this.tabPgFood);
            this.tabctrlPOS.Controls.Add(this.tabPBeverages);
            this.tabctrlPOS.Controls.Add(this.tabPDessert);
            this.tabctrlPOS.Controls.Add(this.tabPSides);
            this.tabctrlPOS.Font = new System.Drawing.Font("Roboto Condensed", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabctrlPOS.Location = new System.Drawing.Point(4, 4);
            this.tabctrlPOS.Margin = new System.Windows.Forms.Padding(4);
            this.tabctrlPOS.Name = "tabctrlPOS";
            this.tabctrlPOS.SelectedIndex = 0;
            this.tabctrlPOS.Size = new System.Drawing.Size(840, 1080);
            this.tabctrlPOS.TabIndex = 0;
            // 
            // tabPgFood
            // 
            this.tabPgFood.Controls.Add(this.tlpFood);
            this.tabPgFood.Location = new System.Drawing.Point(4, 53);
            this.tabPgFood.Margin = new System.Windows.Forms.Padding(4);
            this.tabPgFood.Name = "tabPgFood";
            this.tabPgFood.Padding = new System.Windows.Forms.Padding(4);
            this.tabPgFood.Size = new System.Drawing.Size(832, 1023);
            this.tabPgFood.TabIndex = 0;
            this.tabPgFood.Text = "Food";
            this.tabPgFood.UseVisualStyleBackColor = true;
            // 
            // tlpFood
            // 
            this.tlpFood.AutoScroll = true;
            this.tlpFood.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.tlpFood.AutoSize = true;
            this.tlpFood.ColumnCount = 5;
            this.tlpFood.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpFood.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpFood.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpFood.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpFood.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpFood.Location = new System.Drawing.Point(4, 13);
            this.tlpFood.Margin = new System.Windows.Forms.Padding(4);
            this.tlpFood.Name = "tlpFood";
            this.tlpFood.RowCount = 5;
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpFood.Size = new System.Drawing.Size(825, 1000);
            this.tlpFood.TabIndex = 2;
            // 
            // tabPBeverages
            // 
            this.tabPBeverages.Controls.Add(this.tlpBeverage);
            this.tabPBeverages.Location = new System.Drawing.Point(4, 53);
            this.tabPBeverages.Margin = new System.Windows.Forms.Padding(4);
            this.tabPBeverages.Name = "tabPBeverages";
            this.tabPBeverages.Padding = new System.Windows.Forms.Padding(4);
            this.tabPBeverages.Size = new System.Drawing.Size(832, 1023);
            this.tabPBeverages.TabIndex = 1;
            this.tabPBeverages.Text = "Beverage";
            this.tabPBeverages.UseVisualStyleBackColor = true;
            // 
            // tlpBeverage
            // 
            this.tlpBeverage.AutoScroll = true;
            this.tlpBeverage.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.tlpBeverage.AutoSize = true;
            this.tlpBeverage.ColumnCount = 5;
            this.tlpBeverage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpBeverage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpBeverage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpBeverage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpBeverage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpBeverage.Location = new System.Drawing.Point(4, 13);
            this.tlpBeverage.Margin = new System.Windows.Forms.Padding(4);
            this.tlpBeverage.Name = "tlpBeverage";
            this.tlpBeverage.RowCount = 5;
            this.tlpBeverage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpBeverage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpBeverage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpBeverage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpBeverage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpBeverage.Size = new System.Drawing.Size(825, 1000);
            this.tlpBeverage.TabIndex = 3;
            // 
            // tabPDessert
            // 
            this.tabPDessert.Controls.Add(this.tlpDessert);
            this.tabPDessert.Location = new System.Drawing.Point(4, 53);
            this.tabPDessert.Margin = new System.Windows.Forms.Padding(4);
            this.tabPDessert.Name = "tabPDessert";
            this.tabPDessert.Size = new System.Drawing.Size(832, 1023);
            this.tabPDessert.TabIndex = 2;
            this.tabPDessert.Text = "Dessert";
            this.tabPDessert.UseVisualStyleBackColor = true;
            // 
            // tlpDessert
            // 
            this.tlpDessert.AutoScroll = true;
            this.tlpDessert.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.tlpDessert.AutoSize = true;
            this.tlpDessert.ColumnCount = 5;
            this.tlpDessert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpDessert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpDessert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpDessert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpDessert.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpDessert.Location = new System.Drawing.Point(4, 13);
            this.tlpDessert.Margin = new System.Windows.Forms.Padding(4);
            this.tlpDessert.Name = "tlpDessert";
            this.tlpDessert.RowCount = 5;
            this.tlpDessert.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpDessert.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpDessert.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpDessert.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpDessert.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpDessert.Size = new System.Drawing.Size(825, 1000);
            this.tlpDessert.TabIndex = 3;
            // 
            // tabPSides
            // 
            this.tabPSides.Controls.Add(this.tlpSide);
            this.tabPSides.Location = new System.Drawing.Point(4, 53);
            this.tabPSides.Margin = new System.Windows.Forms.Padding(4);
            this.tabPSides.Name = "tabPSides";
            this.tabPSides.Padding = new System.Windows.Forms.Padding(4);
            this.tabPSides.Size = new System.Drawing.Size(832, 1023);
            this.tabPSides.TabIndex = 3;
            this.tabPSides.Text = "Side";
            this.tabPSides.UseVisualStyleBackColor = true;
            // 
            // tlpSide
            // 
            this.tlpSide.AutoScroll = true;
            this.tlpSide.AutoScrollMinSize = new System.Drawing.Size(100, 100);
            this.tlpSide.AutoSize = true;
            this.tlpSide.ColumnCount = 5;
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlpSide.Location = new System.Drawing.Point(4, 13);
            this.tlpSide.Margin = new System.Windows.Forms.Padding(4);
            this.tlpSide.Name = "tlpSide";
            this.tlpSide.RowCount = 5;
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpSide.Size = new System.Drawing.Size(825, 1000);
            this.tlpSide.TabIndex = 3;
            // 
            // lbCusIDResult
            // 
            this.lbCusIDResult.AutoSize = true;
            this.lbCusIDResult.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCusIDResult.ForeColor = System.Drawing.Color.Crimson;
            this.lbCusIDResult.Location = new System.Drawing.Point(29, 901);
            this.lbCusIDResult.Name = "lbCusIDResult";
            this.lbCusIDResult.Size = new System.Drawing.Size(0, 36);
            this.lbCusIDResult.TabIndex = 19;
            // 
            // btnCusIDSearch
            // 
            this.btnCusIDSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCusIDSearch.Location = new System.Drawing.Point(119, 994);
            this.btnCusIDSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnCusIDSearch.Name = "btnCusIDSearch";
            this.btnCusIDSearch.Size = new System.Drawing.Size(192, 76);
            this.btnCusIDSearch.TabIndex = 18;
            this.btnCusIDSearch.Text = "Search";
            this.btnCusIDSearch.UseVisualStyleBackColor = true;
            this.btnCusIDSearch.Click += new System.EventHandler(this.btnCusIDSearch_Click);
            // 
            // tbxCusID
            // 
            this.tbxCusID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxCusID.Location = new System.Drawing.Point(225, 816);
            this.tbxCusID.Name = "tbxCusID";
            this.tbxCusID.Size = new System.Drawing.Size(86, 44);
            this.tbxCusID.TabIndex = 17;
            // 
            // lbCusID
            // 
            this.lbCusID.AutoSize = true;
            this.lbCusID.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCusID.Location = new System.Drawing.Point(22, 816);
            this.lbCusID.Name = "lbCusID";
            this.lbCusID.Size = new System.Drawing.Size(197, 36);
            this.lbCusID.TabIndex = 16;
            this.lbCusID.Text = "Customer ID: ";
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotal.Location = new System.Drawing.Point(630, 766);
            this.lbSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(0, 48);
            this.lbSubtotal.TabIndex = 15;
            // 
            // lbTax
            // 
            this.lbTax.AutoSize = true;
            this.lbTax.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTax.Location = new System.Drawing.Point(630, 839);
            this.lbTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTax.Name = "lbTax";
            this.lbTax.Size = new System.Drawing.Size(0, 48);
            this.lbTax.TabIndex = 14;
            // 
            // lbSubtotalText
            // 
            this.lbSubtotalText.AutoSize = true;
            this.lbSubtotalText.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtotalText.Location = new System.Drawing.Point(416, 766);
            this.lbSubtotalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubtotalText.Name = "lbSubtotalText";
            this.lbSubtotalText.Size = new System.Drawing.Size(190, 48);
            this.lbSubtotalText.TabIndex = 13;
            this.lbSubtotalText.Text = "Subtotal: ";
            // 
            // lbTaxText
            // 
            this.lbTaxText.AutoSize = true;
            this.lbTaxText.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaxText.Location = new System.Drawing.Point(506, 839);
            this.lbTaxText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTaxText.Name = "lbTaxText";
            this.lbTaxText.Size = new System.Drawing.Size(100, 48);
            this.lbTaxText.TabIndex = 12;
            this.lbTaxText.Text = "Tax: ";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(630, 910);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 48);
            this.lbTotal.TabIndex = 11;
            // 
            // lbTotalText
            // 
            this.lbTotalText.AutoSize = true;
            this.lbTotalText.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalText.Location = new System.Drawing.Point(477, 910);
            this.lbTotalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalText.Name = "lbTotalText";
            this.lbTotalText.Size = new System.Drawing.Size(129, 48);
            this.lbTotalText.TabIndex = 10;
            this.lbTotalText.Text = "Total: ";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCheckout.Location = new System.Drawing.Point(530, 994);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(192, 76);
            this.btnCheckout.TabIndex = 9;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft YaHei", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(623, 13);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(53, 48);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "X";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDecrease
            // 
            this.btnDecrease.Font = new System.Drawing.Font("Microsoft YaHei", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrease.Location = new System.Drawing.Point(530, 13);
            this.btnDecrease.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(53, 48);
            this.btnDecrease.TabIndex = 7;
            this.btnDecrease.Text = "-";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // lbBillNO
            // 
            this.lbBillNO.AutoSize = true;
            this.lbBillNO.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBillNO.Location = new System.Drawing.Point(226, 13);
            this.lbBillNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBillNO.Name = "lbBillNO";
            this.lbBillNO.Size = new System.Drawing.Size(0, 48);
            this.lbBillNO.TabIndex = 2;
            // 
            // lbBill
            // 
            this.lbBill.AutoSize = true;
            this.lbBill.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBill.Location = new System.Drawing.Point(4, 13);
            this.lbBill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBill.Name = "lbBill";
            this.lbBill.Size = new System.Drawing.Size(214, 48);
            this.lbBill.TabIndex = 1;
            this.lbBill.Text = "Order NO. ";
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemImg,
            this.colName,
            this.colQuantity,
            this.colPrice});
            this.dgvBill.Location = new System.Drawing.Point(4, 69);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowTemplate.Height = 31;
            this.dgvBill.Size = new System.Drawing.Size(755, 674);
            this.dgvBill.TabIndex = 0;
            // 
            // colItemImg
            // 
            this.colItemImg.HeaderText = "";
            this.colItemImg.Name = "colItemImg";
            this.colItemImg.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Product Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price Each";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // cateringDBDataSet
            // 
            this.cateringDBDataSet.DataSetName = "CateringDBDataSet";
            this.cateringDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1976, 1176);
            this.Controls.Add(this.sctnerPOS);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sctnerPOS.Panel1.ResumeLayout(false);
            this.sctnerPOS.Panel2.ResumeLayout(false);
            this.sctnerPOS.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sctnerPOS)).EndInit();
            this.sctnerPOS.ResumeLayout(false);
            this.tabctrlPOS.ResumeLayout(false);
            this.tabPgFood.ResumeLayout(false);
            this.tabPgFood.PerformLayout();
            this.tabPBeverages.ResumeLayout(false);
            this.tabPBeverages.PerformLayout();
            this.tabPDessert.ResumeLayout(false);
            this.tabPDessert.PerformLayout();
            this.tabPSides.ResumeLayout(false);
            this.tabPSides.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cateringDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem posToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer sctnerPOS;
        private System.Windows.Forms.TabControl tabctrlPOS;
        private System.Windows.Forms.TabPage tabPgFood;
        private System.Windows.Forms.TabPage tabPBeverages;
        private System.Windows.Forms.TabPage tabPDessert;
        private System.Windows.Forms.TabPage tabPSides;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label lbBill;
        private System.Windows.Forms.Label lbBillNO;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnCheckout;
        private CateringDBDataSet cateringDBDataSet;
        private System.Windows.Forms.TableLayoutPanel tlpFood;
        private System.Windows.Forms.TableLayoutPanel tlpBeverage;
        private System.Windows.Forms.TableLayoutPanel tlpDessert;
        private System.Windows.Forms.TableLayoutPanel tlpSide;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTotalText;
        private System.Windows.Forms.DataGridViewImageColumn colItemImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.Label lbSubtotalText;
        private System.Windows.Forms.Label lbTaxText;
        private System.Windows.Forms.Label lbTax;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.TextBox tbxCusID;
        private System.Windows.Forms.Label lbCusID;
        private System.Windows.Forms.Button btnCusIDSearch;
        private System.Windows.Forms.Label lbCusIDResult;
    }
}