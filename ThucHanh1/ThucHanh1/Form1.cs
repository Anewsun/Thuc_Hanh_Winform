using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Xml.Linq;
using System.Windows.Forms;
using System;
using ThucHanh1;

namespace ThucHanh1
{
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        HocSinhDao hocsinhDao = new HocSinhDao();
        public FHocSinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gvHsinh.DataSource = hocsinhDao.HienThiDanhSach();
        }

        private void gvHsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin từ dòng được chọn
                DataGridViewRow selectedRow = gvHsinh.Rows[e.RowIndex];

                txtHoTen.Text = selectedRow.Cells["Ten"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["Diachi"].Value.ToString();
                txtCMND.Text = selectedRow.Cells["CMND"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["ngaysinh"].Value);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hocsinh = new HocSinh(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value);

            hocsinhDao.ThemHocSinh(hocsinh);
            gvHsinh.DataSource = hocsinhDao.HienThiDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvHsinh.SelectedRows.Count > 0)
            {
                HocSinh hocsinh = new HocSinh();
                hocsinh.cmnd = txtCMND.Text;
                hocsinhDao.XoaHocSinh(hocsinh.cmnd);
                gvHsinh.DataSource = hocsinhDao.HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học sinh để xóa.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gvHsinh.SelectedRows.Count > 0)
            {
                HocSinh hocsinh = new HocSinh(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value);
                hocsinhDao.SuaHocSinh(hocsinh);
                gvHsinh.DataSource = hocsinhDao.HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học sinh để sửa.");
            }
        }

    }
}