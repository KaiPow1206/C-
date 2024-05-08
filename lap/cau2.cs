using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap
{
    internal class cau2
    {
        public static void Checkageuser(int age)
        {
            if(age <11 ) 
            {
                Console.WriteLine("child");
            }
            else if (age <18)
            {
                Console.WriteLine("teenager");
            }
            else if(age<50)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("old peson");
            }    
        }
    }
}
