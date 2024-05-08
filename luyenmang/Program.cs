namespace luyenmang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("nhap vao so phan tu cua mang");
            n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            Random r = new Random();
            Console.WriteLine("Nhap phan tu cua mang");
            for (int i = 0; i < n; i++)
            {
                Console.Write("phan tu thu {0}: ",i+1);
                mang[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("mang vua nhap la: ");
            for (int i = 0;i < n; i++)
            {
                Console.Write(mang[i]+ " ");
            }
            Console.WriteLine();
            Array.Reverse(mang);
            Console.Write("mang sau khi dao nguoc la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang[i] + " ");
            }
            Console.WriteLine();
            Array.Sort(mang);
            Console.Write("mang sau khi sap xep la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang[i] + " ");
            }
            Console.WriteLine();
            int tong = 0;
            for (int i = 0;i< n ; i++) 
            {
                tong += mang[i];
            }
            Console.WriteLine("tong cua mang la: "+tong);
            int dodai= mang.Length;
            Console.WriteLine("do dai cua mang "+dodai);
            Console.WriteLine("phan tu cuoi cung cua mang " + mang[mang.Length-1]);
        }
    }
}
