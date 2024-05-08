namespace diemtrungbinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("nhap vao diem kiem tra:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao diem giua ki: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao diem cuoi ki: ");
            c = int.Parse(Console.ReadLine());
            int diemtrb = (a + b + c) / 3;
            if (diemtrb >= 8)
                Console.WriteLine("diem A");
            else if (diemtrb >= 7 && diemtrb < 8)
                Console.WriteLine("diem B");
            else if (diemtrb >= 5 && diemtrb < 7)
                Console.WriteLine("diem C");
            else
                Console.WriteLine("diem D");
        }
    }
}
