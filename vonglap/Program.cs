using System;
using System.Text;

namespace vonglap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;
            double giaithua = 1; // Sử dụng kiểu double cho giai thừa để tránh mất mát chính xác
            double tong = 0; // Sử dụng kiểu double cho tổng để lưu trữ giá trị số thực
            Console.WriteLine("Nhập vào số nguyên:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                giaithua *= i;
                tong += 1.0 / giaithua; // Sử dụng 1.0 để biến số 1 thành số thực, để kết quả phép chia trả về số thực
            }
            Console.WriteLine("Tổng của e: " + tong);
        }
    }
}
