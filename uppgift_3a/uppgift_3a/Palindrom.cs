using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_3a
{
    class Palindrom
    {
        static void Main(string[] args)
        {
            do
            {
                string inputFromPrompt = Input();

                string removedWhiteSpace = RemoveWhitespace(inputFromPrompt);

                char[] originalArray = stringToCharArray(removedWhiteSpace.ToLower());

                char[] reversedArray = reverseArray(originalArray);

                if (IsCharArrayPalindrom(originalArray, reversedArray))
                {
                    Console.WriteLine(Strings.palindromPrompt);
                }
                else
                {
                    Console.WriteLine(Strings.notPalindromPrompt);
                }
            } while (IsContinuing());
            
        }

        #region Method
        private static bool IsContinuing()
        {
            Console.WriteLine(Strings.continuePrompt);
            ConsoleKeyInfo esc;
            esc = Console.ReadKey();
            Console.Clear();
            return esc.Key != ConsoleKey.Escape;
        }
        private static char[] copyArray(char[] originalArray, char[] copyArray)
        {
            for (int i = 0; i < originalArray.Length; i++)
            {
                copyArray[i] = originalArray[i];
            }

            return copyArray;
        }

        private static bool IsCharArrayPalindrom(char[] originalArray, char[] reversedArray)
        {
            bool testPalindrom = false;

            for (int i = 0; i < originalArray.Length; i++)
            {
                if (originalArray[i] == reversedArray[i])
                {
                    testPalindrom = true;
                }
                else
                {
                    testPalindrom = false;
                }
            }

            if (testPalindrom)
            {
                return true;
            }

            return false;
        }

        private static char[] reverseArray(char[] arrayToBeReveresed)
        {
            char[] temp = new char[arrayToBeReveresed.Length];

            copyArray(arrayToBeReveresed, temp);

            Array.Reverse(temp);

            return temp;
        }

        private static char[] stringToCharArray(string stringToCharArray)
        {
            char[] tempOriginal = stringToCharArray.ToCharArray();

            return tempOriginal;
        }

        private static string RemoveWhitespace(string removeWhitespaceFromString)
        {
            return removeWhitespaceFromString.Replace(" ", "");
        }

        static private string Input()
        {
            Console.WriteLine(Strings.inputPrompt);
            return Console.ReadLine();
        }
        #endregion
    }
}
