using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.E.Project
{
    public partial class frmStaffMain : Form
    {
        public frmStaffMain()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucHome1.BringToFront();
        }

        private void btnApplicant_Click(object sender, EventArgs e)
        {
            ucApplicant1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucSchedule1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ucCertificate1.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Log-Out", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                frmLogin frmLog = new frmLogin();
                this.Hide();
                frmLog.Show();
            }

        }

        private void frmStaffMain_Load(object sender, EventArgs e)
        {
            lblName.Text = DatabaseConnection.lblCurName;
            lblRole.Text = DatabaseConnection.lblCurRole;
        }
    }
}
