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

        public int Input { get; set; }
    
        public int NumberOfZero()
        {
            string numberString = Input.ToString();
            return Input;
        }

        public int NumberOfOdd()
        {
            throw new System.NotImplementedException();
        }

        public int NumberOfEven()
        {
            throw new System.NotImplementedException();
        }

        public int ReadInput()
        {
            int number;
            Console.WriteLine("Mata in ett heltal: ");
            while (!(int.TryParse(Console.ReadLine(), out number)))
            {
                Console.WriteLine("Felaktig inmatning, försök igen: ");   
            }
            return number;
        }
    }
}
