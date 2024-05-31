using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDeDatos
{
    public partial class frmPrincipalEF : Form
    {
        public frmPrincipalEF()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers frmCustomers = new frmCustomers();
            frmCustomers.ShowDialog();
        }

        private void btnCreditRisks_Click(object sender, EventArgs e)
        {
            frmCreditRisks frmCreditRisks = new frmCreditRisks();
            frmCreditRisks.ShowDialog();
        }
    }
}
