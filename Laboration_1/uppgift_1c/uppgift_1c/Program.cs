using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_1c
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = ReadInput();
            Console.WriteLine(test);
        }

        private static int ReadInput()
        {
            string stringNumber;
            int intNumber;

            Console.WriteLine("Mata in ett heltal: ");
            while (true)
            {
                stringNumber = Console.ReadLine();
                if (!(int.TryParse(stringNumber, out intNumber)))
                {
                    Console.WriteLine("Felaktig inmatning, försök igen: ");
                    continue;
                }
                break;
            }

            return intNumber;
        }
    }
}
