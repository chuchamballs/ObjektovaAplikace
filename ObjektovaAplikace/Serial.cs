using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektovaAplikace
{
    internal class Serial
    {
        public string Reziser { get; set; }
        public int PocetEpizod { get; set; }
        public string Herec { get; set; }
        public int DelkaSerialu { get; set; }

        public Serial(string parReziser, int parPocetEzpizod, string parHerec, int parDelkaSerialu)
        {
            Reziser = parReziser;
            PocetEpizod = parPocetEzpizod;
            Herec = parHerec;
            DelkaSerialu = parDelkaSerialu;
            Console.WriteLine($"{Reziser}, {PocetEpizod}, {Herec}, {DelkaSerialu}");
            
        }
    }
}
