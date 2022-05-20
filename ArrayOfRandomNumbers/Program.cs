using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] evenТumbers;
            string[] oddТumbers;           
            string[] alphabet = new string[26] {"a","b","c","d","e","f","g","h","i","j","k","l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};
            int[] originalArray = CreateOriginalArray();
            Console.Write("Source array:  ");
            foreach (int el in originalArray)
                Console.Write(" "+el);
            Console.WriteLine();
            evenТumbers = CreateIntermedArrayEven(originalArray); 
            oddТumbers = CreateIntermedArrayOdd(originalArray);
            Console.WriteLine();
            Console.WriteLine("     Divide into odd and even");
            Console.WriteLine();

            Console.WriteLine("Array of even numbers:");
            foreach (string evenT in evenТumbers) Console.Write(evenT + " ");
            Console.WriteLine();

            Console.WriteLine("Array of odd numbers:");
            foreach (string oddT in oddТumbers) Console.Write(oddT + " ");
            Console.WriteLine(); Console.WriteLine();

            Console.WriteLine("     Replacing numbers with letters");
            Console.WriteLine();

            int amountEven = ReplaceEvenNumbersWithLetters(evenТumbers, alphabet);             
            int amountOdd = ReplaceOddNumbersWithLetters(oddТumbers, alphabet);

            Console.WriteLine();
            Console.WriteLine("The array of even numbers has {0} uppercase letters, and the array of odd numbers has {1} uppercase letters", amountEven, amountOdd);
            Console.WriteLine();
            if (amountEven > amountOdd)
            {
                Console.WriteLine("Larger uppercase literal in array of even numbers");
            } else
            if (amountEven < amountOdd)
            {
                Console.WriteLine("Larger uppercase literal in array of odd numbers");
            }
                
              else Console.WriteLine("Both arrays have the same number of uppercase letters");
            Console.ReadKey();
        }
        
        public static int ReplaceOddNumbersWithLetters(string[] oddTumbers, string[] alphabet)
        {
            int amount = 0;
            string[] result = new string[oddTumbers.Length];
            for (int i = 0; i < oddTumbers.Length; i++)
            {
                int number = Convert.ToInt32(oddTumbers[i]);
                result[i] = alphabet[number - 1];
                if (result[i] == "a" || result[i] == "e" || result[i] == "i" || result[i] == "d" || result[i] == "h" || result[i] == "h")
                {
                    result[i] = (result[i].ToUpper());
                    amount++;
                }
            }
            Console.WriteLine("Array of odd numbers:");
            foreach (string oddL in result)
            {
                Console.Write(oddL + " ");
            }
            Console.WriteLine();
            return amount;
        }
        public static int ReplaceEvenNumbersWithLetters(string[] evenTumbers, string[] alphabet)
        {
            int amount=0;
            string[] result = new string[evenTumbers.Length]; 
            for (int i = 0; i < evenTumbers.Length; i++)
            {
                int number = Convert.ToInt32(evenTumbers[i]);
                result[i] = alphabet[number - 1];
                if (result[i] == "a" || result[i] == "e" || result[i] == "i" || result[i] == "d" || result[i] == "h" || result[i] == "h")
                {
                    result[i] = (result[i].ToUpper());
                    amount++;
                }                
            }
            Console.WriteLine("Array of even numbers:");
            foreach (string evenL in result)
            {
                Console.Write(evenL + " ");
            }
            Console.WriteLine();
            return amount;
        }
        public static string[] CreateIntermedArrayOdd(int[] originalArray)
        {
            string[] IntermedArrayOddТumbers = new string[0];
            for (int i = 0; i < originalArray.Length; i++)
            {
                string intermediate = Convert.ToString(originalArray[i]);
                if (originalArray[i] % 2 == 1)
                {
                    Array.Resize(ref IntermedArrayOddТumbers, IntermedArrayOddТumbers.Length + 1);
                    IntermedArrayOddТumbers[IntermedArrayOddТumbers.Length - 1] = intermediate;
                }
            }
            return IntermedArrayOddТumbers;
        }
        public static string[] CreateIntermedArrayEven(int[] originalArray)
         {
            string[] IntermedArrayEvenТumbers = new string[0];           
            for (int i = 0; i < originalArray.Length; i++)
            {
                string intermediate = Convert.ToString(originalArray[i]);

                if (originalArray[i] % 2 == 0)
                {
                    Array.Resize(ref IntermedArrayEvenТumbers, IntermedArrayEvenТumbers.Length + 1);
                    IntermedArrayEvenТumbers[IntermedArrayEvenТumbers.Length - 1] = intermediate;                    
                }
            }
            return IntermedArrayEvenТumbers;
         }
        public static int[] CreateOriginalArray()
        {
            int i;
            Console.Write("Enter the size of the array (for correct display, preferably no more than 30): ");
            int sizeArray = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[sizeArray];             
            Random rnd = new Random();
            for (i = 0; i < sizeArray; i++)
            {
                numbers[i] = rnd.Next(1,26);
            }
            return numbers;
        }        
    }
}
