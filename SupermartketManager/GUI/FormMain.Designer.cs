﻿namespace SupermartketManager.GUI
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
            this.lbAccountInfo = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mniPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImport = new System.Windows.Forms.ToolStripMenuItem();
            this.mniManager = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngTyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTopSale = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saleStatisticByYear1 = new SupermartketManager.GUI.SaleStatisticByYear();
            this.salesStatisticByMonth1 = new SupermartketManager.GUI.SalesStatisticByMonth();
            this.controlCompany1 = new SupermartketManager.GUI.ControlCompany();
            this.groupInfo1 = new SupermartketManager.GUI.GroupInfo();
            this.controlImport1 = new SupermartketManager.GUI.ControlImport();
            this.controlAccount1 = new SupermartketManager.GUI.ControlAccount();
            this.controlWarehouse1 = new SupermartketManager.GUI.ControlWarehouse();
            this.controlEmployee1 = new SupermartketManager.GUI.ControlEmployee();
            this.controlProduct1 = new SupermartketManager.GUI.ControlProduct();
            this.ucEmployee1 = new SupermartketManager.GUI.ControlEmployee();
            this.ucPosition1 = new SupermartketManager.GUI.ControlPosition();
            this.ucCategory1 = new SupermartketManager.GUI.ControlCategory();
            this.doanhThuTheoThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuTheoNămToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saleStatisticByYear1);
            this.panel2.Controls.Add(this.salesStatisticByMonth1);
            this.panel2.Controls.Add(this.controlCompany1);
            this.panel2.Controls.Add(this.groupInfo1);
            this.panel2.Controls.Add(this.lbAccountInfo);
            this.panel2.Controls.Add(this.controlImport1);
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
            this.panel2.Size = new System.Drawing.Size(1135, 661);
            this.panel2.TabIndex = 3;
            // 
            // lbAccountInfo
            // 
            this.lbAccountInfo.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountInfo.ForeColor = System.Drawing.Color.Blue;
            this.lbAccountInfo.Location = new System.Drawing.Point(700, 0);
            this.lbAccountInfo.Name = "lbAccountInfo";
            this.lbAccountInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbAccountInfo.Size = new System.Drawing.Size(435, 32);
            this.lbAccountInfo.TabIndex = 0;
            this.lbAccountInfo.Text = "Thông tin tài khoản";
            this.lbAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Nunito SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniPayment,
            this.mniImport,
            this.mniManager,
            this.thốngKêToolStripMenuItem,
            this.mniAccount});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1135, 32);
            this.menu.TabIndex = 7;
            this.menu.Text = "menuStrip1";
            // 
            // mniPayment
            // 
            this.mniPayment.Name = "mniPayment";
            this.mniPayment.Size = new System.Drawing.Size(102, 28);
            this.mniPayment.Text = "Bán hàng";
            this.mniPayment.Click += new System.EventHandler(this.mniPayment_Click);
            // 
            // mniImport
            // 
            this.mniImport.Name = "mniImport";
            this.mniImport.Size = new System.Drawing.Size(114, 28);
            this.mniImport.Text = "Nhập hàng";
            this.mniImport.Click += new System.EventHandler(this.mniImport_Click);
            // 
            // mniManager
            // 
            this.mniManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcHàngToolStripMenuItem,
            this.hàngHóaToolStripMenuItem,
            this.khoHàngToolStripMenuItem,
            this.côngTyToolStripMenuItem,
            this.chứcVụToolStripMenuItem,
            this.nhânViênToolStripMenuItem});
            this.mniManager.Name = "mniManager";
            this.mniManager.Size = new System.Drawing.Size(88, 28);
            this.mniManager.Text = "Quản lý";
            // 
            // danhMụcHàngToolStripMenuItem
            // 
            this.danhMụcHàngToolStripMenuItem.Name = "danhMụcHàngToolStripMenuItem";
            this.danhMụcHàngToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.danhMụcHàngToolStripMenuItem.Text = "Danh mục hàng";
            this.danhMụcHàngToolStripMenuItem.Click += new System.EventHandler(this.danhMụcHàngToolStripMenuItem_Click);
            // 
            // hàngHóaToolStripMenuItem
            // 
            this.hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            this.hàngHóaToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.hàngHóaToolStripMenuItem.Text = "Hàng hóa";
            this.hàngHóaToolStripMenuItem.Click += new System.EventHandler(this.hàngHóaToolStripMenuItem_Click);
            // 
            // khoHàngToolStripMenuItem
            // 
            this.khoHàngToolStripMenuItem.Name = "khoHàngToolStripMenuItem";
            this.khoHàngToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.khoHàngToolStripMenuItem.Text = "Kho hàng";
            this.khoHàngToolStripMenuItem.Click += new System.EventHandler(this.khoHàngToolStripMenuItem_Click);
            // 
            // côngTyToolStripMenuItem
            // 
            this.côngTyToolStripMenuItem.Name = "côngTyToolStripMenuItem";
            this.côngTyToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.côngTyToolStripMenuItem.Text = "Công Ty";
            this.côngTyToolStripMenuItem.Click += new System.EventHandler(this.côngTyToolStripMenuItem_Click);
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.chứcVụToolStripMenuItem.Text = "Chức vụ";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTopSale,
            this.doanhThuTheoThángToolStripMenuItem,
            this.doanhThuTheoNămToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(101, 28);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // mniTopSale
            // 
            this.mniTopSale.Name = "mniTopSale";
            this.mniTopSale.Size = new System.Drawing.Size(360, 28);
            this.mniTopSale.Text = "Sản phẩm bán được trong tháng";
            this.mniTopSale.Click += new System.EventHandler(this.mniTopSale_Click);
            // 
            // mniAccount
            // 
            this.mniAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíTàiKhoảnToolStripMenuItem,
            this.mniLogout});
            this.mniAccount.Name = "mniAccount";
            this.mniAccount.Size = new System.Drawing.Size(103, 28);
            this.mniAccount.Text = "Tài khoản";
            // 
            // quảnLíTàiKhoảnToolStripMenuItem
            // 
            this.quảnLíTàiKhoảnToolStripMenuItem.Name = "quảnLíTàiKhoảnToolStripMenuItem";
            this.quảnLíTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.quảnLíTàiKhoảnToolStripMenuItem.Text = "Quản lí tài khoản";
            // 
            // mniLogout
            // 
            this.mniLogout.BackColor = System.Drawing.Color.White;
            this.mniLogout.ForeColor = System.Drawing.Color.Red;
            this.mniLogout.Name = "mniLogout";
            this.mniLogout.Size = new System.Drawing.Size(233, 28);
            this.mniLogout.Text = "Đăng xuất";
            this.mniLogout.Click += new System.EventHandler(this.mniLogout_Click);
            // 
            // saleStatisticByYear1
            // 
            this.saleStatisticByYear1.Font = new System.Drawing.Font("Calibri", 12F);
            this.saleStatisticByYear1.Location = new System.Drawing.Point(0, 103);
            this.saleStatisticByYear1.Name = "saleStatisticByYear1";
            this.saleStatisticByYear1.Size = new System.Drawing.Size(1120, 558);
            this.saleStatisticByYear1.TabIndex = 12;
            // 
            // salesStatisticByMonth1
            // 
            this.salesStatisticByMonth1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesStatisticByMonth1.Location = new System.Drawing.Point(0, 88);
            this.salesStatisticByMonth1.Name = "salesStatisticByMonth1";
            this.salesStatisticByMonth1.Size = new System.Drawing.Size(1120, 558);
            this.salesStatisticByMonth1.TabIndex = 11;
            // 
            // controlCompany1
            // 
            this.controlCompany1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlCompany1.Location = new System.Drawing.Point(0, 88);
            this.controlCompany1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controlCompany1.Name = "controlCompany1";
            this.controlCompany1.Size = new System.Drawing.Size(1120, 558);
            this.controlCompany1.TabIndex = 10;
            // 
            // groupInfo1
            // 
            this.groupInfo1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInfo1.Location = new System.Drawing.Point(0, 88);
            this.groupInfo1.Name = "groupInfo1";
            this.groupInfo1.Size = new System.Drawing.Size(1120, 558);
            this.groupInfo1.TabIndex = 9;
            // 
            // controlImport1
            // 
            this.controlImport1.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlImport1.Location = new System.Drawing.Point(0, 88);
            this.controlImport1.Name = "controlImport1";
            this.controlImport1.Size = new System.Drawing.Size(1120, 558);
            this.controlImport1.TabIndex = 8;
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
            // doanhThuTheoThángToolStripMenuItem
            // 
            this.doanhThuTheoThángToolStripMenuItem.Name = "doanhThuTheoThángToolStripMenuItem";
            this.doanhThuTheoThángToolStripMenuItem.Size = new System.Drawing.Size(360, 28);
            this.doanhThuTheoThángToolStripMenuItem.Text = "Doanh thu theo tháng";
            this.doanhThuTheoThángToolStripMenuItem.Click += new System.EventHandler(this.doanhThuTheoThángToolStripMenuItem_Click);
            // 
            // doanhThuTheoNămToolStripMenuItem
            // 
            this.doanhThuTheoNămToolStripMenuItem.Name = "doanhThuTheoNămToolStripMenuItem";
            this.doanhThuTheoNămToolStripMenuItem.Size = new System.Drawing.Size(360, 28);
            this.doanhThuTheoNămToolStripMenuItem.Text = "Doanh thu theo năm";
            this.doanhThuTheoNămToolStripMenuItem.Click += new System.EventHandler(this.doanhThuTheoNămToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1158, 685);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Nunito SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý Siêu thị";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing_2);
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
        private System.Windows.Forms.ToolStripMenuItem mniManager;
        private System.Windows.Forms.ToolStripMenuItem mniImport;
        private System.Windows.Forms.ToolStripMenuItem mniAccount;
        private System.Windows.Forms.ToolStripMenuItem quảnLíTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniLogout;
        private System.Windows.Forms.ToolStripMenuItem mniPayment;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ControlImport controlImport1;
        private System.Windows.Forms.Label lbAccountInfo;
        private System.Windows.Forms.ToolStripMenuItem danhMụcHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngTyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniTopSale;
        private GroupInfo groupInfo1;
        private ControlCompany controlCompany1;
        private SaleStatisticByYear saleStatisticByYear1;
        private SalesStatisticByMonth salesStatisticByMonth1;
        private System.Windows.Forms.ToolStripMenuItem doanhThuTheoThángToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuTheoNămToolStripMenuItem;
    }
}