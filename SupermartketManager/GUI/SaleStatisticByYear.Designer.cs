
namespace SupermartketManager.GUI
{
    partial class SaleStatisticByYear
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.salesStatisticByMonth1 = new SupermartketManager.GUI.SalesStatisticByMonth();
            this.salesStatisticByMonth2 = new SupermartketManager.GUI.SalesStatisticByMonth();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(32, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 64);
            this.panel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTotal);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(148, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(155, 63);
            this.panel4.TabIndex = 12;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(8, 34);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 29);
            this.txtTotal.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doanh thu:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtYear);
            this.panel3.Location = new System.Drawing.Point(18, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 64);
            this.panel3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Năm:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(10, 34);
            this.txtYear.Multiline = true;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(77, 30);
            this.txtYear.TabIndex = 8;
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Location = new System.Drawing.Point(50, 143);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.RowHeadersWidth = 51;
            this.dgvStatistic.RowTemplate.Height = 24;
            this.dgvStatistic.Size = new System.Drawing.Size(1004, 352);
            this.dgvStatistic.TabIndex = 6;
            this.dgvStatistic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStatistic_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "BẢNG THỐNG KÊ DOANH THU SIÊU THỊ THEO NĂM";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(58, 106);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 24);
            this.lb1.TabIndex = 4;
            // 
            // salesStatisticByMonth1
            // 
            this.salesStatisticByMonth1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesStatisticByMonth1.Location = new System.Drawing.Point(0, 0);
            this.salesStatisticByMonth1.Name = "salesStatisticByMonth1";
            this.salesStatisticByMonth1.Size = new System.Drawing.Size(1120, 558);
            this.salesStatisticByMonth1.TabIndex = 8;
            // 
            // salesStatisticByMonth2
            // 
            this.salesStatisticByMonth2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesStatisticByMonth2.Location = new System.Drawing.Point(0, 0);
            this.salesStatisticByMonth2.Name = "salesStatisticByMonth2";
            this.salesStatisticByMonth2.Size = new System.Drawing.Size(1120, 558);
            this.salesStatisticByMonth2.TabIndex = 9;
            // 
            // SaleStatisticByYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.salesStatisticByMonth2);
            this.Controls.Add(this.salesStatisticByMonth1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvStatistic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Name = "SaleStatisticByYear";
            this.Size = new System.Drawing.Size(1120, 558);
            this.Load += new System.EventHandler(this.SaleStatisticByYear_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private SalesStatisticByMonth salesStatisticByMonth1;
        private SalesStatisticByMonth salesStatisticByMonth2;
    }
}
