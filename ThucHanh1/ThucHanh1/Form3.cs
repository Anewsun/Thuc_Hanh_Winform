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
    public partial class FGiangVien : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        GiangVienDao giangvienDao = new GiangVienDao();
        public FGiangVien()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            gvGVien.DataSource = giangvienDao.HienThiDanhSach();
        }

        private void gvGVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin từ dòng được chọn
                DataGridViewRow selectedRow = gvGVien.Rows[e.RowIndex];

                txtHoTen.Text = selectedRow.Cells["Ten"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["Diachi"].Value.ToString();
                txtCMND.Text = selectedRow.Cells["CMND"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["ngaysinh"].Value);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GiangVien giangvien = new GiangVien(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value);

            giangvienDao.ThemGiangVien(giangvien);
            gvGVien.DataSource = giangvienDao.HienThiDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvGVien.SelectedRows.Count > 0)
            {
                GiangVien giangvien = new GiangVien();
                giangvien.cmnd = txtCMND.Text;
                giangvienDao.XoaGiangVien(giangvien.cmnd);
                gvGVien.DataSource = giangvienDao.HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học sinh để xóa.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gvGVien.SelectedRows.Count > 0)
            {
                GiangVien giangvien = new GiangVien(txtHoTen.Text, txtDiaChi.Text, txtCMND.Text, dateTimePicker1.Value);
                giangvienDao.SuaGiangVien(giangvien);
                gvGVien.DataSource = giangvienDao.HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học sinh để sửa.");
            }
        }

    }
}