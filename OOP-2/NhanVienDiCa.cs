using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class NhanVienDiCa:NhanVien
    {
        // khai báo ca ngày ca đêm
        public string Ca { get; set; }  
        // phương thức tính lương
        public new double TinhLuong()
        {
            return base.TinhLuong() * 1.05;
        }
    }
}
