using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class HocSinh
    {
        //auto -implemented properties
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        // phương thức to string
        public override string ToString()
        {
            return this.Name+ "\t" + this.Email+ "\t" + this.Phone;
        }
    }
}
