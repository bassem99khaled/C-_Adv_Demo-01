sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_Demo_01
{
    internal class EvenNumbers
    {



        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }

        public static void PrintList(List<int> list)
        {
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }


    }
}