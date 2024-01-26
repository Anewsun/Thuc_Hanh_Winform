using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            FHocSinh frm1 = new FHocSinh();
            frm1.ShowDialog();
            frm1 = null;
            this.Show();
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            FGiangVien frm3 = new FGiangVien();
            frm3.ShowDialog();
            frm3 = null;
            this.Show();
        }
    }
}
