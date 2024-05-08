using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap
{
    internal class demtuoi()
    {
        public static void dem()
        {
        Console.OutputEncoding = Encoding.UTF8;
        A:label:
            var number = (new Random()).Next(1,7);
            Console.Write($"số của tui là: {number} ");
            switch(number)
            {
                case 1:
                    Console.Write("One");
                    break;
                case 2:
                    Console.Write("Two");
                    goto case 1;
                case 3:
                case 4:
                    Console.Write("Three or Four");
                    goto case 1;
                case 5:
                    System.Threading.Thread.Sleep(5000);
                    goto label;
                default:
                    Console.Write("Default");
                    break;
            }
        }
    }
}
