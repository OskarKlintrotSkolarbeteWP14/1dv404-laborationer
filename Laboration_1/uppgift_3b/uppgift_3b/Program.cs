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
                Fraction temp2 = new Fraction(1, 4);
                Fraction mult = temp * temp2;
                Fraction sum = temp + temp2;

                Console.WriteLine(temp + " * " + temp2 + " = " + mult);
                Console.WriteLine(temp + " + " + temp2 + " = " + sum);
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
