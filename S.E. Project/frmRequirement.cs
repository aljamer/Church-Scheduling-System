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
    public partial class frmRequirement : Form
    {
        public frmRequirement()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();
        BindingSource bs = new BindingSource();
        MySqlCommand cmd;
        MySqlDataReader dr;

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmAddEditRequirements frm = new frmAddEditRequirements();
            DatabaseConnection.adding = true;
            DatabaseConnection.updating = false;
            frm.Show();
        }
        public void LoadLvwRec()
        {
            try
            {
                dc.con.Open();
                string query = "SELECT * FROM tblrequirement join tblevent on tblrequirement.event_id = tblevent.event_id  WHERE tblevent.event_id = '" + txtEventId.Text + "%'";
                cmd = new MySqlCommand(query, dc.con);
                dr = cmd.ExecuteReader();
                lvwRec.Items.Clear();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    ListViewItem lv = new ListViewItem(dr["rec_id"].ToString());
                    lv.SubItems.Add(i.ToString());
                    lv.SubItems.Add(dr["rec_name"].ToString());
                    lv.SubItems.Add(dr["rec_desc"].ToString());
                    lv.SubItems.Add(dr["rec_type"].ToString());
                    lvwRec.Items.Add(lv);
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
            frmAddEditRequirements frm = new frmAddEditRequirements();
            DatabaseConnection.adding = true;
            DatabaseConnection.updating = false;
            frm.txtEventId.Text = txtEventId.Text;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadLvwRec();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lvwRec.SelectedItems.Count > 0)
            {
                frmAddEditRequirements frm = new frmAddEditRequirements();
                DatabaseConnection.adding = false;
                DatabaseConnection.updating = true;
                frm.txtId.Text = lvwRec.SelectedItems[0].SubItems[0].Text;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadLvwRec();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwRec.SelectedItems.Count > 0)
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this item", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        dc.con.Open();
                        string query = "delete from tblrequirement where rec_id = '" + lvwRec.SelectedItems[0].SubItems[0].Text + "'";
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
                    LoadLvwRec();
                }
            }
        }

        private void frmRequirement_Load(object sender, EventArgs e)
        {
            LoadLvwRec();
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }
    }
}
