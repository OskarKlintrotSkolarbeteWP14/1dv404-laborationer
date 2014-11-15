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

        public string Input { get; set; }
    
        public int[] analysOfNumber() {
            int[] returnValue = new int[3];

            //Number of zeros
            int oldString = Input.Length;
            int newString = oldString - Input.Replace("0", "").Length;

            returnValue[0] = newString;

            //Number of odd and even
            char[] numberArrayChar = Input.ToCharArray();
            int[] numberArrayInt = new int[Input.Length];
            int oldArray = Input.Length;
            string oddNumber = "0";
            string evenNumber = "0";

            for (int i = 0; i < numberArrayChar.Length; i++)
            {
                numberArrayInt[i] = int.Parse(numberArrayChar[i].ToString());
                if (numberArrayInt[i] != 0)
                {
                    //Is it odd?
                    if (numberArrayInt[i] % 2 != 0)
                    {
                        oddNumber = String.Format(oddNumber + "1");
                    }
                    //Is it even?
                    if (numberArrayInt[i] % 2 == 0)
                    {
                        evenNumber = String.Format(evenNumber + "1");
                    } 
                }
            }

            evenNumber = evenNumber.Replace("0", "");
            oddNumber = oddNumber.Replace("0", "");

            returnValue[1] = oddNumber.Length;
            returnValue[2] = evenNumber.Length;

            return returnValue;
            
        }
        //public int NumberOfZero()
        //{
        //    int oldString = Input.Length;
        //    int newString = oldString - Input.Replace("0", "").Length;

        //    return newString;
        //}

        //public int NumberOfOdd()
        //{
        //    char[] numberArrayChar = Input.ToCharArray();
        //    int[] numberArrayInt = new int[Input.Length];
        //    int oldArray = Input.Length;
        //    string newNumber = "0";

        //    for (int i = 0; i < numberArrayChar.Length; i++)
        //    {
        //        numberArrayInt[i] = int.Parse(numberArrayChar[i].ToString());
        //        if (numberArrayInt[i] % 2 != 0 && numberArrayInt[i] != 0)
        //        {
        //            newNumber = String.Format(newNumber + "1");
        //        }
        //    }

        //    newNumber = newNumber.Replace("0", "");

        //    return newNumber.Length;
        //}

        //public int NumberOfEven()
        //{
        //    char[] numberArrayChar = Input.ToCharArray();
        //    int[] numberArrayInt = new int[Input.Length];
        //    int oldArray = Input.Length;
        //    string newNumber = "0";

        //    for (int i = 0; i < numberArrayChar.Length; i++)
        //    {
        //        numberArrayInt[i] = int.Parse(numberArrayChar[i].ToString());
        //        if (numberArrayInt[i] % 2 == 0 && numberArrayInt[i] != 0)
        //        {
        //            newNumber = String.Format(newNumber + "1");
        //        }
        //    }

        //    newNumber = newNumber.Replace("0", "");

        //    return newNumber.Length;
        //}

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
