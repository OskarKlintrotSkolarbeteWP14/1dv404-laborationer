using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaA
{
    class Program
    {
        static void Main(string[] args)
        {
            string RaknaAString;
            int storaA;
            int smaa;

            Console.Write("Mata in en textrad: ");
            RaknaAString = Console.ReadLine();

            storaA = Uppercase(RaknaAString);
            smaa = Lowercase(RaknaAString);

            Console.WriteLine("Antal a: " + smaa);
            Console.WriteLine("Antal A: " + storaA);
        }

        #region Methods
        private static int Uppercase(string RaknaA)
        {
            int oldString = RaknaA.Length;
            int newString = oldString - RaknaA.Replace("A", "").Length;

            return newString;
        }

        private static int Lowercase(string RaknaA)
        {
            int oldString = RaknaA.Length;
            int newString = oldString - RaknaA.Replace("a", "").Length;

            return newString;
        }
        #endregion
    }
}
