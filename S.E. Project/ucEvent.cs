using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace S.E.Project
{
    public partial class ucEvent : UserControl
    {
        public ucEvent()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();
        MySqlCommand cmd;
        MySqlDataReader dr;
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            DatabaseConnection.adding = true;
            DatabaseConnection.updating = false;
            frm.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
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
        public void LoadDataDesc(string search = null)
        {
            try
            {
                dc.con.Open();
                string query = "SELECT * FROM tblevent WHERE event_desc LIKE '" + search + "%'";
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwEvent.SelectedItems.Count > 0)
            {

                Form3 frm = new Form3();
                DatabaseConnection.adding = false;
                DatabaseConnection.updating = true;
                frm.txtId.Text = lvwEvent.SelectedItems[0].SubItems[0].Text;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
                FirstLoad();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwEvent.SelectedItems.Count == 1)
            {
                if(lvwEvent.SelectedItems[0].SubItems[2].Text == "Wedding" || lvwEvent.SelectedItems[0].SubItems[2].Text == "Baptismal" || lvwEvent.SelectedItems[0].SubItems[2].Text == "Funeral")
                {
                    MessageBox.Show("You can't delete the main event", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        if (MessageBox.Show("Are you sure you want to delete this item", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            dc.con.Open();
                            string query = "delete from tblevent where event_id = '" + lvwEvent.SelectedItems[0].SubItems[0].Text + "'";
                            cmd = new MySqlCommand(query, dc.con);
                            if (cmd.ExecuteNonQuery() > 0)
                            {

                            }
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
                        LoadData();
                    }
                }

              
            }
            FirstLoad();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadData();
            FirstLoad();
        }

        private void ucEvent_Load(object sender, EventArgs e)
        {
            LoadData();
            FirstLoad();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            DatabaseConnection.adding = true;
            DatabaseConnection.updating = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        public void FirstLoad()
        {
            btnEdit.Enabled = false;
            btnAddReq.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            txtSearch.Text = "";

        }



        private void btnAddReq_Click(object sender, EventArgs e)
        {
            if (lvwEvent.SelectedItems.Count == 1)
            {
                frmRequirement frm = new frmRequirement();
                frm.txtEventId.Text = lvwEvent.SelectedItems[0].SubItems[0].Text;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }

            }
            FirstLoad();
        }

        private void lvwEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
               
            if (lvwEvent.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
                btnAddReq.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
            }
            else
            {
                FirstLoad();
            }
        }


        private void lvwEvent_Enter(object sender, EventArgs e)
        {
            if (lvwEvent.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
                btnAddReq.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
            }
        }

        private void lvwEvent_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
  
        }

        private void lvwEvent_Leave(object sender, EventArgs e)
        {

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            FirstLoad();
        }
    }
}
