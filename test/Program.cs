namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap kich thuoc mang:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu:");
                int a = Convert.ToInt32(Console.ReadLine());
                list.Add(a);
            }
            foreach (int i in list)
            {

                Console.WriteLine("Mang vua nhap:" + i);
            }
            int dem = 0;
                foreach (int i in list)
                {
                    if (list[i] == list[i])
                        dem += 1;
                    Console.WriteLine(dem);
                }
        }
    }
}
