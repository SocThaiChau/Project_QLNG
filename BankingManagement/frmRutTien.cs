using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingManagement
{
    public partial class frmRutTien : Form
    {
        public frmRutTien()
        {
            InitializeComponent();
        }
        private Form curentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (curentFormChild != null)
            {
                curentFormChild.Close();
            }
            curentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnComback_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmXacNhan());
        }
    }
}
