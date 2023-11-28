using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_24._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrato quadrato = new Quadrato();
            Console.WriteLine("Inserisci il lato del quadrato: ");
            string line = Console.ReadLine();
            while (!float.TryParse(line, out float l)) 
            {
                Console.WriteLine("Valore nullo, inserire nuovamente: ");
                line = Console.ReadLine();
            }
            quadrato.Lato = float.Parse(line);
            quadrato.CalcolaSuperfice();
        }
    }
}

