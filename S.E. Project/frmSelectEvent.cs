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

namespace S.E.Project
{
    public partial class frmSelectEvent : Form
    {
        public frmSelectEvent()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();
        MySqlCommand cmd;
        MySqlDataReader dr;

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cmbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LoadData(string search = null)
        {
            try
            {
                dc.con.Open();
                string query = "SELECT * FROM tblevent WHERE event_name LIKE '" + search + "%'";
                cmd = new MySqlCommand(query, dc.con);
                dr = cmd.ExecuteReader();
                lvwEvent.Items.Clear();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    ListViewItem lv = new ListViewItem(dr.GetString(0));
                    lv.SubItems.Add(i.ToString());
                    lv.SubItems.Add(dr.GetString(1));
                    lv.SubItems.Add(dr.GetString(2));
                    lvwEvent.Items.Add(lv);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cmd.Dispose();
                dc.con.Close();
                dr.Dispose();
            }
        }
        private void frmSelectEvent_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lvwEvent_DoubleClick(object sender, EventArgs e)
        {
            frmAddEditSchedule frm = new frmAddEditSchedule();
            if (lvwEvent.SelectedItems.Count == 1)
            {
                
                DatabaseConnection.eventID = lvwEvent.SelectedItems[0].SubItems[0].Text;
                DatabaseConnection.eventName = lvwEvent.SelectedItems[0].SubItems[2].Text;
                DatabaseConnection.eventDesc = lvwEvent.SelectedItems[0].SubItems[3].Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
               

            }



        }

        private void lvwEvent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
