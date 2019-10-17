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
    public partial class frmAddEditSchedule : Form
    {
        public frmAddEditSchedule()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();
        MySqlCommand cmd;
        MySqlDataReader dr;

        private void btnView_Click(object sender, EventArgs e)
        {
            frmAddEditApplicant frm = new frmAddEditApplicant();
            DatabaseConnection.adding = true;
            DatabaseConnection.updating = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string count = (Int32.Parse(lvwApp.Items.Count.ToString()) + 1).ToString();
                ListViewItem lv = new ListViewItem(DatabaseConnection.appID);
                lv.SubItems.Add(count);
                lv.SubItems.Add(DatabaseConnection.applName);
                lv.SubItems.Add(DatabaseConnection.appfName);
                lv.SubItems.Add(DatabaseConnection.appMI);
                lv.SubItems.Add(DatabaseConnection.appAdd);
                lvwApp.Items.Add(lv);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSelectApplicant frm = new frmSelectApplicant();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < lvwApp.Items.Count; i++)
                {
                    if (lvwApp.Items[i].SubItems[0].Text == DatabaseConnection.appID)
                    {
                        return;
                    }
                }
                string count = (Int32.Parse(lvwApp.Items.Count.ToString()) + 1).ToString();
                ListViewItem lv = new ListViewItem(DatabaseConnection.appID);
                lv.SubItems.Add(count);
                lv.SubItems.Add(DatabaseConnection.applName);
                lv.SubItems.Add(DatabaseConnection.appfName);
                lv.SubItems.Add(DatabaseConnection.appMI);
                lv.SubItems.Add(DatabaseConnection.appAdd);
                lvwApp.Items.Add(lv);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSelectEvent frm = new frmSelectEvent();
           
         
            if (frm.ShowDialog() == DialogResult.OK)
            {
                event_data();
            }
        }

        public void event_data()
        {
            txtEventID.Text = DatabaseConnection.eventID;
            txtEventName.Text = DatabaseConnection.eventName;
            txtEventDesc.Text = DatabaseConnection.eventDesc;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSelectDate frm = new frmSelectDate();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSelectPriest frm = new frmSelectPriest();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtEventName.Text != "")
            {
                if (txtEventName.Text =="Wedding" || txtEventName.Text == "Baptismal" || txtEventName.Text == "Funeral")
                {
                    frmNewParticipant frm = new frmNewParticipant();
                    frm.ShowDialog();
                }
                else
                {
                    frmAddEditParicipant frm = new frmAddEditParicipant();
                    frm.ShowDialog();
                }

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSelectParticipant frm = new frmSelectParticipant();
            frm.Show();
        }

        private void txtEventID_TextChanged(object sender, EventArgs e)
        {
            loadDataRec();
        }
        public void loadDataRec()
        {
            try
            {
                dc.con.Close();
                dc.con.Open();
                string query = "SELECT * FROM tblrequirement where event_id =  '" + txtEventID.Text + "'";
                cmd = new MySqlCommand(query, dc.con);
                dr = cmd.ExecuteReader();
                lvwReq.Items.Clear();
                int i = 0;
                while (dr.Read())
                {

                    i++;
                    ListViewItem lv = new ListViewItem(i.ToString());
                    lv.SubItems.Add(dr["rec_name"].ToString());
                    lv.SubItems.Add(dr["rec_type"].ToString());
                    lvwReq.Items.Add(lv);

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

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtEventID.Text = "";
            txtEventName.Text = "";
            txtEventDesc.Text = "";
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void frmAddEditSchedule_Load(object sender, EventArgs e)
        {
            group1.Visible = true;
            group2.Visible = false;
            group3.Visible = false;
            group4.Visible = false;
            group5.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
           
        }

        private void txtEventName_TextChanged(object sender, EventArgs e)
        {
            DatabaseConnection.curEvent = txtEventName.Text;
    }
       
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (group1.Visible == true)
            {

                group1.Visible = false;
                group2.Visible = true;
                group3.Visible = false;
                group4.Visible = false;
                group5.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                lblStep.Text = "Step 2: Applicant Details"; 

            }
            else if (group2.Visible == true)
            {
                group1.Visible = false;
                group2.Visible = false;
                group3.Visible = true;
                group4.Visible = false;
                group5.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                lblStep.Text = "Step 3: Requirements Details";
            }
            else if (group3.Visible == true)
            {
                group2.Visible = false;
                group1.Visible = false;
                group3.Visible = false;
                group4.Visible = true;
                group5.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                lblStep.Text = "Step 4: Partaker Details";
            }
            else if (group4.Visible == true)
            {
                group2.Visible = false;
                group1.Visible = false;
                group3.Visible = false;
                group4.Visible = false;
                group5.Visible = true;
                btnSave.Visible = true;
                btnCancel.Visible = true;
                lblStep.Text = "Step 5: Schedule Details";
            }
            else if (group5.Visible == true)
            {
                group1.Visible = true;
                group2.Visible = false;
                group3.Visible = false;
                group4.Visible = false;
                group5.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                lblStep.Text = "Step 1: Event Details";
            }

  

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (group1.Visible == true)
            {
                group1.Visible = false;
                group2.Visible = false;
                group3.Visible = false;
                group4.Visible = false;
                group5.Visible = true;
                btnSave.Visible = true;
                btnCancel.Visible = true;
                lblStep.Text = "Step 5: Schedule Details";

            }
            else if (group2.Visible == true)
            {

                group1.Visible = true;
                group2.Visible = false;
                group3.Visible = false;
                group4.Visible = false;
                group5.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                lblStep.Text = "Step 1: Event Details";

            }
            else if (group3.Visible == true)
            {
                group1.Visible = false;
                group2.Visible = true;
                group3.Visible = false;
                group4.Visible = false;
                group5.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                lblStep.Text = "Step 2: Applicant Details";


            }
            else if (group4.Visible == true)
            {
                group1.Visible = false;
                group2.Visible = false;
                group3.Visible = true;
                group4.Visible = false;
                group5.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                lblStep.Text = "Step 3: Requirements Details";
            }
            else if (group5.Visible == true)
            {
                group1.Visible = false;
                group2.Visible = false;
                group3.Visible = false;
                group4.Visible = true;
                group5.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                lblStep.Text = "Step 4: Partaker Details";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lvwApp.SelectedItems.Count > 0)
            {
                lvwApp.SelectedItems[0].Remove();
                string count = (Int32.Parse(lvwApp.Items.Count.ToString()) + 1).ToString();
                for (int i = 1; i < Int32.Parse(count); i++)
                {
                    lvwApp.Items[i - 1].SubItems[1].Text = i.ToString();
                }
            }
        }

        private void group3_Enter(object sender, EventArgs e)
        {

        }

        public void LoadText()
        {
            dc.con.Close();
            dc.con.Open();
            string query = "Select * from tblevent where event_name = '" + txtEventName.Text + "'";
            cmd = new MySqlCommand(query, dc.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtEventID.Text = dr["event_id"].ToString();
            }

            dr.Close();
            dc.con.Close();
            cmd.Dispose();
        }
        public void LoadText1()
        {
            dc.con.Close();
            dc.con.Open();
            string query = "Select * from tblevent where event_name = '" + txtEventName.Text + "'";
            cmd = new MySqlCommand(query, dc.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtEventDesc.Text = dr["event_desc"].ToString();
            }

            dr.Close();
            dc.con.Close();
            cmd.Dispose();
        }

        private void txtEventName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DatabaseConnection.curEvent = txtEventName.Text;
           
            LoadText();
            LoadText1();
            checkBox1.Visible = true;
        }

        private void txtEventID_TextChanged_1(object sender, EventArgs e)
        {
            loadDataRec();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                datePicker.Visible = false;
                panelTime.Visible = false;
            }
            else
            {
                datePicker.Visible = true;
                panelTime.Visible = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtEventID.Text = "";
            txtEventName.Text = "";
            txtEventDesc.Text = "";
        }

        private void txtEventName_TextChanged_1(object sender, EventArgs e)
        {
            DatabaseConnection.curEvent = txtEventName.Text;

            LoadText();
            LoadText1();
            checkBox1.Visible = true;
        }

        private void btnEventBrowse_Click(object sender, EventArgs e)
        {
            frmSelectEvent frm = new frmSelectEvent();


            if (frm.ShowDialog() == DialogResult.OK)
            {
                event_data();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
