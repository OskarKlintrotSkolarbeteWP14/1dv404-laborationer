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
            int resultat = SortNumber(10);
            Console.WriteLine("\nNäst största talet: " + resultat);
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

        private static int SortNumber(int numberOfInputs)
        {
            int biggestNumber = 0;
            int secondBiggestNumber = 0;

            for (int i = 1; i <= numberOfInputs; i++)
            {
                int compare = ReadInput(i);

                if (i == 1)
                {
                    biggestNumber = compare;
                }
                else if (compare > biggestNumber)
                {
                    secondBiggestNumber = biggestNumber;
                    biggestNumber = compare;
                }
                else if (compare > secondBiggestNumber)
                {
                    secondBiggestNumber = compare;
                }
            }

            return secondBiggestNumber;
        }
    }
}
