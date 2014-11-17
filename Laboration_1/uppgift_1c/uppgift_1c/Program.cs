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
            int test1 = ReadInput(1);
            int test2 = ReadInput(2);
            int test3 = ReadInput(3);
            
            Console.WriteLine("Test 1: " + test1);
            Console.WriteLine("Test 2: " + test2);
            Console.WriteLine("Test 3: " + test3);
        }

        private static int ReadInput(int number)
        {
            string stringNumber;
            int intNumber;

            Console.WriteLine("Mata in ett heltal " + number + ": ");
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
