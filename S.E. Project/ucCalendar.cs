using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.E.Project
{
    public partial class ucCalendar : UserControl
    {
        public ucCalendar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void axCalendar1_AfterUpdate(object sender, EventArgs e)
        {
   
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            //axCalendar1.Value = System.DateTime.Now;
           

        }

        private void axCalendar1_DblClick(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.panel1.Visible = false;
          //  frm.lblDate.Text = axCalendar1.Value.ToString();
            frm.Show();
        }

        private void axCalendar1_AfterUpdate_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.panel1.Visible = false;
          //  frm.lblDate.Text = axCalendar1.Value.ToString();
            frm.Show();
        }

        private void axCalendar1_DblClick_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.panel1.Visible = false;
        //    frm.lblDate.Text = axCalendar1.Value.ToString();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditSchedule frm = new frmAddEditSchedule();
        //    DatabaseConnection.calendarDate = axCalendar1.Value.ToString();
            frm.Show();
        }


    }
}
