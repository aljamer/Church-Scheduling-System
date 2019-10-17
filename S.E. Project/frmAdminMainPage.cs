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
    public partial class frmAdminMainPage : Form
    {
        public frmAdminMainPage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusDate.Text = DateTime.Now.ToLongDateString();
            statusTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmAdminMainPage_Load(object sender, EventArgs e)
        {
            lblName.Text = DatabaseConnection.lblCurName;
           // lblRole.Text = DatabaseConnection.lblCurRole;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                frmLogin frmLog = new frmLogin();
                this.Hide();
                frmLog.Show();
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            
        }

        private void lblAboutUs_Click(object sender, EventArgs e)
        {
            frmAboutUs aboutus = new frmAboutUs();
            aboutus.ShowDialog();
        }

        private void txtSearchArch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
