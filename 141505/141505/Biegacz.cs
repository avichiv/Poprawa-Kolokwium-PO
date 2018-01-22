using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _141505
{
    class Biegacz : Sportowiec, IComparable
    {
        private int rekord;

        public Biegacz(string imie, char klub, int rekord)
            :base(imie,klub)
        {
            this.imie = imie;
            this.klub = klub;
            this.rekord = rekord;
        }
        
        public override string Zawody(int rekord)
        {
            return "Rekord: " + rekord;
        }

        public override string ToString()
        {
            return "Biegacz: " + imie + " klub: " + klub + " rekord: " + rekord;
        }

        public int CompareTo(object obj)
        {
            Biegacz n = (Biegacz)obj;
            return -rekord.CompareTo(n.rekord);
        }

    }
}
