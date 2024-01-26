using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ThucHanh1;

namespace ThucHanh1
{
    public class GiangVienDao
    {
        Dbconnection db = new Dbconnection();

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DataTable HienThiDanhSach()
        {
            return db.HienThiDanhSach("GiangVien");
        }

        public void ThemGiangVien(GiangVien giangVien)
        {
            string sqlStr = string.Format("INSERT INTO GiangVien(Ten, Diachi, Cmnd, ngaysinh) VALUES ('{0}', '{1}', '{2}', '{3}')",
                                          giangVien.hoten, giangVien.diachi, giangVien.cmnd, giangVien.ngaythangnamsinh);
            db.ExecuteSqlCommand(sqlStr);

        }

        public void XoaGiangVien(string cmnd)
        {
            string sqlStr = string.Format("DELETE FROM GiangVien WHERE Cmnd = '{0}'", cmnd);
            db.ExecuteSqlCommand(sqlStr);
        }

        public void SuaGiangVien(HocSinh giangVien)
        {
            string sqlStr = string.Format("UPDATE GiangVien SET Ten = '{0}', Diachi = '{1}', NgaySinh = '{2}' WHERE Cmnd = '{3}'",
                                          giangVien.hoten, giangVien.diachi, giangVien.ngaythangnamsinh, giangVien.cmnd);
            db.ExecuteSqlCommand(sqlStr);
        }

        internal void SuaGiangVien(GiangVien giangvien)
        {
            throw new NotImplementedException();
        }
    }

}