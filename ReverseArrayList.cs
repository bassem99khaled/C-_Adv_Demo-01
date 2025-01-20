using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_Demo_01
{
    internal class ReverseArrayList
    {
        public static void ReverseInPlace(ArrayList arrayList)
        {
            int left = 0;
            int right = arrayList.Count - 1;

            while (left < right)
            {

                var temp = arrayList[left];
                arrayList[left] = arrayList[right];
                arrayList[right] = temp;


                left++;
                right--;
            }
        }

        public static void PrintArrayList(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}