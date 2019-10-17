using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.E.Project
{
    public partial class frmNewParticipant : Form
    {
        public frmNewParticipant()
        {
            InitializeComponent();
        }

        private void frmNewParticipant_Load(object sender, EventArgs e)
        {
            if(DatabaseConnection.curEvent.Contains("Wedding"))
            {
                panelWedding.Visible = true;
            }
            else if (DatabaseConnection.curEvent.Contains("Funeral"))
            {
                panelFuneral.Visible = true;
                panelFuneral.BringToFront();
            }
            else if (DatabaseConnection.curEvent.Contains("Baptismal"))
            {
                panelBaptismal.Visible = true;
            }
        }

        private void panelBaptismal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
