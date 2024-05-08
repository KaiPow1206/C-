using System.Text;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // tạo 1 đối tượng không truyền giá trị
            sinhvien sinhVien1 = new sinhvien();
            sinhvien sinhVien2 = new sinhvien();
            //xuất thông tin
            Console.WriteLine(sinhVien1.MaSV);
            Console.WriteLine(sinhVien1.TenSV);
            Console.WriteLine(sinhVien2.MaSV);
            Console.WriteLine(sinhVien2.TenSV);
            /*// tạo 1 đối tượng truyền giá trị vào
            sinhvien sinhVien3= new sinhvien(12,"anh thái",);
            Console.WriteLine("tên sinh viên 3 là "+sinhVien3.TenSV);
            // sửa dữ liệu 
            sinhVien3.MaSV = 12062610;
            sinhVien3.TenSV = "thái châu";
            Console.WriteLine("mã sinh viên 3 là "+ sinhVien3.MaSV);
            Console.WriteLine("mã sinh viên 3 là "+ sinhVien3.TenSV);
            // phương pháp toString
            Console.WriteLine(sinhVien1.ToString());
            Console.WriteLine(sinhVien1);
            Console.WriteLine(sinhVien3.ToString());
            Console.WriteLine(sinhVien3);*/


            //suport method- service method
            sinhvien sinhVien3= new sinhvien(3,"anh thái",20);
            //check điểm
            sinhVien3.Xuatthongtin();
            Console.WriteLine(sinhVien3.Tong(4,8,4));
            // tổng điểm
            Console.WriteLine(sinhVien2.diemTrungBinh(4,5,6,10,6,7,2,6,7,4,6,9));
            Console.WriteLine(sinhVien1.diemTrungBinh(8,7,8,6,7,8,9,7,8,9,7,6,7));
            //auto -implemented properties
            HocSinh hocsinh1= new HocSinh();
            hocsinh1.Name = " thái";
            hocsinh1.Email = "thai@gmail.com";
            hocsinh1.Phone = "09xxx";
            Console.WriteLine(hocsinh1);

            Console.ReadLine();
        }
    }
}
