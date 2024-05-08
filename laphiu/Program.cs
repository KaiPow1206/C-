namespace laphiu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a, b, c;
            Console.WriteLine("nhap vao so thu 1:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao so thu 2: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao so thu 3: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("cac so ban da nhap: {0}, {1}, {2}",a,b,c);
            int tich = a * b * c;
            Console.WriteLine("tich cua cac so: "+tich);
            // bài lap số 1
            int a, b;
            Console.WriteLine("nhap vao so thu 1:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao so thu 2: ");
            b = int.Parse(Console.ReadLine());
            int tong = a + b;
            Console.WriteLine("tong cua cac so "+tong);
            int tich = a * b;
            Console.WriteLine("tich cua cac so "+tich);
            int hieu = a - b;
            Console.WriteLine("hieu cua cac so "+hieu);
            double thuong = (float)a / b;
            Console.WriteLine("thuong cua cac so: " + thuong);*/
            /*int n;
            Console.WriteLine("nhap vao so nguyen duong");
            n=int.Parse(Console.ReadLine());
            int tong = 0;
            int tich = 1;
            while (n > 0)
            {
                int a = n % 10;
                tong += a;
                tich *= a;
                n /= 10;
            }
            Console.WriteLine("tong cua day so la " + tong);
            Console.WriteLine("tich cua day so la " + tich);
            float CR;
            Console.WriteLine("nhap vao chieu rong");
            CR=float.Parse(Console.ReadLine());
            float CD = CR * 1.5f;
            Console.WriteLine("chieu dai = 1.5 chieu rong= "+CD+"cm");
            float dientich = CD * CR;
            float chuvi = (CD + CR) * 2; 
            Console.WriteLine("Dien tich hcn= "+dientich+"cm2");
            Console.WriteLine("Chu vi hcn= " + chuvi+"cm");*/
            float soR;
            const double Pi = 3.14;
            Console.WriteLine("nhap vao ban kinh hinh tron ");
            soR=float.Parse(Console.ReadLine());
            Console.WriteLine("chu vi hinh tron "+ (2*Pi*soR));
            Console.WriteLine("dien tich hinh tron "+(Pi*(soR*soR)));
            Console.ReadKey();
        }
    }
}
