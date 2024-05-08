using System.ComponentModel.Design;
using System.Text;

namespace lap
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập tên của bạn: ");
            string name = Console.ReadLine();
            cau1.Checkusername(name);
            Console.WriteLine("Nhập tuổi của bạn: ");
            int age= int.Parse(Console.ReadLine());
            cau2.Checkageuser(age);
            demtuoi.dem();
            Loop.vonglap();
            Console.ReadLine();
        }
    }
}
