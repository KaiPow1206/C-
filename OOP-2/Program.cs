using System.Text;

namespace OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            NhanVien nhanvien1 = new NhanVien();
            nhanvien1.tenNV = "nhân viên 1";
            nhanvien1.maNV = 1;
            Console.WriteLine("tên nhân viên là: "+nhanvien1.tenNV+ " mã nhân viên là: "+nhanvien1.maNV);
            Console.WriteLine("lương nhân viên 1 là: "+nhanvien1.TinhLuong());

            NhanVienHanhChinh hanhchinh1= new NhanVienHanhChinh();
            hanhchinh1.tenNV = "hành chính 1";
            hanhchinh1.maNV = 9;
            Console.WriteLine("tên nhân viên là: " + hanhchinh1.tenNV + " mã nhân viên là: " +hanhchinh1.maNV);
            Console.WriteLine("lương nhân viên hành chính 1 là: "+hanhchinh1.TinhLuong());

            NhanVienDiCa dica1= new NhanVienDiCa();
            dica1.tenNV = " đi ca 1";
            dica1.maNV = 6;
            dica1.Ca = "ngày";
            Console.WriteLine("tên nhân viên là: " + dica1.tenNV + " mã nhân viên là: " + dica1.maNV +" đi ca: "+dica1.Ca);
            Console.WriteLine("lương nhân đi ca 1 là: "+dica1.TinhLuong());

            Console.WriteLine("*************************");
            Console.WriteLine("lương của nhân viên: "+nhanvien1.Thuong(26));
            Console.WriteLine("lương của hành chính: "+hanhchinh1.Thuong(26));
            Console.WriteLine("lương của đi ca: "+dica1.Thuong(26));
            Console.ReadKey();
        }
    }
}
