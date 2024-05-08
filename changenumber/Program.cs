using System;

namespace changenumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*float n;
            while (true)
            {
                Console.WriteLine("nhap vao so thuc > 0");
                n = float.Parse(Console.ReadLine());
                if (n>0)
                {
                    float giatrituyetdoi = Math.Abs(n);
                    Console.WriteLine("gia tri tuyet doi cua "+n+ " la "+giatrituyetdoi);
                    float canbachai = (float)Math.Sqrt(n);
                    Console.WriteLine("can bac 2 cua "+n+ " la "+canbachai);
                    float giatridoi = n * (-1);
                    Console.WriteLine("so doi cua "+n+ " la "+giatridoi);
                }
                else
                {
                    Console.WriteLine("phuong trinh chi nhan so thuc > 0");
                }
            }*/
            float n;
            Console.WriteLine("nhap vao so thuc");
            n = float.Parse(Console.ReadLine());
            float giatrituyetdoi = Math.Abs(n);
            Console.WriteLine("gia tri tuyet doi cua " + n + " la " + giatrituyetdoi);
            float giatridoi = n * (-1);
            Console.WriteLine("so doi cua " + n + " la " + giatridoi);
            if (n>0)
            {
                float canbachai = (float)Math.Sqrt(n);
                Console.WriteLine("can bac 2 cua " + n + " la " + canbachai);
            }
            else
            {
                float canbachai = (float)Math.Sqrt(-n);
                Console.WriteLine("can bac 2 cua " + n + " la " + canbachai+ "i");
            }
            Console.ReadLine();
        }
    }
}
