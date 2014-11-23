using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Fraction temp = new Fraction(1, 2);

                if (temp.isNegativ())
                {
                    Console.WriteLine("Negativ!");
                } 
            } while (IsContinuing());
        }
        #region Methods
        private static bool IsContinuing()
        {
            Console.WriteLine(Strings.continuePrompt);
            ConsoleKeyInfo esc;
            esc = Console.ReadKey();
            Console.Clear();
            return esc.Key != ConsoleKey.Escape;
        }
        #endregion
    }
}
