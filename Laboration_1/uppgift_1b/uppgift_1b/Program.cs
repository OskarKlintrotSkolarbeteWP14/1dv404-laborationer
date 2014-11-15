using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_1b
{
    class Program
    {
        static void Main(string[] args)
        {
            RaknaSiffror Rakna = new RaknaSiffror();

            Console.WriteLine("Antal nollor: " + Rakna.analysOfNumber()[0]);
            Console.WriteLine("Antal udda: " + Rakna.analysOfNumber()[1]);
            Console.WriteLine("Antal jämna: " + Rakna.analysOfNumber()[2]);          
        }
    }
}
