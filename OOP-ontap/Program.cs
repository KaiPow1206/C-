using System.Text;

namespace OOP_ontap
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Phanso soThuNhat= new Phanso(3,4);
            Phanso soThuHai = new Phanso(6,4);

            Phanso tongPhanSo = soThuHai + soThuNhat;
            Console.WriteLine("Vậy tổng của 2 phân số là " + tongPhanSo);
            Phanso hieuPhanSo= soThuHai - soThuNhat;
            Console.WriteLine("Vậy hiệu của 2 phân số là " + hieuPhanSo);
        }
    }
}
