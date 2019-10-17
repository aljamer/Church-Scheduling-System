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
    public partial class ucVenue : UserControl
    {
        public ucVenue()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();
        MySqlCommand cmd;
        MySqlDataReader dr;


        public void LoadData(string search = null)
        {
            try
            {
                dc.con.Open();
                string query = "SELECT * FROM tblvenue WHERE venue_name LIKE '" + search + "%'";
                cmd = new MySqlCommand(query, dc.con);
                dr = cmd.ExecuteReader();
                lvwVenue.Items.Clear();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    ListViewItem lv = new ListViewItem(dr.GetString(0));
                    lv.SubItems.Add(i.ToString());
                    lv.SubItems.Add(dr.GetString(1));
                    lv.SubItems.Add(dr.GetString(2));
                    lvwVenue.Items.Add(lv);
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





        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditVenue frm = new frmAddEditVenue();
            DatabaseConnection.adding = true;
            DatabaseConnection.updating = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void ucVenue_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwVenue.SelectedItems.Count == 1)
            {
                frmAddEditVenue frm = new frmAddEditVenue();
                DatabaseConnection.adding = false;
                DatabaseConnection.updating = true;
                frm.txtId.Text = lvwVenue.SelectedItems[0].SubItems[0].Text;            
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwVenue.SelectedItems.Count == 1)
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this item", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        dc.con.Open();
                        string query = "delete from tblvenue where venue_id = '" + lvwVenue.SelectedItems[0].SubItems[0].Text + "'";
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
                LoadData(txtSearch.Text);           
               // LoadDataLoc(txtSearch.Text);
            

        }
        public void LoadDataLoc(string search = null)
        {
            try
            {
                dc.con.Open();
                string query = "SELECT * FROM tblvenue WHERE location LIKE '" + search + "%'";
                cmd = new MySqlCommand(query, dc.con);
                dr = cmd.ExecuteReader();
                lvwVenue.Items.Clear();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    ListViewItem lv = new ListViewItem(dr.GetString(0));
                    lv.SubItems.Add(i.ToString());
                    lv.SubItems.Add(dr.GetString(1));
                    lv.SubItems.Add(dr.GetString(2));
                    lvwVenue.Items.Add(lv);
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

        private void lvwVenue_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
