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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddEditParicipant frm = new frmAddEditParicipant();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSelectDate frm = new frmSelectDate();
            frm.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmAddEditApplicant frm = new frmAddEditApplicant();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSelectApplicant frm = new frmSelectApplicant();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSelectEvent frm = new frmSelectEvent();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSelectPriest frm = new frmSelectPriest();
            frm.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSelectParticipant frm = new frmSelectParticipant();
            frm.Show();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabPage1.Hide();
            tabPage2.Show();
            
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabPage2.Hide();
            tabPage1.Show();

        }
    }
}
