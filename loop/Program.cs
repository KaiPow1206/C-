namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int n;
            Console.WriteLine("moi ban nhap so nguyen duong");
            n=int.Parse(Console.ReadLine());
            while(n<1 || n > 10)
            {
                Console.WriteLine("Ban vui long nhap lai. So nguyen duong chi tu 1 ->10");
                n = int.Parse(Console.ReadLine());
            }
            int gt=1;
            for(int i=1; i <= n; i++)
            {
                gt *= i;
            }
            Console.WriteLine("ket qua cua {0} la {1}",n,gt);*/
            //int a = 1;
            //int tong = 0;
            //do
            //{
            //    tong += a;
            //    a++;
            //}while (a <= 5);
            //Console.WriteLine("tong tu 1 den 5: "+tong);
            int n;
            Console.WriteLine("hay nhap vao day mot so nguyen: ");
            n =int.Parse(Console.ReadLine());
            int tong=0;
            for (int i=0;i<=n;i++)
            {
                if (i % 2 == 1)
                {
                    if (i == 3)
                        continue;
                    else
                        tong += i;
                }
            }
            Console.WriteLine("tong cac so le tu 0 den {0} co ket qua la {1} ",n,tong);
        }
    }
}
