namespace totien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t,t20,t10,t5,t2,t1;
            Console.WriteLine("nhap vao gia tri muon chuyen doi: ");
            t=int.Parse(Console.ReadLine());
            t20 = t / 20;
            t %= 20;
            t10= t / 10;
            t %= 10;
            t5 = t / 5;
            t %= 5;
            t2 = t / 2;
            t %= 2;
            t1 = t / 1;
            t %= 1;
            int tong = t20 + t10 + t5 + t2 + t1;
            Console.WriteLine("loai 20 "+t20);
            Console.WriteLine("loai 10 " + t10);
            Console.WriteLine("loai 5 " + t5);
            Console.WriteLine("loai 2 " + t2);
            Console.WriteLine("loai 1 " + t1);
            Console.WriteLine("tong so cac loai "+tong);
        }
    }
}
