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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void mniProduct_Click(object sender, EventArgs e)
        {
            controlProduct1.BringToFront();
        }

        private void mniCategory_Click(object sender, EventArgs e)
        {
            ucCategory1.BringToFront();
        }

        private void mniWarehouse_Click(object sender, EventArgs e)
        {
            controlWarehouse1.BringToFront();
        }

        private void mniImport_Click(object sender, EventArgs e)
        {
            //controlImport1.BringToFront();
        }

        private void mniCompany_Click(object sender, EventArgs e)
        {
            //controlCompany.BringToFront();
        }

        private void mniPosition_Click(object sender, EventArgs e)
        {
            ucPosition1.BringToFront();
        }

        private void mniEmployee_Click(object sender, EventArgs e)
        {
            controlEmployee1.BringToFront();
        }

        private void mniCustomer_Click(object sender, EventArgs e)
        {
            // controlCustomer1.BringToFront();
        }

        private void mniPromotion_Click(object sender, EventArgs e)
        {
            // controlPromotion1.BringToFront();
        }

        private void mniPayment_Click(object sender, EventArgs e)
        {

        }
    }
}
