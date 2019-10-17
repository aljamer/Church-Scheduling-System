using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
namespace S.E.Project
{
    public partial class frmAdminMain : Form
    {
        public frmAdminMain()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();
        MySqlCommand cmd;
        MySqlDataReader dr;
       
        private void btnStaff_Click(object sender, EventArgs e)
        {
            ucStaff1.BringToFront();
            ucStaff1.FirstLoad();
            panel4.Show();
        }       

        private void btnVenue_Click(object sender, EventArgs e)
        {
            //ucVenue1.BringToFront();
            panel4.Show();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            ucEvent1.BringToFront();
            ucEvent1.FirstLoad();
        
  
            panel4.Show();
        }

        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            // lblName.Text = DatabaseConnection.lblCurName;
            // lblRole.Text = DatabaseConnection.lblCurRole;
            lblName.Text = DatabaseConnection.lblCurName;

            dc.con.Open();
            //string query = "Select * from tblstaff where firstname && lastname = '" + lblName.Text + "'";
            string query = "Select * from tblstaff";
            cmd = new MySqlCommand(query, dc.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
              //  byte[] img = (byte[])(dr["account_img"]);

              //  MemoryStream ms = new MemoryStream(img);
              //  pbAccountPic.Image = Image.FromStream(ms);
            }
            dc.con.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucCalendar1.BringToFront();
            panel4.Show();
        }

        private void btnApplicant_Click(object sender, EventArgs e)
        {
            //ucApplicant1.BringToFront();
            panel4.Show();
        }

        private void ucHome1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                frmLogin frmLog = new frmLogin();
                this.Hide();
                frmLog.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ucSchedule1.BringToFront();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ucCertificate1.BringToFront();
            panel4.Show();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            frmAboutUs aboutus = new frmAboutUs();
            aboutus.ShowDialog();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAboutUs aboutus = new frmAboutUs();
            aboutus.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            home1.BringToFront();
            panel4.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusDate.Text = DateTime.Now.ToLongDateString();
            statusTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void lblAboutUs_Click(object sender, EventArgs e)
        {
            frmAboutUs aboutus = new frmAboutUs();
            aboutus.ShowDialog();
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }

        private void STLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                frmLogin frmLog = new frmLogin();
                this.Hide();
                frmLog.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //ucCollection1.BringToFront();
        }
    }
}
