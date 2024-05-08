using System;
using System.Text;

namespace lap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Bài 2
            //Console.OutputEncoding = Encoding.UTF8;
            //int n;
            //Console.WriteLine("Nhập vào số phần tử của mảng:");
            //n = int.Parse(Console.ReadLine());
            //int[] mang = new int[n];
            //Random r = new Random();

            //Console.WriteLine("Nhập các phần tử của mảng:");

            //for (int i = 0; i < n; i++)
            //{
            //    if (i % 2 == 0) 
            //    {
            //        Console.Write("Nhập phần tử chẵn ở vị trí {0}: ", i);
            //        mang[i] = int.Parse(Console.ReadLine());

            //        while (mang[i] % 2 != 0) 
            //        {
            //            Console.Write("Nhập lại phần tử chẵn: ", i);
            //            mang[i] = int.Parse(Console.ReadLine());
            //        }
            //    }
            //    else 
            //    {
            //        Console.Write("Nhập phần tử lẻ ở vị trí {0}: ", i);
            //        mang[i] = int.Parse(Console.ReadLine());

            //        while (mang[i] % 2 == 0) 
            //        {
            //            Console.Write("Nhập lại phần tử lẻ : ", i);
            //            mang[i] = int.Parse(Console.ReadLine());
            //        }
            //    }
            //}
            //Console.WriteLine();
            //Console.Write("Mảng vừa nhập là: ");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("\nGiá trị của mảng là: "+mang[i] + " ");
            //}
            #endregion
            #region Bài 3 
            //Console.WriteLine("Nhap kich thuoc mang:");
            //int n = int.Parse(Console.ReadLine());
            //List<int> list = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Nhap phan tu thu {i + 1}: ");
            //    int a = int.Parse(Console.ReadLine());
            //    if (i==0 || a >= list[i - 1])
            //    {
            //        list.Add(a);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Gia tri nhap vao khong hop le, nhap lai: ");
            //        i--;
            //    }
            //}

            //foreach (int i in list)
            //{
            //    Console.WriteLine("Manh vua nhap: " + i);
            //}
            //list.Sort();
            //Console.WriteLine("Mang sau khi sap xep: ");
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Bài 4
            //Console.WriteLine("Nhap kich thuoc mang:");
            //int n = int.Parse(Console.ReadLine());
            //List<int> list = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Nhap phan tu thu {i + 1}: ");
            //    int a = int.Parse(Console.ReadLine());
            //    if (laSNT(a))
            //    {
            //        list.Add(a);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Gia tri nhap vao khong hop le, nhap lai: ");
            //        i--;
            //    }
            //}

            //foreach (int i in list)
            //{
            //    Console.WriteLine("Manh vua nhap: " + i);
            //}
            #endregion
            #region Bài 5_A
            //int n=0;
            //while (n < 5 || n > 200)
            //{
            //    Console.WriteLine("Nhập vào số phần tử của mảng:");
            //    n = int.Parse(Console.ReadLine());

            //    if (n < 5 || n > 200)
            //    {
            //        Console.WriteLine("Số phần tử của mảng phải lớn hơn 5 và nhỏ hơn 200. Vui lòng nhập lại.");
            //    }
            //}
            //List<int> mang = new List<int>();
            //Random ngaunhien = new Random(); 
            //for (int i = 0; i < n; i++) 
            //{
            //    mang.Add(ngaunhien.Next(100));

            //}
            //Console.Write("phần tử mảng ");
            //foreach (int i in mang)
            //{
            //    Console.Write(i+" ");
            //}
            #endregion
            #region Bài 5_B
            //int n = 0;
            //while (n < 5 || n > 50)
            //{
            //    Console.WriteLine("Nhập vào số phần tử của mảng:");
            //    n = int.Parse(Console.ReadLine());

            //    if (n < 5 || n > 50)
            //    {
            //        Console.WriteLine("Số phần tử của mảng phải lớn hơn 5 và nhỏ hơn 200. Vui lòng nhập lại.");
            //    }
            //}
            //List<int> mang = new List<int>();
            //Random ngaunhien = new Random();
            //for (int i = 0; i < n; i++)
            //{
            //    mang.Add(ngaunhien.Next(-101,101));

            //}
            //Console.Write("phần tử mảng ");
            //foreach (int i in mang)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion
            #region Bài 5_C
            int n = 0;
            while (n < 5 || n > 200)
            {
                Console.WriteLine("Nhập vào số phần tử của mảng:");
                n = int.Parse(Console.ReadLine());

                if (n < 5 || n > 200)
                {
                    Console.WriteLine("Số phần tử của mảng phải lớn hơn 5 và nhỏ hơn 200. Vui lòng nhập lại.");
                }
            }
            List<int> mang = new List<int>();
            Random ngaunhien = new Random();
            for (int i = 0; i < n; i++)
            {
                int r;
                do
                {
                    r = ngaunhien.Next(0, 101);
                } while (r % 2 == 0);
                mang.Add(r);
            }
            Console.Write("phần tử mảng ");
            foreach (int i in mang)
            {
                Console.Write(i + " ");
            }
            #endregion
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