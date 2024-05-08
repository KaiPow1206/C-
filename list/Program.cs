using System;
using System.ComponentModel;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("moi nhap vao so phan tu cua list");
            //int n = int.Parse(Console.ReadLine());
            //Random r = new Random();
            //List<int> ds = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    ds.Add(r.Next(1, 101));
            //}
            //Console.WriteLine("danh sach ngau nhien vua tao ra la");
            //foreach (int i in ds)
            //{
            //    Console.Write(i + " ");
            //}


            //Console.WriteLine("moi nhap vao so phan tu cua list");
            //int n = int.Parse(Console.ReadLine());
            //List<int> danhSach = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"moi nhap vao phan tu thu {i + 1}: ");
            //    danhSach.Add(int.Parse(Console.ReadLine()));
            //}
            //Console.WriteLine("list ban vua nhap la");
            //foreach (int i in danhSach) { Console.Write(i + " "); }
            //Console.WriteLine();
            //List<double> danhSach2 = new List<double>();
            //foreach (int i in danhSach)
            //{
            //    danhSach2.Add(Math.Pow(i, 2));
            //}
            //Console.WriteLine("list thu 2 la ");
            //foreach (int i in danhSach2)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //int dem = 0;
            //foreach (int i in danhSach2)
            //{
            //    if (i > 50)
            //        dem++;
            //}
            //Console.WriteLine($"co {dem} bien lon hon 50");

            Console.WriteLine("Nhap vao so luong phong tro");
            int n = int.Parse(Console.ReadLine());
            List<string> danhSach = new List<string>();
            for (int i = 0; i <n; i++)
            {
                Console.Write($"phong tro thu {i + 1}: ");
                danhSach.Add(Console.ReadLine());
            }

            Console.WriteLine("danh sach phong tro");
            foreach( string i in danhSach)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine("nhap vao nha tro ban muon tim");
            string tim = Console.ReadLine();
            int daTimThay = 0;
            for (int i = danhSach.Count - 1; i >= 0; i--)
            {
                if (danhSach[i] == tim)
                {
                    Console.WriteLine("Da tim thay phong ban muon tim roi.");
                    daTimThay++;
                }
            }
            if (daTimThay == 0)
                Console.WriteLine("khong tim thay phong ban muon tim");
            Console.WriteLine("nhap vao phong tro ban muon xoa ");
            string xoaPhong=Console.ReadLine();
            for (int i = danhSach.Count - 1; i >= 0; i--)
            {
                if (danhSach[i] == xoaPhong)
                {
                    Console.WriteLine("Da xoa phong ban muon xoa.");
                    danhSach.RemoveAt(i);
                }
            }
            Console.WriteLine("danh sach phong sau khi da xoa ");
            foreach ( string i in danhSach)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
