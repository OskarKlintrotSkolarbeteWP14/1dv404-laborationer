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

            Console.WriteLine("Antal nollor: " + Rakna.analysNumber("Zero"));
            Console.WriteLine("Antal udda: " + Rakna.analysNumber("Odd"));
            Console.WriteLine("Antal jämna: " + Rakna.analysNumber("Even"));          
        }
    }
}
