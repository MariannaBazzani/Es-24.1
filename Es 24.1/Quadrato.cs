using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_24._1
{
    internal class Quadrato
    {
        public float Lato { get; set; }
        public void CalcolaSuperfice() {
            Console.WriteLine("La superfice e': " + Lato*Lato);
        }
    }
}
