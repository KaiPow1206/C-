using System;

namespace SNT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int n;
            Console.WriteLine("nhap vao so de coi thu phai so nguyen to khong");
            n=int.Parse(Console.ReadLine());
            while(!laSNT(n))
            {
                Console.WriteLine("vui long nhap lai");
                n= int.Parse(Console.ReadLine());
            }*/
            /*var n = 10000;
            while (n > 1)
            {
                n--;
                if (laSNT(n))
                    Console.WriteLine("so nguyen to duoi 10,000 {0}",n);
            }*/
            int n;
            Console.WriteLine("nhap vao so 10000 de thuc hien chuong trinh");
            n = int.Parse(Console.ReadLine());
            while (n != 10000)
            {
                Console.WriteLine("chuong trinh chi nhan gia tri 10000");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 2;i<=n ; i++)
            {
                if (laSNT(i))
                {
                    Console.WriteLine("so nguyen to duoi 10,000 {0}", i);
                }
            }
            Console.ReadLine();
        }

        static bool laSNT(int a)
        {
            if (a < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
