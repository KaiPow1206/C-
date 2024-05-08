namespace baitapstring1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int demSo = 0;int demThuong = 0;int demHoa = 0;int demSpace = 0;
            string chuoi = "Nguyễn NHo Anh thái sinh ngày 1206";
            char[] lst= chuoi.ToCharArray();
            foreach(char c in lst)
            {
                //Console.WriteLine(c);
                if (char.IsDigit(c))
                    demSo++;
                else if (char.IsLower(c))
                    demThuong++;
                else if (char.IsUpper(c))
                    demHoa++;
                else if (char.IsWhiteSpace(c))
                    demSpace++; 
            }
            Console.WriteLine("Chuỗi có {0} ký tự số",demSo);
            Console.WriteLine("Chuỗi có {0} ký thường", demThuong);
            Console.WriteLine("Chuỗi có {0} ký tự số", demHoa);
            Console.WriteLine("Chuỗi có {0} ký tự số", demSpace);
            Console.ReadLine();

        }
    }
}
