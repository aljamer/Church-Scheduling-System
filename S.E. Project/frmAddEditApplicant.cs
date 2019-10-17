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
    public partial class frmAddEditApplicant : Form
    {
        public frmAddEditApplicant()
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
            cmd = new MySqlCommand("select app_id from tblapplicant", dc.con);
            dr = cmd.ExecuteReader();
            string ans = "";
            if (dr.HasRows)
            {
                dr.Read();
                bs.DataSource = dr;
                bs.MoveLast();
                ans = (dc.val(dr["app_id"].ToString()) + 1).ToString();
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
            string query = "Select * from tblapplicant where app_id = '" + txtId.Text + "'";
            cmd = new MySqlCommand(query, dc.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtId.Text = dr["app_id"].ToString();
                txtLN.Text = dr["lastname"].ToString();
                txtFN.Text = dr["firstname"].ToString();
                txtMI.Text = dr["mi"].ToString();
                txtAddr.Text = dr["address"].ToString();
                txtEmail.Text = dr["email_add"].ToString();
                txtMobile.Text = dr["mobile_num"].ToString();
            }

            dr.Close();
            dc.con.Close();
            cmd.Dispose();
        }


        private void frmAddEditApplicant_Load(object sender, EventArgs e)
        {
            if (DatabaseConnection.adding == true)
            {
                lblForm.Text = "Add Applicant";
                getID();
            }
            else
            {
                lblForm.Text = "Edit Applicant";
                LoadUpdate();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtFN.Text == "" || txtLN.Text == "" || txtMI.Text == "" || txtAddr.Text == "" || txtEmail.Text == "" || txtMobile.Text == "")
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
                        string query = "insert into tblapplicant (app_id, lastname, firstname, mi, address, email_Add, mobile_num) Values ('" + txtId.Text + "','" + txtLN.Text + "','" + txtFN.Text + "','" + txtMI.Text + "','" + txtAddr.Text + "','" + txtEmail.Text + "','" + txtMobile.Text + "')";
                        cmd = new MySqlCommand(query, dc.con);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Applicant Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        DatabaseConnection.appID = txtId.Text;
                        DatabaseConnection.applName = txtLN.Text;
                        DatabaseConnection.appfName = txtFN.Text;
                        DatabaseConnection.appMI = txtMI.Text;
                        DatabaseConnection.appAdd = txtAddr.Text;
                    }
                    else if (DatabaseConnection.updating == true)
                    {
                        dc.con.Open();
                        string query = "update tblapplicant set lastname = '" + txtLN.Text + "', firstname = '" + txtFN.Text + "', mi = '" + txtMI.Text + "', address = '" + txtAddr.Text + "', email_add = '" + txtEmail.Text + "', mobile_num = '" + txtMobile.Text + "' where app_id = '"+ txtId.Text +"'";
                        cmd = new MySqlCommand(query, dc.con);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Applicant Updatted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
