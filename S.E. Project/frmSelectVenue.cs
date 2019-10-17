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
    public partial class frmSelectVenue : Form
    {
        public frmSelectVenue()
        {
            InitializeComponent();
        }
        DatabaseConnection dc = new DatabaseConnection();
        MySqlCommand cmd;
        MySqlDataReader dr;


        private void frmSelectVenue_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData(string search = null)
        {
            try
            {
                dc.con.Open();
                string query = "SELECT * FROM tblvenue WHERE venue_name LIKE '" + search + "%'";
                cmd = new MySqlCommand(query, dc.con);
                dr = cmd.ExecuteReader();
                lvwVenue.Items.Clear();
                int i = 0;
                while (dr.Read())
                {
                    i++;
                    ListViewItem lv = new ListViewItem(dr.GetString(0));
                    lv.SubItems.Add(i.ToString());
                    lv.SubItems.Add(dr.GetString(1));
                    lv.SubItems.Add(dr.GetString(2));
                    lvwVenue.Items.Add(lv);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
