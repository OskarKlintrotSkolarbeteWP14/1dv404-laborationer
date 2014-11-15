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
            string numberString = Input.ToString();

            int oldString = numberString.Length;
            int newString = oldString - numberString.Replace("0", "").Length;

            return newString;
        }

        public int NumberOfOdd()
        {
            throw new System.NotImplementedException();
        }

        public int NumberOfEven()
        {
            throw new System.NotImplementedException();
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
