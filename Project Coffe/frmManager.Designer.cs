namespace CoffeeShopManager
{
    partial class frmManager
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
            components = new System.ComponentModel.Container();
            panel2 = new System.Windows.Forms.Panel();
            lstvBill = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            panel3 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            txtTotalPrice = new System.Windows.Forms.TextBox();
            nmDiscount = new System.Windows.Forms.NumericUpDown();
            btnDiscount = new System.Windows.Forms.Button();
            btnPay = new System.Windows.Forms.Button();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            itAdmin = new System.Windows.Forms.ToolStripMenuItem();
            itAccInfo = new System.Windows.Forms.ToolStripMenuItem();
            itPersonalInfo = new System.Windows.Forms.ToolStripMenuItem();
            itLogout = new System.Windows.Forms.ToolStripMenuItem();
            chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            thêmMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panel4 = new System.Windows.Forms.Panel();
            nbDrinkCount = new System.Windows.Forms.NumericUpDown();
            btnAdd = new System.Windows.Forms.Button();
            cbDrink = new System.Windows.Forms.ComboBox();
            cbCategory = new System.Windows.Forms.ComboBox();
            flbTable = new System.Windows.Forms.FlowLayoutPanel();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).BeginInit();
            menuStrip1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nbDrinkCount).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lstvBill);
            panel2.Location = new System.Drawing.Point(31, 215);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(574, 529);
            panel2.TabIndex = 1;
            // 
            // lstvBill
            // 
            lstvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lstvBill.GridLines = true;
            lstvBill.Location = new System.Drawing.Point(2, 4);
            lstvBill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lstvBill.Name = "lstvBill";
            lstvBill.Size = new System.Drawing.Size(571, 524);
            lstvBill.TabIndex = 0;
            lstvBill.UseCompatibleStateImageBehavior = false;
            lstvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên đồ uống";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành tiền";
            columnHeader4.Width = 100;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtTotalPrice);
            panel3.Controls.Add(nmDiscount);
            panel3.Controls.Add(btnDiscount);
            panel3.Controls.Add(btnPay);
            panel3.Location = new System.Drawing.Point(640, 651);
            panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(455, 93);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(201, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 28);
            label1.TabIndex = 7;
            label1.Text = "Tổng tiền";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtTotalPrice.ForeColor = System.Drawing.Color.Maroon;
            txtTotalPrice.Location = new System.Drawing.Point(191, 43);
            txtTotalPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new System.Drawing.Size(114, 34);
            txtTotalPrice.TabIndex = 6;
            txtTotalPrice.Text = "0";
            txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmDiscount
            // 
            nmDiscount.Location = new System.Drawing.Point(23, 59);
            nmDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            nmDiscount.Name = "nmDiscount";
            nmDiscount.Size = new System.Drawing.Size(131, 27);
            nmDiscount.TabIndex = 4;
            nmDiscount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // btnDiscount
            // 
            btnDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            btnDiscount.Location = new System.Drawing.Point(23, 8);
            btnDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new System.Drawing.Size(131, 40);
            btnDiscount.TabIndex = 5;
            btnDiscount.Text = "Khuyến mãi";
            btnDiscount.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            btnPay.Location = new System.Drawing.Point(329, 17);
            btnPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnPay.Name = "btnPay";
            btnPay.Size = new System.Drawing.Size(126, 56);
            btnPay.TabIndex = 4;
            btnPay.Text = "Thanh toán";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { itAdmin, itAccInfo, chứcNăngToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1118, 30);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // itAdmin
            // 
            itAdmin.Name = "itAdmin";
            itAdmin.Size = new System.Drawing.Size(67, 24);
            itAdmin.Text = "Admin";
            itAdmin.Click += itAdmin_Click;
            // 
            // itAccInfo
            // 
            itAccInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { itPersonalInfo, itLogout });
            itAccInfo.Name = "itAccInfo";
            itAccInfo.Size = new System.Drawing.Size(151, 24);
            itAccInfo.Text = "Thông tin tài khoản";
            // 
            // itPersonalInfo
            // 
            itPersonalInfo.Name = "itPersonalInfo";
            itPersonalInfo.Size = new System.Drawing.Size(224, 26);
            itPersonalInfo.Text = "Thông tin cá nhân";
            itPersonalInfo.Click += itPersonalInfo_Click;
            // 
            // itLogout
            // 
            itLogout.Name = "itLogout";
            itLogout.Size = new System.Drawing.Size(224, 26);
            itLogout.Text = "Đăng xuất";
            itLogout.Click += itLogout_Click;
            // 
            // chứcNăngToolStripMenuItem
            // 
            chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { thanhToánToolStripMenuItem, thêmMónToolStripMenuItem });
            chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thanhToánToolStripMenuItem
            // 
            thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            thanhToánToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F;
            thanhToánToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            thanhToánToolStripMenuItem.Text = "Thanh toán";
            thanhToánToolStripMenuItem.Click += thanhToánToolStripMenuItem_Click;
            // 
            // thêmMónToolStripMenuItem
            // 
            thêmMónToolStripMenuItem.Name = "thêmMónToolStripMenuItem";
            thêmMónToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D;
            thêmMónToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            thêmMónToolStripMenuItem.Text = "Thêm Món";
            thêmMónToolStripMenuItem.Click += thêmMónToolStripMenuItem_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(nbDrinkCount);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(cbDrink);
            panel4.Controls.Add(cbCategory);
            panel4.Location = new System.Drawing.Point(31, 47);
            panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(570, 103);
            panel4.TabIndex = 4;
            // 
            // nbDrinkCount
            // 
            nbDrinkCount.Location = new System.Drawing.Point(139, 33);
            nbDrinkCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            nbDrinkCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nbDrinkCount.Name = "nbDrinkCount";
            nbDrinkCount.Size = new System.Drawing.Size(101, 27);
            nbDrinkCount.TabIndex = 3;
            nbDrinkCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAdd.Location = new System.Drawing.Point(11, 20);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(114, 56);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbDrink
            // 
            cbDrink.FormattingEnabled = true;
            cbDrink.Location = new System.Drawing.Point(257, 56);
            cbDrink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbDrink.Name = "cbDrink";
            cbDrink.Size = new System.Drawing.Size(293, 28);
            cbDrink.TabIndex = 1;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new System.Drawing.Point(257, 4);
            cbCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new System.Drawing.Size(293, 28);
            cbCategory.TabIndex = 0;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // flbTable
            // 
            flbTable.Location = new System.Drawing.Point(640, 47);
            flbTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            flbTable.Name = "flbTable";
            flbTable.Size = new System.Drawing.Size(455, 596);
            flbTable.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmManager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1118, 776);
            Controls.Add(flbTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmManager";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Quản lý";
            Load += frmManager_Load_1;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmDiscount).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nbDrinkCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itAdmin;
        private System.Windows.Forms.ToolStripMenuItem itAccInfo;
        private System.Windows.Forms.ToolStripMenuItem itPersonalInfo;
        private System.Windows.Forms.ToolStripMenuItem itLogout;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nbDrinkCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbDrink;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.FlowLayoutPanel flbTable;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMónToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}