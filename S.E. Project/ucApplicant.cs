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
    public partial class ucApplicant : UserControl
    {
        public ucApplicant()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();
        MySqlCommand cmd;
        MySqlDataReader dr;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditApplicant frm = new frmAddEditApplicant();
            DatabaseConnection.adding = true;
            DatabaseConnection.updating = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSelectEvent frm = new frmSelectEvent();
            frm.Show();
        }
        public void LoadData(string search = null)
        {
            try
            {
                dc.con.Open();
                string query = "SELECT * FROM tblapplicant WHERE lastname LIKE '" + search + "%'";
                cmd = new MySqlCommand(query, dc.con);
                dr = cmd.ExecuteReader();
                lvwApplicant.Items.Clear();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    ListViewItem lv = new ListViewItem(dr.GetString(0));
                    lv.SubItems.Add(i.ToString());
                    lv.SubItems.Add(dr.GetString(1));
                    lv.SubItems.Add(dr.GetString(2));
                    lv.SubItems.Add(dr.GetString(3));
                    lv.SubItems.Add(dr.GetString(4));
                    lv.SubItems.Add(dr.GetString(5));
                    lv.SubItems.Add(dr.GetString(6));
                    lvwApplicant.Items.Add(lv);
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
            if (lvwApplicant.SelectedItems.Count == 1)
            {
                frmAddEditApplicant frm = new frmAddEditApplicant();
                DatabaseConnection.adding = false;
                DatabaseConnection.updating = true;
                frm.txtId.Text = lvwApplicant.SelectedItems[0].SubItems[0].Text;
                frm.Show();
            }
        }

        private void ucApplicant_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwApplicant.SelectedItems.Count == 1)
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this item", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        dc.con.Open();
                        string query = "delete from tblapplicant where app_id = '" + lvwApplicant.SelectedItems[0].SubItems[0].Text + "'";
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
                LoadDataMN(txtSearch.Text);
           
        }
        public void LoadDataFN(string search = null)
        {
            try
            {
                dc.con.Open();
                string query = "SELECT * FROM tblapplicant WHERE firstname LIKE '" + search + "%'";
                cmd = new MySqlCommand(query, dc.con);
                dr = cmd.ExecuteReader();
                lvwApplicant.Items.Clear();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    ListViewItem lv = new ListViewItem(dr.GetString(0));
                    lv.SubItems.Add(i.ToString());
                    lv.SubItems.Add(dr.GetString(1));
                    lv.SubItems.Add(dr.GetString(2));
                    lv.SubItems.Add(dr.GetString(3));
                    lv.SubItems.Add(dr.GetString(4));
                    lv.SubItems.Add(dr.GetString(5));
                    lv.SubItems.Add(dr.GetString(6));
                    lvwApplicant.Items.Add(lv);
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
        public void LoadDataMN(string search = null)
        {
            try
            {
                dc.con.Open();
                string query = "SELECT * FROM tblapplicant WHERE mobile_num LIKE '" + search + "%'";
                cmd = new MySqlCommand(query, dc.con);
                dr = cmd.ExecuteReader();
                lvwApplicant.Items.Clear();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    ListViewItem lv = new ListViewItem(dr.GetString(0));
                    lv.SubItems.Add(i.ToString());
                    lv.SubItems.Add(dr.GetString(1));
                    lv.SubItems.Add(dr.GetString(2));
                    lv.SubItems.Add(dr.GetString(3));
                    lv.SubItems.Add(dr.GetString(4));
                    lv.SubItems.Add(dr.GetString(5));
                    lv.SubItems.Add(dr.GetString(6));
                    lvwApplicant.Items.Add(lv);
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
    }
}
