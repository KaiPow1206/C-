namespace tinhso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int CD, CR;
            Console.WriteLine("nhap vao chieu dai hcn: ");
            CD= int.Parse(Console.ReadLine());
            Console.WriteLine("nhap vao chieu rong hcn: ");
            CR= int.Parse(Console.ReadLine());
            int chuvi = (CD + CR) * 2;
            int dientich= CD * CR;
            Console.WriteLine("");
            Console.WriteLine("dien tich cua hcn "+ dientich);
            Console.WriteLine("chu vi cua hcn "+chuvi);*/
            float doF;
            Console.WriteLine("Nhap vao do F: ");
            doF = float.Parse(Console.ReadLine());
            float doC = (doF - 32) * 5 / 9; // Corrected formula
            Console.WriteLine("Do C duoc doi dua tren do F: " + doC);
        }
    }
}
