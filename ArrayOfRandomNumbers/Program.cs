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
            
            int[] originalArray = CreateOriginalArray();
            Console.Write("Source array:  ");
            foreach (int el in originalArray)
                Console.Write(" "+el);
            evenТumbers = CreateIntermedArrayEven(originalArray); 
            oddТumbers = CreateIntermedArrayOdd(originalArray);
           
            Console.WriteLine();
            Console.WriteLine("Array of even numbers:");
            foreach (string evenT in evenТumbers) Console.Write(evenT + " ");
            Console.WriteLine();
            Console.WriteLine("Array of odd numbers:");
            foreach (string oddT in oddТumbers) Console.Write(oddT + " ");
            Console.WriteLine();

            Console.ReadKey();
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
