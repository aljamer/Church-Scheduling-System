using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace S.E.Project
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();
        MySqlCommand cmd;
        MySqlDataReader dr;

        private void Form11_Load(object sender, EventArgs e)
        {
            group1.Visible = true;
            group2.Visible = false;
            group3.Visible = false;
            group4.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (group1.Visible == true)
            {
 
                group1.Visible = false;
                group2.Visible = true;
                group3.Visible = false;
                group4.Visible = false;
            }
           else if (group2.Visible == true)
            {
                group1.Visible = false;
                group2.Visible = false;
                group3.Visible = true;
                group4.Visible = false;
            }
            else if (group3.Visible == true)
            {
                group1.Visible = false;
                group2.Visible = false;
                group3.Visible = false;
                group4.Visible = true;
            }
            else if (group4.Visible == true)
            {
                group1.Visible = true;
                group2.Visible = false;
                group3.Visible = false;
                group4.Visible = false;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (group1.Visible == true)
            {
                group1.Visible = false;
                group2.Visible = false;
                group3.Visible = false;
                group4.Visible = true;

            }
            else if (group2.Visible == true)
            {

                group1.Visible = true;
                group2.Visible = false;
                group3.Visible = false;
                group4.Visible = false;

            }
            else if (group3.Visible == true)
            {
                group1.Visible = false;
                group2.Visible = true;
                group3.Visible = false;
                group4.Visible = false;


            }
            else if (group4.Visible == true)
            {
                group1.Visible = false;
                group2.Visible = false;
                group3.Visible = true;
                group4.Visible = false;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmAddEditApplicant frm = new frmAddEditApplicant();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
