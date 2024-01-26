using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh1
{
    public class GiangVien
    {

        public string hoten { get; set; }

        public string diachi { get; set; }

        public string cmnd { get; set; }

        public DateTime ngaythangnamsinh { get; set; }

        public GiangVien(string hoten, string diachi, string cmnd, DateTime ngaythangnamsinh)
        {
            this.hoten = hoten;
            this.diachi = diachi;
            this.cmnd = cmnd;
            this.ngaythangnamsinh = ngaythangnamsinh;
        }

        public GiangVien()
        {

        }

    }
}