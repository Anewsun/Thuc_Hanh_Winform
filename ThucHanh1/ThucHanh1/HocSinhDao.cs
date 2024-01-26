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
    public class HocSinhDao
    {
        Dbconnection db = new Dbconnection();

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public DataTable HienThiDanhSach()
        {
            return db.HienThiDanhSach("HocSinh");
        }

        public void ThemHocSinh(HocSinh hocSinh)
        {
            string sqlStr = string.Format("INSERT INTO HocSinh(Ten, Diachi, Cmnd, ngaysinh) VALUES ('{0}', '{1}', '{2}', '{3}')",
                                          hocSinh.hoten, hocSinh.diachi, hocSinh.cmnd, hocSinh.ngaythangnamsinh);
            db.ExecuteSqlCommand(sqlStr);

        }

        public void XoaHocSinh(string cmnd)
        {
            string sqlStr = string.Format("DELETE FROM HocSinh WHERE Cmnd = '{0}'", cmnd);
            db.ExecuteSqlCommand(sqlStr);
        }

        public void SuaHocSinh(HocSinh hocSinh)
        {
            string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', Diachi = '{1}', NgaySinh = '{2}' WHERE Cmnd = '{3}'",
                                          hocSinh.hoten, hocSinh.diachi, hocSinh.ngaythangnamsinh, hocSinh.cmnd);
            db.ExecuteSqlCommand(sqlStr);
        }
    }

}