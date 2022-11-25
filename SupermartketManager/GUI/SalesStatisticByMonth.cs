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
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                // Retrieve data from db
                DataTable statisticsByMonthDb = new DataTable();
                statisticsByMonthDb = billDAO.StatisticByMontḥ(ref errorMessage);
                dgvStatistic.DataSource = statisticsByMonthDb;

                int width = dgvStatistic.Width;
                // Styling categories datagridview
                dgvStatistic.Columns[0].Width = (int)(width * 0.3);
                dgvStatistic.Columns[0].HeaderText = "Tháng";
                dgvStatistic.Columns[1].Width = (int)(width * 0.3);
                dgvStatistic.Columns[1].HeaderText = "Năm";
                dgvStatistic.Columns[2].Width = (int)(width * 0.3);
                dgvStatistic.Columns[2].HeaderText = "Doanh thu";
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
            //string stt = dgvStatistic.Rows[curr].Cells[0].Value.ToString();
            string month = dgvStatistic.Rows[curr].Cells[0].Value.ToString();
            string year = dgvStatistic.Rows[curr].Cells[1].Value.ToString();
            string total = dgvStatistic.Rows[curr].Cells[2].Value.ToString();

            // Fill data to inputs
            txtMonth.Text = month;
            txtYear.Text = year;
            txtTotal.Text = total;
        }

        private void SalesStatisticByMonth_Load(object sender, EventArgs e)
        {

        }
    }
}
