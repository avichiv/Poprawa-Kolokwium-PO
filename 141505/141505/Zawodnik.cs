using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _141505
{
    class Zawodnik : IOlimpiada
    {
        private int czas;

        public int Miejsce(string miejsce)
        {
            return 0;
        }

        public bool Medal()
        {
            if (czas % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
