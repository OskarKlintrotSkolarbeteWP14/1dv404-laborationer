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

            while (true)
            {
                try
                {
                    Console.WriteLine("Mata in ett heltal: ");
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Felaktig inmatning!");
                }
                
            }
            return number;
        }
    }
}
