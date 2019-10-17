using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.E.Project
{
    public partial class ucSchedule : UserControl
    {
        public ucSchedule()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditSchedule frm = new frmAddEditSchedule();
            frm.Show();
        }
    }
}
