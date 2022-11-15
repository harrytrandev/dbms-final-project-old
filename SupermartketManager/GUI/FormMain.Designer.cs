namespace SupermartketManager.GUI
{
    partial class FormMain
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mniProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mniWarehouse = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.mniEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPromotion = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.controlAccount1 = new SupermartketManager.GUI.ControlAccount();
            this.controlWarehouse1 = new SupermartketManager.GUI.ControlWarehouse();
            this.controlEmployee1 = new SupermartketManager.GUI.ControlEmployee();
            this.controlProduct1 = new SupermartketManager.GUI.ControlProduct();
            this.ucEmployee1 = new SupermartketManager.GUI.ControlEmployee();
            this.ucPosition1 = new SupermartketManager.GUI.ControlPosition();
            this.ucCategory1 = new SupermartketManager.GUI.ControlCategory();
            this.quảnLíTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.controlAccount1);
            this.panel2.Controls.Add(this.controlWarehouse1);
            this.panel2.Controls.Add(this.controlEmployee1);
            this.panel2.Controls.Add(this.controlProduct1);
            this.panel2.Controls.Add(this.ucEmployee1);
            this.panel2.Controls.Add(this.ucPosition1);
            this.panel2.Controls.Add(this.ucCategory1);
            this.panel2.Controls.Add(this.menu);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 620);
            this.panel2.TabIndex = 3;
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Nunito SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniPayment,
            this.mniProduct,
            this.mniCategory,
            this.mniWarehouse,
            this.mniImport,
            this.mniCompany,
            this.mniPosition,
            this.mniEmployee,
            this.mniCustomer,
            this.mniPromotion,
            this.mniAccount,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1135, 32);
            this.menu.TabIndex = 7;
            this.menu.Text = "menuStrip1";
            // 
            // mniProduct
            // 
            this.mniProduct.Name = "mniProduct";
            this.mniProduct.Size = new System.Drawing.Size(104, 28);
            this.mniProduct.Text = "Hàng hóa";
            this.mniProduct.Click += new System.EventHandler(this.mniProduct_Click);
            // 
            // mniCategory
            // 
            this.mniCategory.Name = "mniCategory";
            this.mniCategory.Size = new System.Drawing.Size(107, 28);
            this.mniCategory.Text = "Danh mục";
            this.mniCategory.Click += new System.EventHandler(this.mniCategory_Click);
            // 
            // mniWarehouse
            // 
            this.mniWarehouse.Name = "mniWarehouse";
            this.mniWarehouse.Size = new System.Drawing.Size(56, 28);
            this.mniWarehouse.Text = "Kho";
            this.mniWarehouse.Click += new System.EventHandler(this.mniWarehouse_Click);
            // 
            // mniImport
            // 
            this.mniImport.Name = "mniImport";
            this.mniImport.Size = new System.Drawing.Size(114, 28);
            this.mniImport.Text = "Nhập hàng";
            this.mniImport.Click += new System.EventHandler(this.mniImport_Click);
            // 
            // mniCompany
            // 
            this.mniCompany.Name = "mniCompany";
            this.mniCompany.Size = new System.Drawing.Size(87, 28);
            this.mniCompany.Text = "Công ty";
            this.mniCompany.Click += new System.EventHandler(this.mniCompany_Click);
            // 
            // mniPosition
            // 
            this.mniPosition.Name = "mniPosition";
            this.mniPosition.Size = new System.Drawing.Size(88, 28);
            this.mniPosition.Text = "Chức vụ";
            this.mniPosition.Click += new System.EventHandler(this.mniPosition_Click);
            // 
            // mniEmployee
            // 
            this.mniEmployee.Name = "mniEmployee";
            this.mniEmployee.Size = new System.Drawing.Size(105, 28);
            this.mniEmployee.Text = "Nhân viên";
            this.mniEmployee.Click += new System.EventHandler(this.mniEmployee_Click);
            // 
            // mniCustomer
            // 
            this.mniCustomer.Name = "mniCustomer";
            this.mniCustomer.Size = new System.Drawing.Size(120, 28);
            this.mniCustomer.Text = "Khách hàng";
            this.mniCustomer.Click += new System.EventHandler(this.mniCustomer_Click);
            // 
            // mniPromotion
            // 
            this.mniPromotion.Name = "mniPromotion";
            this.mniPromotion.Size = new System.Drawing.Size(120, 28);
            this.mniPromotion.Text = "Khuyến mãi";
            this.mniPromotion.Click += new System.EventHandler(this.mniPromotion_Click);
            // 
            // mniAccount
            // 
            this.mniAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.mniAccount.Name = "mniAccount";
            this.mniAccount.Size = new System.Drawing.Size(103, 28);
            this.mniAccount.Text = "Tài khoản";
            // 
            // controlAccount1
            // 
            this.controlAccount1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlAccount1.Location = new System.Drawing.Point(0, 88);
            this.controlAccount1.Name = "controlAccount1";
            this.controlAccount1.Size = new System.Drawing.Size(1120, 558);
            this.controlAccount1.TabIndex = 6;
            // 
            // controlWarehouse1
            // 
            this.controlWarehouse1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlWarehouse1.Location = new System.Drawing.Point(0, 88);
            this.controlWarehouse1.Name = "controlWarehouse1";
            this.controlWarehouse1.Size = new System.Drawing.Size(1120, 558);
            this.controlWarehouse1.TabIndex = 5;
            // 
            // controlEmployee1
            // 
            this.controlEmployee1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlEmployee1.Location = new System.Drawing.Point(0, 88);
            this.controlEmployee1.Name = "controlEmployee1";
            this.controlEmployee1.Size = new System.Drawing.Size(1120, 558);
            this.controlEmployee1.TabIndex = 4;
            // 
            // controlProduct1
            // 
            this.controlProduct1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlProduct1.Location = new System.Drawing.Point(0, 88);
            this.controlProduct1.Name = "controlProduct1";
            this.controlProduct1.Size = new System.Drawing.Size(1120, 558);
            this.controlProduct1.TabIndex = 3;
            // 
            // ucEmployee1
            // 
            this.ucEmployee1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucEmployee1.Location = new System.Drawing.Point(0, 88);
            this.ucEmployee1.Name = "ucEmployee1";
            this.ucEmployee1.Size = new System.Drawing.Size(1120, 558);
            this.ucEmployee1.TabIndex = 2;
            // 
            // ucPosition1
            // 
            this.ucPosition1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucPosition1.Location = new System.Drawing.Point(0, 88);
            this.ucPosition1.Name = "ucPosition1";
            this.ucPosition1.Size = new System.Drawing.Size(1120, 558);
            this.ucPosition1.TabIndex = 1;
            // 
            // ucCategory1
            // 
            this.ucCategory1.Location = new System.Drawing.Point(0, 88);
            this.ucCategory1.Name = "ucCategory1";
            this.ucCategory1.Size = new System.Drawing.Size(1120, 558);
            this.ucCategory1.TabIndex = 0;
            // 
            // quảnLíTàiKhoảnToolStripMenuItem
            // 
            this.quảnLíTàiKhoảnToolStripMenuItem.Name = "quảnLíTàiKhoảnToolStripMenuItem";
            this.quảnLíTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.quảnLíTàiKhoảnToolStripMenuItem.Text = "Quản lí tài khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // mniPayment
            // 
            this.mniPayment.Name = "mniPayment";
            this.mniPayment.Size = new System.Drawing.Size(102, 28);
            this.mniPayment.Text = "Bán hàng";
            this.mniPayment.Click += new System.EventHandler(this.mniPayment_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 28);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 28);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(165, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1159, 688);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menu;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý Siêu thị";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private ControlCategory ucCategory1;
        private ControlPosition ucPosition1;
        private ControlEmployee ucEmployee1;
        private ControlEmployee controlEmployee1;
        private ControlProduct controlProduct1;
        private ControlWarehouse controlWarehouse1;
        private ControlAccount controlAccount1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mniProduct;
        private System.Windows.Forms.ToolStripMenuItem mniCategory;
        private System.Windows.Forms.ToolStripMenuItem mniWarehouse;
        private System.Windows.Forms.ToolStripMenuItem mniImport;
        private System.Windows.Forms.ToolStripMenuItem mniCompany;
        private System.Windows.Forms.ToolStripMenuItem mniPosition;
        private System.Windows.Forms.ToolStripMenuItem mniEmployee;
        private System.Windows.Forms.ToolStripMenuItem mniCustomer;
        private System.Windows.Forms.ToolStripMenuItem mniPromotion;
        private System.Windows.Forms.ToolStripMenuItem mniAccount;
        private System.Windows.Forms.ToolStripMenuItem quảnLíTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniPayment;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}