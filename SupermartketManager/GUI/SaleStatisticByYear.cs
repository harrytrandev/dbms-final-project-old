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
    public partial class SaleStatisticByYear : UserControl
    {
        BillDAO billDAO;
        String errorMessage;
        public SaleStatisticByYear()
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
                DataTable statisticsByYearDb = new DataTable();
                statisticsByYearDb = billDAO.StatisticByYear(ref errorMessage);
                dgvStatistic.DataSource = statisticsByYearDb;

                int width = dgvStatistic.Width;
                // Styling categories datagridview
                dgvStatistic.Columns[0].Width = (int)(width * 0.3);
                dgvStatistic.Columns[0].HeaderText = "Năm";
                dgvStatistic.Columns[1].Width = (int)(width * 0.5);
                dgvStatistic.Columns[1].HeaderText = "Doanh thu";
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
            string year = dgvStatistic.Rows[curr].Cells[0].Value.ToString();
            string total = dgvStatistic.Rows[curr].Cells[1].Value.ToString();

            // Fill data to inputs
            txtYear.Text = year;
            txtTotal.Text = total;
        }

        private void SaleStatisticByYear_Load(object sender, EventArgs e)
        {

        }
    }
}
