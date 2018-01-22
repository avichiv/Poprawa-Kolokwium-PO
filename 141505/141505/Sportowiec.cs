using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _141505
{
    abstract class Sportowiec
    {
        protected string imie;
        protected char klub;

        public Sportowiec(string imie, char klub)
        {
            this.imie = imie;
            this.klub = klub;
        }

        public abstract string Zawody(int rekord);



    }
}
