using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace S.E.Project
{
    public partial class ucStaff : UserControl
    {
        public ucStaff()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();
        MySqlCommand cmd;
        MySqlDataReader dr;


        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditStaff frm = new frmAddEditStaff();
            DatabaseConnection.adding = true;
            DatabaseConnection.updating = false;
           
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                loadData();
            }
            
        }

        public void loadData(string search = null)
        {
            try
            {
                dc.con.Open();
                string query = "SELECT * FROM tblstaff WHERE lastname LIKE '" + search + "%'";
                cmd = new MySqlCommand(query, dc.con);
                dr = cmd.ExecuteReader();
                lvwStaff.Items.Clear();
                int i = 0;
                while (dr.Read())
                {
                    if (dr["role"].ToString() != "Admin")
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
                        lv.SubItems.Add(dr.GetString(7));
                        lvwStaff.Items.Add(lv);
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
                dr.Dispose();
            }

        }

        private void ucStaff_Load(object sender, EventArgs e)
        {
            loadData();

            FirstLoad();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
            FirstLoad();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwStaff.SelectedItems.Count == 1)
            {

                try
                {
                    if (MessageBox.Show("Are You Sure You Want To Delete All The Data Of This Staff", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        dc.con.Open();
                        string query = "DELETE FROM tblaccount WHERE staff_id = '" + lvwStaff.SelectedItems[0].SubItems[0].Text + "'; " +
                                        " DELETE FROM tblstaff WHERE staff_id = '" + lvwStaff.SelectedItems[0].SubItems[0].Text + "'";
                        cmd = new MySqlCommand(query, dc.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Staff Deleted Success","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                }
                loadData();
                FirstLoad();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvwStaff.SelectedItems.Count == 1)
            {
                frmAddEditStaff frm = new frmAddEditStaff();
                DatabaseConnection.adding = false;
                DatabaseConnection.updating = true;
                frm.txtID.Text = lvwStaff.SelectedItems[0].SubItems[0].Text;
                frm.LoadUpdate();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    loadData();
                }
                FirstLoad();
            }
        
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            if(lvwStaff.SelectedItems.Count == 1)
            {
                try
                {
                    if (lvwStaff.SelectedItems[0].SubItems[8].Text == "Admin" || lvwStaff.SelectedItems[0].SubItems[8].Text == "Staff")
                    {
                        dc.con.Open();
                        string query = "SELECT * FROM tblaccount WHERE staff_id = '" + lvwStaff.SelectedItems[0].SubItems[0].Text + "'";
                        cmd = new MySqlCommand(query, dc.con);
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            string user = dr["username"].ToString();
                            string pass = dr["password"].ToString();
                            string type = dr["type"].ToString();
                            MessageBox.Show("Username:  " + user +
                                            "\nPassword:  " + pass +
                                            "\nAccount Type:  " + type, "Account", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        frmPriestDetails frm = new frmPriestDetails();
                        frm.lblPriest.Text = (lvwStaff.SelectedItems[0].SubItems[3].Text + " " + lvwStaff.SelectedItems[0].SubItems[4].Text + " " + lvwStaff.SelectedItems[0].SubItems[2].Text);
                        dc.con.Open();
                        string query = "SELECT * FROM tblaccount WHERE staff_id = '" + lvwStaff.SelectedItems[0].SubItems[0].Text + "'";
                        cmd = new MySqlCommand(query, dc.con);
                        dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            dr.Read();
                            frm.lblUser.Text = dr["username"].ToString();
                            frm.lblPass.Text = dr["password"].ToString();
                        }
                       
                        frm.Show();
                    }


                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dc.con.Close();
                    dr.Close();
                    cmd.Dispose();
                  
                }
                FirstLoad();
            }
            else
            {
                MessageBox.Show("Select an item in the listview");
            }
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
                loadData(txtSearch.Text);
           
                loadDataFN(txtSearch.Text);
            
                loadDataRole(txtSearch.Text);
            
        }
        public void loadDataFN(string search = null)
        {
            try
            {
                dc.con.Open();
                string query = "SELECT * FROM tblstaff WHERE firstname LIKE '" + search + "%'";
                cmd = new MySqlCommand(query, dc.con);
                dr = cmd.ExecuteReader();
                lvwStaff.Items.Clear();
                int i = 0;
                while (dr.Read())
                {
                    if (dr["role"].ToString() != "Admin")
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
                        lv.SubItems.Add(dr.GetString(7));
                        lvwStaff.Items.Add(lv);
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
                dr.Dispose();
            }

        }
        public void loadDataRole(string search = null)
        {
            try
            {
                dc.con.Open();
                string query = "SELECT * FROM tblstaff WHERE role LIKE '" + search + "%'";
                cmd = new MySqlCommand(query, dc.con);
                dr = cmd.ExecuteReader();
                lvwStaff.Items.Clear();
                int i = 0;
                while (dr.Read())
                {
                    if (dr["role"].ToString() != "Admin")
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
                        lv.SubItems.Add(dr.GetString(7));
                        lvwStaff.Items.Add(lv);
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
                dr.Dispose();
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void FirstLoad()
        {
            btnEdit.Enabled = false;
            btnAccount.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            txtSearch.Text = "";
            
        }

        private void lvwStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwStaff.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
                btnAccount.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
            }
            else
            {
                FirstLoad();
            }


        }

        private void lvwStaff_Leave(object sender, EventArgs e)
        {
      
        }

        private void lvwStaff_Enter(object sender, EventArgs e)
        {
            if (lvwStaff.SelectedItems.Count > 0)
            {
                btnEdit.Enabled = true;
                btnAccount.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            FirstLoad();
        }
    }   
}
