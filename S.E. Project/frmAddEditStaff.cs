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
    public partial class frmAddEditStaff : Form
    {
        public frmAddEditStaff()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();
        BindingSource bs = new BindingSource();
        MySqlCommand cmd;
        MySqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }
       private void LockText()
        {
            txtLn.ReadOnly = true;
            txtFn.ReadOnly = true;
            txtMI.ReadOnly = true;
            txtAdd.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtMobile.ReadOnly = true;
            txtID.Enabled = false;
            			
            btnSave.Enabled = false;
        }       
        private void UnlockText()
        {
            txtLn.ReadOnly = false;
            txtFn.ReadOnly = false;
            txtMI.ReadOnly = false;
            txtAdd.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtMobile.ReadOnly = false;
     
            btnSave.Enabled = true;
        }
        private void Clr()
        {
            txtID.Text = "";
            txtLn.Text = "";
            txtFn.Text = "";
            txtMI.Text = "";
            txtAdd.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            cmbRole.Text = "";
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {

            txtFn.Focus();

            if (DatabaseConnection.updating == true)
            {
                lblForm.Text = "Update Staff";
                UnlockText();
                btnSave.Enabled = true;
                txtID.Enabled = false;
                cmbRole.Enabled = false;				
                txtUser.ReadOnly = true;
            }
            else if(DatabaseConnection.adding == true)
            {
                lblForm.Text = "Add Staff";
                getID();
                
                cmbRole.Focus();
               // LockText();
            }
            
        }
        public void getID()
        {
            dc.con.Open();
            cmd = new MySqlCommand("select staff_id from tblstaff", dc.con);
            dr = cmd.ExecuteReader();
            string ans = "";
            if (dr.HasRows)
            {
                dr.Read();
                bs.DataSource = dr;
                bs.MoveLast();
                ans = (dc.val(dr["staff_id"].ToString()) + 1).ToString();
                txtID.Text = ans;
            }
            else
            {
                txtID.Text = "1";
            }
            dr.Close();
            dc.con.Close();
            cmd.Dispose();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Clr();
            LockText();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "" || cmbRole.Text == "" || txtLn.Text == "" || txtFn.Text == "" || txtMI.Text == "" || txtAdd.Text == "" || txtEmail.Text == "" || txtMobile.Text == "" || txtUser.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Fill up the form properly", "Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    if (DatabaseConnection.adding == true)
                    {
                        dc.con.Open();
                        if (cmbRole.Text != "Priest" && cmbRole.Text != "Staff")
                        {
                            string query = "INSERT INTO tblStaff(staff_id, lastname, firstname, mi, address,email_add,contact_num, role)" +
                                           "VALUES ('" + txtID.Text + "','" + txtLn.Text + "','" + txtFn.Text + "','" + txtMI.Text + "','" + txtAdd.Text + "','" + txtEmail.Text + "','" + txtMobile.Text + "','" + cmbRole.Text + "')";
                            cmd = new MySqlCommand(query, dc.con);
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Staff Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                MessageBox.Show("Error Adding Staff", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            string query = "INSERT INTO tblStaff (staff_id, lastname, firstname, mi, address,email_add,contact_num, role)" +
                                           "VALUES ('" + txtID.Text + "','" + txtLn.Text + "','" + txtFn.Text + "','" + txtMI.Text + "','" + txtAdd.Text + "','" + txtEmail.Text + "','" + txtMobile.Text + "','" + cmbRole.Text + "');" +
                                           "INSERT INTO tblaccount (staff_id, type, username, password )" +
                                           "VALUES ('" + txtID.Text + "','" + cmbRole.Text + "','" + txtUser.Text + "','" + txtPass.Text + "');";
                            cmd = new MySqlCommand(query, dc.con);
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Staff Added With An Account");
                            }

                        }

                        this.Hide();
                    }
                    else if (DatabaseConnection.updating == true)
                    {
                        dc.con.Open();
                        string query = "UPDATE tblStaff " +
                                        "SET lastname = '" + txtLn.Text + "',firstname = '" + txtFn.Text + "', mi = '" + txtMI.Text + "', address = '" + txtAdd.Text + "',email_add = '" + txtEmail.Text + "', contact_num = '" + txtMobile.Text + "'" +
                                        " WHERE staff_id = '" + txtID.Text + "' ";
                        cmd = new MySqlCommand(query, dc.con);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Staff Updated");
                            // btnCancel.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Error Updating Staff");
                        }
                        this.DialogResult = DialogResult.OK;
                        this.Close();
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
        }

        public void LoadUpdate()
        {
            dc.con.Open();
            string query = "Select * from tblstaff JOIN tblaccount ON tblstaff.staff_id = tblaccount.staff_id where tblstaff.staff_id = '"+ txtID.Text +"'";
            cmd = new MySqlCommand(query, dc.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                txtID.Text = dr["staff_id"].ToString();
                txtLn.Text = dr["lastname"].ToString();
                cmbRole.Text = dr["role"].ToString();
                txtFn.Text = dr["firstname"].ToString();
                txtMI.Text = dr["mi"].ToString();
                txtAdd.Text = dr["address"].ToString();
                txtEmail.Text = dr["email_add"].ToString();
                txtMobile.Text = dr["contact_num"].ToString();
               
                txtUser.Text = dr["username"].ToString();
                txtPass.Text = dr["password"].ToString();
            }

            dr.Close();
            dc.con.Close();
            cmd.Dispose();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private Boolean ValidateUsername(string user)
        {
            dc.con.Open();
            cmd = new MySqlCommand("select username from tblaccount where username = '" + user + "'", dc.con);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dc.con.Close();
                dr.Close();
                cmd.Dispose();
                return true;
            }
            else
            {
                dc.con.Close();
                dr.Close();
                cmd.Dispose();
                return false;                   
            }
         
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

            if (DatabaseConnection.adding == true)
            {
                if (ValidateUsername(txtUser.Text.ToString()))
                {
                    MessageBox.Show("Username Already Taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUser.Text = "";
                }
            }



        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

		private void button2_Click_1(object sender, EventArgs e)
		{

		}

		private void btnUploadPic_Click(object sender, EventArgs e)
		{
		}

		private void button2_Click_2(object sender, EventArgs e)
		{

			OpenFileDialog open = new OpenFileDialog();
			// image filters  
			open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp); *.PNG|*.jpg; *.jpeg; *.gif; *.bmp; *.PNG";
			if (open.ShowDialog() == DialogResult.OK)
			{
				//display image in picture box  
				// picBoxMovies.Image = new Bitmap(open.FileName);
				//pbAccImg.Image = Image.FromFile(open.FileName);
				// image file path  
			//	lblfilename.Text = open.FileName;
			}
		}

        private void cmbRole_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtLn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
