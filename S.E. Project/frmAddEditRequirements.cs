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
    public partial class frmAddEditRequirements : Form
    {
        public frmAddEditRequirements()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();
        BindingSource bs = new BindingSource();
        MySqlCommand cmd;
        MySqlDataReader dr;


        public void LoadUpdate()
        {
            dc.con.Open();
            string query = "Select * from tblrequirement  where rec_id = '" + txtId.Text + "'";
            cmd = new MySqlCommand(query, dc.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtId.Text = dr["rec_id"].ToString();
                txtName.Text = dr["rec_name"].ToString();
                txtDesc.Text = dr["rec_desc"].ToString();
                cmbType.Text = dr["rec_type"].ToString();
            }

            dr.Close();
            dc.con.Close();
            cmd.Dispose();
        }

        private void frmAddEditRequirements_Load(object sender, EventArgs e)
        {
            if (DatabaseConnection.adding == true)
            {
                lblForm.Text = "Add Recquirement";
            }
            else
            {
                lblForm.Text = "Edit Requirement";
                LoadUpdate();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDesc.Text == "" || txtName.Text == "" || cmbType.Text == "")
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
                        string query = "insert into tblrequirement (event_id, rec_name, rec_desc, rec_type) Values ('" + txtEventId.Text + "','" + txtName.Text + "','" + txtDesc.Text + "','" + cmbType.Text + "')";
                        cmd = new MySqlCommand(query, dc.con);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Requirement Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (DatabaseConnection.updating == true)
                    {
                        dc.con.Open();
                        string query = "update tblrequirement set rec_name = '" + txtName.Text + "', rec_desc = '" + txtDesc.Text + "', rec_type = '" + cmbType.Text + "' where rec_id = '" + txtId.Text + "'";

                        cmd = new MySqlCommand(query, dc.con);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Requirement Updatted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
