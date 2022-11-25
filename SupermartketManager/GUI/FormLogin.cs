using SupermartketManager.DAO;
using SupermartketManager.DTO;
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
    public partial class FormLogin : Form
    {
        private DataTable userTable;
        private AccountDAO accountDAO;
        private string errorMessage;
        public FormLogin()
        {
            InitializeComponent();
            userTable = new DataTable();
            accountDAO = new AccountDAO();
            errorMessage = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            try
            {
                userTable = accountDAO.GetAccount(username, ref errorMessage);
                if (userTable.Rows.Count > 0)
                {
                    DataRow row = userTable.Rows[0];
                    string password = row["password"].ToString();
                    string employee_id = row["employee_id"].ToString();
                    string employee_name = row["name"].ToString();
                    string position_name = row["position_name"].ToString();
                    string enteredPassword = txtPassword.Text;
                    if (enteredPassword.Equals(password))
                    {
                        FormMain formMain = new FormMain(employee_id, employee_name, position_name);
                        formMain.ShowDialog();
                        txtUsername.ResetText();
                        txtPassword.ResetText();
                        txtUsername.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu chưa chính xác, vui lòng kiểm tra lại!");
                        txtPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
