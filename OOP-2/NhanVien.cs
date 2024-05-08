using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class NhanVien
    {
        // khai báo
        public int maNV { get; set; }
        public string tenNV { get; set; }
        //phương thức
        public double TinhLuong()
        {
            return 1000;
        }
        public virtual double Thuong(int NgayCong)
        {
            if (NgayCong >= 26)
            {
                return 100;
            }
            else
            {
                return 0;
            }
        }
    }
}