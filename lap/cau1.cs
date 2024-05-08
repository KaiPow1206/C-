using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap
{
    internal class cau1
    {
       public static void Checkusername(string username)
        {
            if ("dev".Equals(username))
            {
                Console.WriteLine("dang nhap thanh cong");
            }
            else
            {
                Console.WriteLine("dang nhap khong thanh cong");
            }
        }
    }
}
