using SupermartketManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermartketManager.GUI
{
    public partial class ControlTopCompany : UserControl
    {
        private string errorMessage;
        private CompanyDAO companyDAO;
        public ControlTopCompany()
        {
            InitializeComponent();
            companyDAO = new CompanyDAO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32.TryParse(txtMonth.Text, out int month);
            Int32.TryParse(txtYear.Text, out int year);

            try
            {
                DataTable dt = companyDAO.TopCompany(month, year, ref errorMessage);
                dgvCompanies.DataSource = dt;

                // Styling categories datagridview
                dgvCompanies.RowHeadersVisible = false;
                int width = dgvCompanies.Width;
                dgvCompanies.Columns[0].Visible = false; // company_id
                dgvCompanies.Columns[1].Width = dgvCompanies.Width / 10 * 4; // name
                dgvCompanies.Columns[1].HeaderText = "Tên Công Ty";
                dgvCompanies.Columns[2].Width = dgvCompanies.Width / 5; // address
                dgvCompanies.Columns[2].HeaderText = "Địa chỉ";
                dgvCompanies.Columns[3].Width = dgvCompanies.Width / 5; // phone
                dgvCompanies.Columns[3].HeaderText = "Số điện thoại";
                dgvCompanies.Columns[4].Width = dgvCompanies.Width / 5; // TotalImport
                dgvCompanies.Columns[4].HeaderText = "Tổng số lượng hàng cung cấp";
            }
            catch
            {
                MessageBox.Show(errorMessage);
            }

        }
    }
}
