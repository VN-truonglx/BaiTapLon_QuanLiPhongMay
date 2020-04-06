using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhachSancode
{
    public partial class QLPM : Form
    {
        public QLPM()
        {
            InitializeComponent();
        }

        private void lịchThựcHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhongMay.ChildForms.QuanLyLichThucHanh.frmLichThucHanh f = new QuanLyPhongMay.ChildForms.QuanLyLichThucHanh.frmLichThucHanh();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();

        }

        private void QLPM_Load(object sender, EventArgs e)
        {

        }
    }
}
