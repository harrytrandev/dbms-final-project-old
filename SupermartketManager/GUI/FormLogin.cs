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
        private bool isAuthenticated = true;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isAuthenticated)
            {
                FormMain formMain = new FormMain();
                formMain.ShowDialog();
            }
        }
    }
}
