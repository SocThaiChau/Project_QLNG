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
    public partial class frmManage : Form
    {
        public frmManage()
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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTTCaNhan());
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTTTaiKhoan());
        }

        private void thôngTinThuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTTThuNhap());
        }

        private void gửiTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNapTien());
        }

        private void rútTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRutTien());
        }

        private void chuyểnKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChuyenTien());
        }
    }
}
