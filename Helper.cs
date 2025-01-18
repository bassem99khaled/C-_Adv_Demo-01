using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_Demo_01
{
    internal static class Helper
    {

        public static void SWAP<T>(ref T X, ref T  Y) /*where T : struct*/
        {
            Console.WriteLine("===== SWAP ======");
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        public static void Print(string Name)
        {
            Console.WriteLine($"Hello {Name}!!");
        }

        // public static void SWAP(ref object X , ref object Y)
        // {
        //     Console.WriteLine("===== SWAP ======");
        //     object Temp = X;
        //     X = Y;
        //     Y=Temp;
        // }

        public static void SWAP(ref Point X, ref Point Y)
        {
            Console.WriteLine("===== SWAP ======");
            Point Temp = X;
            X = Y;
            Y = Temp;
        }
    }
}
