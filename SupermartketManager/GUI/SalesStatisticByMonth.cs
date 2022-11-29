using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupermartketManager.DAO;

namespace SupermartketManager.GUI
{
    public partial class SalesStatisticByMonth : UserControl
    {
        BillDAO billDAO;
        String errorMessage;

        public SalesStatisticByMonth()
        {
            InitializeComponent();
            billDAO = new BillDAO();
            errorMessage = "";
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            //txtDate.ResetText();
            //txtMonth.ResetText();
            //txtYear.ResetText();

            int date = -1;
            int month = -1;
            int year = -1;
            if ((Int32.TryParse(txtDate.Text, out date) | Int32.TryParse(txtMonth.Text, out month) | Int32.TryParse(txtYear.Text, out year)) == false)
            {
                MessageBox.Show("Nhập khống đúng tháng hoặc năm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (date>0 && date <=31 && month >= 1 && month <= 12 && year >= 0)
            {
                LoadData(date,month, year);
            }
            else
            {
                MessageBox.Show("Nhập khống đúng tháng hoặc năm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        public void LoadData(int date, int month, int year)
        {
            try
            {
                // Retrieve data from db
                DataTable statisticsByMonthDb = new DataTable();
                statisticsByMonthDb = billDAO.StatisticByDMY(date,month,year,ref errorMessage);
                dgvStatistic.DataSource = statisticsByMonthDb;

                int width = dgvStatistic.Width;
                // Styling categories datagridview
                dgvStatistic.Columns[0].Width = (int)(width * 0.2);
                dgvStatistic.Columns[0].HeaderText = "Ngày";
                dgvStatistic.Columns[1].Width = (int)(width * 0.2);
                dgvStatistic.Columns[1].HeaderText = "Tháng";
                dgvStatistic.Columns[2].Width = (int)(width * 0.2);
                dgvStatistic.Columns[2].HeaderText = "Năm";
                dgvStatistic.Columns[3].Width = (int)(width * 0.2);
                dgvStatistic.Columns[3].HeaderText = "Doanh thu";
                dgvStatistic.Columns[4].Width = (int)(width * 0.2);
                dgvStatistic.Columns[4].HeaderText = "Tổng số đơn";
            }
            catch (Exception e)
            {
                MessageBox.Show(!string.IsNullOrEmpty(errorMessage) ? errorMessage : e.Message, "Thông báo!");
            }
        }

        private void dgvStatistic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return; // Prevent click on header

            // Get selected row
            int curr = dgvStatistic.CurrentCell.RowIndex;

            // Get data from select 
            string date = dgvStatistic.Rows[curr].Cells[0].Value.ToString();
            string month = dgvStatistic.Rows[curr].Cells[0].Value.ToString();
            string year = dgvStatistic.Rows[curr].Cells[1].Value.ToString();

            // Fill data to inputs
            txtMonth.Text = date;
            txtMonth.Text = month;
            txtYear.Text = year;
        }

        private void SalesStatisticByMonth_Load(object sender, EventArgs e)
        {

        }

    }
}
