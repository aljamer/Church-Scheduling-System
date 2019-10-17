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
    public partial class frmAddEditVenue : Form
    {
        public frmAddEditVenue()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();
        BindingSource bs = new BindingSource();
        MySqlCommand cmd;
        MySqlDataReader dr;

        public void getID()
        {
            dc.con.Open();
            cmd = new MySqlCommand("select venue_id from tblvenue", dc.con);
            dr = cmd.ExecuteReader();
            string ans = "";
            if (dr.HasRows)
            {
                dr.Read();
                bs.DataSource = dr;
                bs.MoveLast();
                ans = (dc.val(dr["venue_id"].ToString()) + 1).ToString();
                txtId.Text = ans;
            }
            else
            {
                txtId.Text = "1";
            }
            dr.Close();
            dc.con.Close();
            cmd.Dispose();
        }


        public void LoadUpdate()
        {
            dc.con.Open();
            string query = "Select * from tblvenue where venue_id = '" + txtId.Text + "'";
            cmd = new MySqlCommand(query, dc.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtId.Text = dr["venue_id"].ToString();
                txtName.Text = dr["venue_name"].ToString();
                txtLoc.Text = dr["location"].ToString();
            }

            dr.Close();
            dc.con.Close();
            cmd.Dispose();
        }

        private void frmAddEditVenue_Load(object sender, EventArgs e)
        {
            if (DatabaseConnection.adding == true)
            {
                lblForm.Text = "Add Venue";
                getID();
            }
            else
            {
                lblForm.Text = "Edit Venue";
                LoadUpdate();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtLoc.Text == "")
            {
                MessageBox.Show("Fill up the form properly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (DatabaseConnection.adding == true)
                    {
                        dc.con.Open();
                        string query = "insert into tblvenue (venue_id, venue_name, location) Values ('" + txtId.Text + "','" + txtName.Text + "','" + txtLoc.Text + "')";
                        cmd = new MySqlCommand(query, dc.con);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Venue Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (DatabaseConnection.updating == true)
                    {
                        dc.con.Open();
                        string query = "update tblvenue set venue_name = '" + txtName.Text + "' , location = '" + txtLoc.Text + "' where venue_id = '"+ txtId.Text +"'";
                        cmd = new MySqlCommand(query, dc.con);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Venue Updatted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
