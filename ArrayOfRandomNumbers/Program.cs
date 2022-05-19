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
            string[] evenТumbers = new string[0];
            string[] oddТumbers = new string[0];
            string intermediate;
           // int i1 = 0, i2 = 0;

            int[] originalArray = CreatingOriginalArray();
            Console.Write("Source array:  ");
            foreach (int el in originalArray)
                Console.Write(" "+el);

            for (int i=0; i<originalArray.Length; i++)
            {
                intermediate = Convert.ToString(originalArray[i]);
                                
                if (originalArray[i] % 2 == 0) 
                {
                    Array.Resize(ref evenТumbers, evenТumbers.Length + 1);
                    evenТumbers[evenТumbers.Length - 1] = intermediate;
                    //i1++;
                    //evenТumbers = AddEvenТumbers(evenТumbers, intermediate);
                } else                
                {
                    Array.Resize(ref oddТumbers, oddТumbers.Length + 1);
                    evenТumbers[oddТumbers.Length - 1] = intermediate;
                    //i2++;

                }
            }
            Console.WriteLine();
            Console.WriteLine("Array of even numbers:");
            foreach (string evenT in evenТumbers) Console.Write(evenT + " ");
            Console.WriteLine();
            Console.WriteLine("Array of odd numbers:");
            foreach (string oddT in oddТumbers) Console.Write(oddT + " ");
            Console.WriteLine();


            Console.ReadKey();
        }
       /*
        public static string[] AddEvenТumbers(string[] evenTumbers, string intermediate)
        {
            int i = evenTumbers.Length+1;
            Array.Resize(ref evenTumbers, i);
            
            evenTumbers[i] = intermediate;
            
            
            return evenTumbers;
        }*/
        public static int[] CreatingOriginalArray()
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
