namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("moi ban nhap nhap vao so");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            switch (n)
            { 
                case 0:
                    Console.WriteLine("khong");
                    break;
                case 1:
                    Console.WriteLine("mot");
                    break;
                case 2:
                    Console.WriteLine("hai");
                    break;
                case 3:
                    Console.WriteLine("ba");
                    break;
                case 4:
                    Console.WriteLine("bon");
                    break;
                case 5:
                    Console.WriteLine("nam");
                    break;
                case 6:
                    Console.WriteLine("sau");
                    break;
                case 7:
                    Console.WriteLine("bay");
                    break;
                case 8:
                    Console.WriteLine("tam");
                    break;
                case 9:
                    Console.WriteLine("chin");
                    break;
                default: Console.WriteLine("khong co cach doc");
                    break;
            }

        }
    }
}
