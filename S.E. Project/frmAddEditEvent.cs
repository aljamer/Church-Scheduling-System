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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();
        BindingSource bs = new BindingSource();
        MySqlCommand cmd;
        MySqlDataReader dr;
        int flag = 1;

        public void getID()
        {
            dc.con.Open();
            cmd = new MySqlCommand("select event_id from tblevent", dc.con);
            dr = cmd.ExecuteReader();
            string ans = "";
            if (dr.HasRows)
            {
                dr.Read();
                bs.DataSource = dr;
                bs.MoveLast();
                ans = (dc.val(dr["event_id"].ToString()) + 1).ToString();
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


        public void LoadText()
        {
            dc.con.Open();
            string query = "Select * from tblevent where event_id = '" + txtId.Text + "'";
            cmd = new MySqlCommand(query, dc.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtId.Text = dr["event_id"].ToString();
                txtName.Text = dr["event_name"].ToString();
                txtDesc.Text = dr["event_desc"].ToString();
            }

            dr.Close();
            dc.con.Close();
            cmd.Dispose();
        }
        
        public void firstSave()
        {
            if (txtId.Text == "" || txtName.Text == "" || txtDesc.Text == "")
            {
                MessageBox.Show("Fill up the Event form properly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (DatabaseConnection.adding == true)
                    {
                        dc.con.Open();
                        string query = "insert into tblevent (event_id, event_name, event_desc) Values ('" + txtId.Text + "','" + txtName.Text + "','" + txtDesc.Text + "')";
                        cmd = new MySqlCommand(query, dc.con);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    flag = 2;
                    cmd.Dispose();
                    dc.con.Close();
                }
               
            }
        }       

        private void Form3_Load(object sender, EventArgs e)
        {
            {
                if (DatabaseConnection.adding == true)
                {
                    lblForm.Text = "Add Event";
                    btnSave.Text = "Save";                   
                    getID();
                }
                else
                {
                    lblForm.Text = "Edit Event";
                    btnSave.Text = "Save Changes";
                    LoadText();
                    if(txtName.Text == "Wedding" || txtName.Text == "Funeral" || txtName.Text == "Baptismal")
                    {
                        txtName.Enabled = false;
                    }

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || txtDesc.Text == "")
            {
                MessageBox.Show("Fill up the Event form properly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (DatabaseConnection.adding == true)
                    {
                        dc.con.Open();
                        string query = "insert into tblevent (event_id, event_name, event_desc) Values ('" + txtId.Text + "','" + txtName.Text + "','" + txtDesc.Text + "')";
                        cmd = new MySqlCommand(query, dc.con);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Event Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if(DatabaseConnection.updating == true)
                    {
                        dc.con.Open();
                        string query = "update tblevent set   event_name = '" + txtName.Text + "', event_desc = '" + txtDesc.Text + "' where event_id = '"+ txtId.Text +"' ";
                        cmd = new MySqlCommand(query, dc.con);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Event Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

