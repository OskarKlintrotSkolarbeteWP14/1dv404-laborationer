using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uppgift_1b
{
    public class RaknaSiffror
    {
        public RaknaSiffror()
        {
            Input = ReadInput();
        }

        public int Zero { get; set; }

        public int Odd { get; set; }

        public int Even { get; set; }

        public string Input { get; set; }
    
        public int NumberOfZero()
        {
            int oldString = Input.Length;
            int newString = oldString - Input.Replace("0", "").Length;

            return newString;
        }

        public int NumberOfOdd()
        {
            char[] numberArrayChar = Input.ToCharArray();
            int[] numberArrayInt = new int[Input.Length];
            int oldArray = Input.Length;
            string newNumber = "0";

            for (int i = 0; i < numberArrayChar.Length; i++)
            {
                numberArrayInt[i] = int.Parse(numberArrayChar[i].ToString());
                if (numberArrayInt[i] % 2 != 0 && numberArrayInt[i] != 0)
                {
                    newNumber = String.Format(newNumber + "1");
                }
            }

            newNumber = newNumber.Replace("0", "");

            return newNumber.Length;
        }

        public int NumberOfEven()
        {
            char[] numberArrayChar = Input.ToCharArray();
            int[] numberArrayInt = new int[Input.Length];
            int oldArray = Input.Length;
            string newNumber = "0";

            for (int i = 0; i < numberArrayChar.Length; i++)
            {
                numberArrayInt[i] = int.Parse(numberArrayChar[i].ToString());
                if (numberArrayInt[i] % 2 == 0 && numberArrayInt[i] != 0)
                {
                    newNumber = String.Format(newNumber + "1");
                }
            }

            newNumber = newNumber.Replace("0", "");

            return newNumber.Length;
        }

        public string ReadInput()
        {
            string number;
            int test;

            Console.WriteLine("Mata in ett heltal: ");
            while (true)
            {
                number = Console.ReadLine();
                if (!(int.TryParse(number, out test)))
                {
                    Console.WriteLine("Felaktig inmatning, försök igen: ");
                    continue;
                }
                break;
            }

            return number;
        }
    }
}
