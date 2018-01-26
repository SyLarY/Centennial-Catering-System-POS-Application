namespace Centennial_Catering_System
{
    partial class Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.posToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxItemID = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxCategory = new System.Windows.Forms.ListBox();
            this.ofdImg = new System.Windows.Forms.OpenFileDialog();
            this.tbxImage = new System.Windows.Forms.TextBox();
            this.dgvManagement = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.tbxSearchCat = new System.Windows.Forms.TextBox();
            this.lbSearchCat = new System.Windows.Forms.Label();
            this.tbxSearchName = new System.Windows.Forms.TextBox();
            this.lbSearchName = new System.Windows.Forms.Label();
            this.tbxSearchID = new System.Windows.Forms.TextBox();
            this.lbSearchID = new System.Windows.Forms.Label();
            this.btnSearchClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagement)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(246, 1582);
            this.menuStrip1.TabIndex = 1;
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
            this.managementToolStripMenuItem.Click += new System.EventHandler(this.Management_Load);
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
            // tbxItemID
            // 
            this.tbxItemID.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxItemID.Location = new System.Drawing.Point(534, 102);
            this.tbxItemID.Name = "tbxItemID";
            this.tbxItemID.Size = new System.Drawing.Size(320, 56);
            this.tbxItemID.TabIndex = 3;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(348, 114);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(160, 48);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Item ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(934, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category ID:";
            // 
            // tbxItemName
            // 
            this.tbxItemName.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxItemName.Location = new System.Drawing.Point(534, 202);
            this.tbxItemName.Name = "tbxItemName";
            this.tbxItemName.Size = new System.Drawing.Size(320, 56);
            this.tbxItemName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item Name:";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrice.Location = new System.Drawing.Point(534, 295);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(320, 56);
            this.tbxPrice.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 48);
            this.label4.TabIndex = 10;
            this.label4.Text = "Item Image:";
            // 
            // lbxCategory
            // 
            this.lbxCategory.AllowDrop = true;
            this.lbxCategory.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCategory.FormattingEnabled = true;
            this.lbxCategory.ItemHeight = 50;
            this.lbxCategory.Items.AddRange(new object[] {
            "1-Food",
            "2-Beverage",
            "3-Dessert",
            "4-Side"});
            this.lbxCategory.Location = new System.Drawing.Point(1199, 102);
            this.lbxCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbxCategory.Name = "lbxCategory";
            this.lbxCategory.Size = new System.Drawing.Size(320, 254);
            this.lbxCategory.TabIndex = 11;
            // 
            // ofdImg
            // 
            this.ofdImg.FileName = "Item Image";
            // 
            // tbxImage
            // 
            this.tbxImage.Font = new System.Drawing.Font("Microsoft YaHei", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxImage.Location = new System.Drawing.Point(534, 397);
            this.tbxImage.Name = "tbxImage";
            this.tbxImage.Size = new System.Drawing.Size(641, 56);
            this.tbxImage.TabIndex = 12;
            // 
            // dgvManagement
            // 
            this.dgvManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagement.Location = new System.Drawing.Point(356, 710);
            this.dgvManagement.Name = "dgvManagement";
            this.dgvManagement.RowTemplate.Height = 31;
            this.dgvManagement.Size = new System.Drawing.Size(1229, 842);
            this.dgvManagement.TabIndex = 13;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInsert.Location = new System.Drawing.Point(1420, 408);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(165, 63);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "&Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Location = new System.Drawing.Point(1420, 517);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 63);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(1420, 623);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 63);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(1181, 405);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(55, 55);
            this.btnOpenFileDialog.TabIndex = 17;
            this.btnOpenFileDialog.Text = "...";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // tbxSearchCat
            // 
            this.tbxSearchCat.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSearchCat.Location = new System.Drawing.Point(356, 617);
            this.tbxSearchCat.Name = "tbxSearchCat";
            this.tbxSearchCat.Size = new System.Drawing.Size(235, 38);
            this.tbxSearchCat.TabIndex = 19;
            this.tbxSearchCat.TextChanged += new System.EventHandler(this.tbxSearchCat_TextChanged);
            // 
            // lbSearchCat
            // 
            this.lbSearchCat.AutoSize = true;
            this.lbSearchCat.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSearchCat.Location = new System.Drawing.Point(350, 567);
            this.lbSearchCat.Name = "lbSearchCat";
            this.lbSearchCat.Size = new System.Drawing.Size(243, 31);
            this.lbSearchCat.TabIndex = 18;
            this.lbSearchCat.Text = "Search by Category:";
            // 
            // tbxSearchName
            // 
            this.tbxSearchName.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSearchName.Location = new System.Drawing.Point(623, 617);
            this.tbxSearchName.Name = "tbxSearchName";
            this.tbxSearchName.Size = new System.Drawing.Size(235, 38);
            this.tbxSearchName.TabIndex = 21;
            this.tbxSearchName.TextChanged += new System.EventHandler(this.tbxSearchName_TextChanged);
            // 
            // lbSearchName
            // 
            this.lbSearchName.AutoSize = true;
            this.lbSearchName.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSearchName.Location = new System.Drawing.Point(617, 567);
            this.lbSearchName.Name = "lbSearchName";
            this.lbSearchName.Size = new System.Drawing.Size(208, 31);
            this.lbSearchName.TabIndex = 20;
            this.lbSearchName.Text = "Search by Name:";
            // 
            // tbxSearchID
            // 
            this.tbxSearchID.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxSearchID.Location = new System.Drawing.Point(891, 617);
            this.tbxSearchID.Name = "tbxSearchID";
            this.tbxSearchID.Size = new System.Drawing.Size(235, 38);
            this.tbxSearchID.TabIndex = 23;
            this.tbxSearchID.TextChanged += new System.EventHandler(this.tbxSearchID_TextChanged);
            // 
            // lbSearchID
            // 
            this.lbSearchID.AutoSize = true;
            this.lbSearchID.Font = new System.Drawing.Font("Microsoft YaHei", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSearchID.Location = new System.Drawing.Point(885, 567);
            this.lbSearchID.Name = "lbSearchID";
            this.lbSearchID.Size = new System.Drawing.Size(223, 31);
            this.lbSearchID.TabIndex = 22;
            this.lbSearchID.Text = "Search by Item ID:";
            // 
            // btnSearchClear
            // 
            this.btnSearchClear.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearchClear.Location = new System.Drawing.Point(1157, 592);
            this.btnSearchClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchClear.Name = "btnSearchClear";
            this.btnSearchClear.Size = new System.Drawing.Size(165, 63);
            this.btnSearchClear.TabIndex = 24;
            this.btnSearchClear.Text = "&Clear";
            this.btnSearchClear.UseVisualStyleBackColor = true;
            this.btnSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 1582);
            this.Controls.Add(this.btnSearchClear);
            this.Controls.Add(this.tbxSearchID);
            this.Controls.Add(this.lbSearchID);
            this.Controls.Add(this.tbxSearchName);
            this.Controls.Add(this.lbSearchName);
            this.Controls.Add(this.tbxSearchCat);
            this.Controls.Add(this.lbSearchCat);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dgvManagement);
            this.Controls.Add(this.tbxImage);
            this.Controls.Add(this.lbxCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxItemID);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Management_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagement)).EndInit();
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
        private System.Windows.Forms.TextBox tbxItemID;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxCategory;
        private System.Windows.Forms.OpenFileDialog ofdImg;
        private System.Windows.Forms.TextBox tbxImage;
        private System.Windows.Forms.DataGridView dgvManagement;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.TextBox tbxSearchCat;
        private System.Windows.Forms.Label lbSearchCat;
        private System.Windows.Forms.TextBox tbxSearchName;
        private System.Windows.Forms.Label lbSearchName;
        private System.Windows.Forms.TextBox tbxSearchID;
        private System.Windows.Forms.Label lbSearchID;
        private System.Windows.Forms.Button btnSearchClear;
    }
}