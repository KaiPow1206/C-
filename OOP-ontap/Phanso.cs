using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ontap
{
    public class Phanso
    {
        private int TS;
        private int MS;
        public int tu
        {
            get { return TS; }
            set { TS = value; }
        }

        public int mau
        {
            get { return MS; }
            set { MS=value; }
        }
        public Phanso(int tu, int mau)
        {
            TS = tu;
            if (mau != 0)
                MS = mau;
            else
                MS = 1;
        }

        public static Phanso operator +(Phanso a, Phanso b)
        {
            int tuMoi = a.tu * b.mau + b.tu * a.mau;
            int mauMoi = a.mau * b.mau;

            return new Phanso(tuMoi,mauMoi) ;
        }
        public static Phanso operator -(Phanso a, Phanso b)
        {
            int tuMoi = a.tu * b.mau - b.tu * a.mau;
            int mauMoi = a.mau * b.mau;

            return new Phanso(tuMoi, mauMoi);
        }

        public override string ToString()
        {
            return TS + "/" + MS;
        }

    }
}