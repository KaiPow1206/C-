using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace baitapstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //string chuoi = "nguyễn nho anh thái";
            //Console.WriteLine(chuoi);
            //string chuoi2 = @"D:\nguyennhoanhthai";
            //Console.WriteLine(chuoi2);

            //// chuyển đổi int thành chuỗi
            //int a = 1234;
            //string chuoi5 = a.ToString();// cách 1
            //string chuoi6 = a + "";// cách 2 
            //string chuoi7=Convert.ToString(a);// cách 3
            //Console.WriteLine(chuoi5);
            //Console.WriteLine(chuoi6);
            //Console.WriteLine(chuoi7);


            //// tách chuỗi 
            //string chuoi8 = "xinchào";
            //char[] lst=chuoi8.ToCharArray();
            //Console.WriteLine(lst);

            //// trả độ dài của chuỗi
            //string chuoi9 = "test tách chuỗi";
            //int i = chuoi9.Length;
            //Console.WriteLine(i);

            //// so sánh chuỗi
            //string chuoi10 = "123456";
            //string chuoi11 = "1234";
            //int sosanh= chuoi10.CompareTo(chuoi11);
            //Console.WriteLine(sosanh);

            //// kiểm tra chuỗi con
            //string chuoi12 = "abc";
            //string chuoi13 = "abc1234";
            //bool l=chuoi13.Contains(chuoi12);
            //Console.WriteLine(l);

            //// hàm bool endswith(string value)
            //string chuoi15 = "muonroisaomacon.mp3";
            //bool kt=chuoi15.EndsWith(".mp3");
            //Console.WriteLine("co duoi mp3 "+kt);

            //// gán chuỗi string.format
            //int n = 14;
            //string chuoi16=string.Format("n={0} và căn bậc 2 của n là {1}",n,Math.Sqrt(n));
            //Console.WriteLine(chuoi16);

            //// hàm equals
            //string chuoi17 = "nguyễn nho anh thái";
            //string chuoi18 = "phạm nguyễn hoàng châu";
            //bool kt2=chuoi17.Equals(chuoi18);
            //Console.WriteLine(kt2);

            //// chèn thêm chuỗi 
            //string chuoi19 = "anh yêu m";
            //string chuoi20 = "e";
            //chuoi19 = chuoi19.Insert(8, chuoi20);
            //Console.WriteLine(chuoi19);

            // indexof
            //string chuoi21 = "nguyen nho anh thai";
            //int kq4=chuoi21.IndexOf("a");
            //Console.WriteLine(kq4);
            //Console.WriteLine(chuoi21.Length);

            //// lastindexof
            //string chuoi22 = "nguyen nho anh thai";
            //int kq5=chuoi22.LastIndexOf("a");
            //Console.WriteLine(kq5);

            //// remove
            //string chuoi23 = "12345678";
            //Console.WriteLine(chuoi23);
            //chuoi23 =chuoi23.Remove(1, 3);
            //Console.WriteLine(chuoi23);

            ////replace
            //string chuoi24 = "1234412341234";
            //chuoi24 = chuoi24.Replace("44", "aaa");
            //Console.WriteLine(chuoi24);

            ////startwith
            //string chuoi25 = "muonroisaomacon.mp3";
            //bool kq6=chuoi25.StartsWith("muonroi");
            //Console.WriteLine(kq6);

            //// chiết lọc chuỗi con
            //string chuoi26 = "12345";
            //string chuoi27 = chuoi26.Substring(1, 2);
            //Console.WriteLine(chuoi26);
            //Console.WriteLine(chuoi27);

            ////tolower to upper
            //string chuoi28 = "HHAHDHAHAHAHADHAHhahadhagahHAHhhHAHAH";
            //Console.WriteLine(chuoi28);
            //chuoi28=chuoi28.ToLower();
            //Console.WriteLine(chuoi28);
            //chuoi28 = chuoi28.ToUpper();
            //Console.WriteLine(chuoi28);

            ////trim xóa khoảng trắng
            //string chuoi29 = "       123       ";
            //Console.WriteLine(chuoi29);
            //chuoi29=chuoi29.Trim();
            //Console.WriteLine(chuoi29);

            //// trim xóa khoảng trắng cuối
            //string chuoi30 = "       123       ";
            //Console.WriteLine(chuoi30);
            //chuoi30=chuoi30.TrimEnd();
            //Console.WriteLine(chuoi30);

            //// trim xóa khoảng trắng đầu
            //string chuoi31 = "       123       ";
            //Console.WriteLine(chuoi31);
            //chuoi31 = chuoi31.TrimStart();
            //Console.WriteLine(chuoi31);

            //// split trả về mảng
            //string chuoi32 = @"D:\dowload\public\nguyennhoanhthai";
            //string[] lst = chuoi32.Split('\\');
            //Console.WriteLine(lst[0]);
            //Console.WriteLine(lst[1]);
            //Console.WriteLine(lst[2]);

            ////join string
            //string chuoi33=string.Join("++",lst);
            //Console.WriteLine(chuoi33);//string chuoi = "nguyễn nho anh thái";
            //Console.WriteLine(chuoi);
            //string chuoi2 = @"D:\nguyennhoanhthai";
            //Console.WriteLine(chuoi2);

            //// chuyển đổi int thành chuỗi
            //int a = 1234;
            //string chuoi5 = a.ToString();// cách 1
            //string chuoi6 = a + "";// cách 2 
            //string chuoi7=Convert.ToString(a);// cách 3
            //Console.WriteLine(chuoi5);
            //Console.WriteLine(chuoi6);
            //Console.WriteLine(chuoi7);


            //// tách chuỗi 
            //string chuoi8 = "xinchào";
            //char[] lst=chuoi8.ToCharArray();
            //Console.WriteLine(lst);

            //// trả độ dài của chuỗi
            //string chuoi9 = "test tách chuỗi";
            //int i = chuoi9.Length;
            //Console.WriteLine(i);

            //// so sánh chuỗi
            //string chuoi10 = "123456";
            //string chuoi11 = "1234";
            //int sosanh= chuoi10.CompareTo(chuoi11);
            //Console.WriteLine(sosanh);

            //// kiểm tra chuỗi con
            //string chuoi12 = "abc";
            //string chuoi13 = "abc1234";
            //bool l=chuoi13.Contains(chuoi12);
            //Console.WriteLine(l);

            //// hàm bool endswith(string value)
            //string chuoi15 = "muonroisaomacon.mp3";
            //bool kt=chuoi15.EndsWith(".mp3");
            //Console.WriteLine("co duoi mp3 "+kt);

            //// gán chuỗi string.format
            //int n = 14;
            //string chuoi16=string.Format("n={0} và căn bậc 2 của n là {1}",n,Math.Sqrt(n));
            //Console.WriteLine(chuoi16);

            //// hàm equals
            //string chuoi17 = "nguyễn nho anh thái";
            //string chuoi18 = "phạm nguyễn hoàng châu";
            //bool kt2=chuoi17.Equals(chuoi18);
            //Console.WriteLine(kt2);

            //// chèn thêm chuỗi 
            //string chuoi19 = "anh yêu m";
            //string chuoi20 = "e";
            //chuoi19 = chuoi19.Insert(8, chuoi20);
            //Console.WriteLine(chuoi19);

            // indexof
            //string chuoi21 = "nguyen nho anh thai";
            //int kq4=chuoi21.IndexOf("a");
            //Console.WriteLine(kq4);
            //Console.WriteLine(chuoi21.Length);

            //// lastindexof
            //string chuoi22 = "nguyen nho anh thai";
            //int kq5=chuoi22.LastIndexOf("a");
            //Console.WriteLine(kq5);

            //// remove
            //string chuoi23 = "12345678";
            //Console.WriteLine(chuoi23);
            //chuoi23 =chuoi23.Remove(1, 3);
            //Console.WriteLine(chuoi23);

            ////replace
            //string chuoi24 = "1234412341234";
            //chuoi24 = chuoi24.Replace("44", "aaa");
            //Console.WriteLine(chuoi24);

            ////startwith
            //string chuoi25 = "muonroisaomacon.mp3";
            //bool kq6=chuoi25.StartsWith("muonroi");
            //Console.WriteLine(kq6);

            //// chiết lọc chuỗi con
            //string chuoi26 = "12345";
            //string chuoi27 = chuoi26.Substring(1, 2);
            //Console.WriteLine(chuoi26);
            //Console.WriteLine(chuoi27);

            ////tolower to upper
            //string chuoi28 = "HHAHDHAHAHAHADHAHhahadhagahHAHhhHAHAH";
            //Console.WriteLine(chuoi28);
            //chuoi28=chuoi28.ToLower();
            //Console.WriteLine(chuoi28);
            //chuoi28 = chuoi28.ToUpper();
            //Console.WriteLine(chuoi28);

            ////trim xóa khoảng trắng
            //string chuoi29 = "       123       ";
            //Console.WriteLine(chuoi29);
            //chuoi29=chuoi29.Trim();
            //Console.WriteLine(chuoi29);

            //// trim xóa khoảng trắng cuối
            //string chuoi30 = "       123       ";
            //Console.WriteLine(chuoi30);
            //chuoi30=chuoi30.TrimEnd();
            //Console.WriteLine(chuoi30);

            //// trim xóa khoảng trắng đầu
            //string chuoi31 = "       123       ";
            //Console.WriteLine(chuoi31);
            //chuoi31 = chuoi31.TrimStart();
            //Console.WriteLine(chuoi31);

            //// split trả về mảng
            //string chuoi32 = @"D:\dowload\public\nguyennhoanhthai";
            //string[] lst = chuoi32.Split('\\');
            //Console.WriteLine(lst[0]);
            //Console.WriteLine(lst[1]);
            //Console.WriteLine(lst[2]);

            ////join string
            //string chuoi33=string.Join("++",lst);
            //Console.WriteLine(chuoi33);
            string str1 = "English = 78 Science = 83 Math = 68 History = 65";
            string[] str2 = str1.Split(' ');
            int tong = 0;
            int dem =0;
            foreach (string x in str2)
            {
                if (char.IsDigit(x[0]))
                {
                    Console.WriteLine(x);
                    dem += 1;
                    tong += int.Parse(x);
                }
            }
            Console.WriteLine("tong cac so trong chuoi "+tong);
            Console.WriteLine("trung binh cac so trong chuoi "+(tong/(float)dem));

        }
    }
}
