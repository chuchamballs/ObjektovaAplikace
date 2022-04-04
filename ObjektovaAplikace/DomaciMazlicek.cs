using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektovaAplikace
{
    internal class DomaciMazlicek
    {
        private int _pocetNohou = 4;

        public string Jmeno { get; set; }
        public int Vek { get; set; }
        public string Zvire { get; set; }
        public bool StaleZije { get; set; }

        public DomaciMazlicek(string parJmeno, int parVek, string parZvire, bool parZije)
        {
            Jmeno = parJmeno;
            Vek = parVek;
            Zvire = parZvire;
            StaleZije = parZije;
            Console.WriteLine($"{Jmeno}, {Vek}, {Zvire}, {StaleZije}");
            if(StaleZije == true)
            {
                Console.WriteLine("naživu :)");
            }
            else if (StaleZije == false)
            {
                Console.WriteLine("po smrti :(");
            }
        }
    }
}

