namespace mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*// khai báo mảng
            int[] stt;
            // khởi tạo mảng
            stt = new int[5];
            foreach (int i in stt)
            {
                Console.WriteLine(i+ " ");
            }

            // mảng random
            Random r=new Random();
            int[] mang3= new int[3] {r.Next(51),r.Next(61),r.Next(90)};
            Console.WriteLine();    
            foreach (int i in mang3)
            {
                Console.WriteLine(i+ " ");
            }
            Console.WriteLine();

            // kiểm tra độ dài của mảng
            int dai = mang3.Length;
            Console.WriteLine("do dai cua mang "+dai);
            Console.WriteLine();
            // index mang 
            int[] mang4 = new int[3] { 1, 4, 5 };
            Console.WriteLine(mang4[0]);
            Console.WriteLine(mang4[1]);
            Console.WriteLine(mang4[mang4.Length-1]);
            Console.WriteLine();
            // duyệt mang for ( duyệt theo index )
            Random n=new Random();
            int[] mang5 = new int[3] { n.Next(50), n.Next(51), n.Next(52) };
            for (int i = 0; i < mang5.Length; i++)
            {
                Console.WriteLine("mang 5 tai i " + mang5[i]);
            }
            Console.WriteLine();
            // phép gán 
            int[] mang6 = new int[5] { 1, 2, 3, 4, 5 };
            int[] mang7 = mang6;
            mang6[0] = 100;
            Console.WriteLine("mang 6 sau khi doi " + mang6[0]);
            Console.WriteLine("mang 7 sau khi doi " + mang7[0]);
            Console.WriteLine();
            // coppy to ( coppy to mảng đã có
            int[] mang8 ={ 100, 200, 300, 400, 500 };
            int[] mang9 ={ 1, 2, 3, 4, 5,6,7 };
            mang8.CopyTo(mang9, 2);
            Console.WriteLine("mang 9 sau khi thay doi la");
            foreach (int i in mang9)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();

            // copy
            int[] mang12= { 100, 200, 300, 400 };
            int[] mang13 = new int[4];
            Array.Copy(mang12, mang13, 3);
            Console.WriteLine("mang 13 la");
            foreach (int i in mang13)                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // clone
            int[] mang14 = { 1, 2, 3, 4, 5, 6,7 };
            int[] mang15 = (int[])mang14.Clone();
            Console.WriteLine("mang 15 la");
            foreach (int i in mang15)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // phép đảo ngược 
            int[] mang16 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Array.Reverse(mang16);
            Console.WriteLine("mang 16 sau khi dung phep dao nguoc");
            foreach (int i in mang16)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // sắp xếp 
            int[] mang17 = { 1,5,6,3,2,4,6,4,23,21 };
            Array.Sort(mang17);
            Console.WriteLine("mang 17 sau khi sap xep");
            foreach (int i in mang17)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();*/
            int n;
            Console.WriteLine("moi ban nhap vao so phan tu cua mang");
            n =int.Parse(Console.ReadLine());
            //khai báo
            int[] mang = new int[n];
            // nhập giá trị ngẫu nhiên
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                mang[i] = random.Next(101);
            }
            // xuất mảng
            Console.WriteLine("gia tri ngau nhien cua mang la");
            foreach (int c in mang)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();
            // đảo ngược mảng
            Array.Reverse(mang);
            Console.WriteLine("mang sau khi dao nguoc la");
            foreach(int c in mang)
            {
                Console.Write(c+" ");
            }
            Console.WriteLine();
            // sắp xếp mang
            Array.Sort(mang);
            Console.WriteLine("mang sau khi dao nguoc la");
            foreach (int c in mang)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            // tính tổng của mảng
            int tong = 0;
            foreach ( int  i in mang)
            {
                tong += i;
            }
            Console.WriteLine("tong cua cac phan tu trong mang "+tong);
            // tìm kiếm 
            Console.WriteLine("nhap vao so can tim trong mang");
            int tim=int.Parse(Console.ReadLine());
            int ketqua=Array.BinarySearch(mang, tim);
            if (ketqua == -1)
                Console.WriteLine("khong tim thay");
            else
                Console.WriteLine("so {0} can tim nam o vi tri {1} trong mang",tim,ketqua);
            // tìm kiếm không dùng binarysearch
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (mang[i] == tim)
                {
                    Console.WriteLine("da tim thay so {0} o vi tri {1}",tim,i);
                    dem++;
                }
            }
            if (dem == 0)
                Console.WriteLine("khong tim thay so {0} trong mang",dem);
            Console.ReadKey();
        }
    }
}
