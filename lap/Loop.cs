using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap
{
    internal class Loop
    {
        public static void vonglap()
        {
            string userIsDone= string.Empty;
            while (!"yes".Equals(userIsDone.ToLower()))
            {
                Console.WriteLine("In while loop");
                Console.WriteLine("Are u done [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }
    }
}
