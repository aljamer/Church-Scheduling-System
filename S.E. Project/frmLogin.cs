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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            btnLogin.MouseHover += new EventHandler(btnLogin_MouseHover);
            btnLogin.MouseLeave += new EventHandler(btnLogin_MouseLeave);
            btnExit.MouseHover += new EventHandler(btnExit_MouseHover);
            btnExit.MouseLeave += new EventHandler(btnExit_MouseLeave);

        }
        public void btnLogin_MouseHover(object sender, EventArgs e)
        {
            this.btnLogin.BackColor = Color.Black;
            this.btnLogin.ForeColor = Color.White;
        }
        public void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            this.btnLogin.BackColor = Color.Transparent;
            this.btnLogin.ForeColor = Color.White;
        }
        public void btnExit_MouseHover(object sender, EventArgs e)
        {
            this.btnExit.BackColor = Color.Black;
            this.btnExit.ForeColor = Color.White;
        }
        public void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.BackColor = Color.Transparent;
            this.btnExit.ForeColor = Color.White;
        }
    
        DatabaseConnection dc = new DatabaseConnection();
        MySqlCommand cmd;
        MySqlDataReader dr;
    

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                dc.con.Open();
                string query = "Select * from tblaccount JOIN tblstaff ON tblaccount.staff_id = tblstaff.staff_id where username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'";
                cmd = new MySqlCommand(query, dc.con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (dr["type"].ToString() == "Admin")
                    {
                        frmAdminMain frmAdmin = new frmAdminMain();
                        DatabaseConnection.lblCurName = dr["firstname"].ToString() + " " + dr["lastname"].ToString();
                        DatabaseConnection.lblCurRole = dr["role"].ToString();
                        DatabaseConnection.currStaff = dr["staff_id"].ToString();
                       
                        this.Hide();
                        frmAdmin.Show();
                    }
                   
                    else if (dr["type"].ToString() == "Staff")
                    {
                        frmStaffMain frmS = new frmStaffMain();
                        DatabaseConnection.lblCurName = dr["firstname"].ToString() + " " + dr["lastname"].ToString();
                        DatabaseConnection.lblCurRole = dr["role"].ToString();
                        DatabaseConnection.currStaff = dr["staff_id"].ToString();
                        this.Hide();
                        frmS.Show();
                    }

                }
                else if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please input username or password", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();
                }
                else if (!txtUsername.Text.All(Char.IsLetterOrDigit))
                {
                    MessageBox.Show("Username must not contains special characters", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();
                }
                else if (!txtPassword.Text.All(Char.IsLetterOrDigit))
                {
                    MessageBox.Show("Password must not contains characters", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();           
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                cmd.Dispose();
                dc.con.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }
        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
           // if(e.KeyCode == 39)
            {

            }

        }
    }
    
}
