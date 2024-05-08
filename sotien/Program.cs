namespace sotien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("nhap vao so nguyen duong 0-9");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("voi {0} co ket qua theo de bai {1} + {2} + {3} = {4} ",a,a*1,a*11,a*111,((a*1)+(a*11)+(a*111)));
        }
    }
}
