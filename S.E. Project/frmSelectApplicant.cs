using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace S.E.Project
{
    public partial class frmSelectApplicant : Form
    {
        public frmSelectApplicant()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();
        MySqlCommand cmd;
        MySqlDataReader dr;


        private void btnSave_Click(object sender, EventArgs e)
        {
            frmAddEditApplicant frm = new frmAddEditApplicant();
            frm.Show();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick_1(object sender, EventArgs e)
        {

            DatabaseConnection.appID = lvwApplicant.SelectedItems[0].SubItems[0].Text;
            DatabaseConnection.applName = lvwApplicant.SelectedItems[0].SubItems[2].Text;
            DatabaseConnection.appfName = lvwApplicant.SelectedItems[0].SubItems[3].Text;
            DatabaseConnection.appMI = lvwApplicant.SelectedItems[0].SubItems[4].Text;
            DatabaseConnection.appAdd = lvwApplicant.SelectedItems[0].SubItems[5].Text;


            this.DialogResult = DialogResult.OK;
            this.Close();

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
        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void frmSelectApplicant_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditApplicant frm = new frmAddEditApplicant();
            DatabaseConnection.adding = true;
            DatabaseConnection.updating = false;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataLN(txtSearch.Text);
        }
        public void LoadDataLN(string search = null)
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
    }
}
