using System.Text;

namespace hocytb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*string hoTen;
            float diemVan;
            float diemToan;

            Console.WriteLine("mời bạn nhập họ tên vào: ");
            hoTen = Console.ReadLine();

            Console.WriteLine("điểm toán của bạn : " + hoTen);
            diemToan = float.Parse(Console.ReadLine());

            Console.WriteLine("điểm văn của bạn : " + hoTen);
            diemVan = float.Parse(Console.ReadLine());

            Console.WriteLine("kết quả là bạn {0} được điểm toán là {1} và điểm văn là {2}", hoTen, diemToan, diemVan);*/
            int n,i=1;
            int gt = 1;
            Console.WriteLine("moi ban nhap vao so can tinh");
            n=int.Parse(Console.ReadLine()); 
            /*for(int i = 1 ;i<=n;i++)
            {
                gt *= i;
            }*/
            while (i<=n)
            {
                gt *=i;
                i++;
            }
            Console.WriteLine("giai thua cua {0} la {1} ",n,gt); 
            Console.ReadKey();
        }
    }
}
