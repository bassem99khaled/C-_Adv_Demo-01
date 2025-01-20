using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Adv_Demo_01
{
    internal static class Helper<T> where T : IComparable<T>

        // T must be Class or struct implementing rhw built-in InterFace "IComparable"
    {

      // Primary Constraint [ 0 ,1 ]
      // 1. Genral Primary Constraint
     //               class => T Must be Class
     //               struct => T Must be Struct
     //               notnull => T must be not nullable ( C# 8.0)
     //               default => 
     //               unmanged =>
     //               Enum => T must be Enum (C# 7.3)
     //
     //  2. Special Primary Constarint (User_Defined Class (Exception Sealed ))
     //        Point => T Must be point or another Class inherits from point

       ///  Secondary Constraint (inherFace Constraint ) [ 0 : M ]
       ///  <IComparable<T>
       /// T must be Class\ Struct Implementing ICompareable
       
       
       /// Parameterless Constructor Constraint [1 : 0 ]
       /// T must be DataType Having Accesable [non-private ] ParameterLess Constructor
       /// till C# 12.0 only one Constructor Constraint
       /// Cant use new () [ Constructor Constraint ] with struct [ Special primary Constraint]
       

        public static void BubbleSort(int[] Arr)
        {
            if (Arr is null || Arr.Length == 0)
                return;

            for (int i = 0; i < Arr.Length /*6*/; i++) // i =0
            {
                for (int j = 0; j < Arr.Length -1 - i /*5*/; j++)  // j = 0
                {
                    if (Arr[j].CompareTo( Arr[j + 1] ) == 1)
                        Helper<int>.SWAP(ref Arr[j], ref Arr[j + 1]);
                }
            }
        }
        public static void BubbleSort(int[] Arr, IComparable<T> comparer)
        {
            if (Arr is null || Arr.Length == 0)
                return;

            for (int i = 0; i < Arr.Length ; i++) 
            {
                for (int j = 0; j < Arr.Length - 1 - i ; j++)
                {
                    if (comparer.Compare(Arr[i], Arr[j + 1]) == 1)
                        SWAP(ref Arr[i], ref Arr[j + 1]);
                }
            }
        }



        public static int LinarSearch(T[] Arr, int Value)
        {
            if (Arr?.Length > 0 && Value is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
            if(Value.Equals(Arr[i]))
                       return i;
                }
            }
            return -1;
        }

        public static int LinarSearch(T[] Arr, T value , IEqualityComparer<T> equalityComparer)
        {
            if (Arr?.Length > 0 && value is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    //if (Value.Equals(Arr[i]))
                    if (equalityComparer.Equals(value, Arr[i]))    
                    
                    return i;
                }
            }
            return -1;
        }

        //    public static int LinarSearch(T[] Arr, T value , Func<T, T , bool> equals)
        //        if (Arr?.Length > 0 && value is not null)
        //        {
        //            for (int i = 0; i < Arr.Length; i++)
        //            {
        //                //if (Value.Equals(Arr[i]))
        //               // if (equalityComparer.Equals(value, Arr[i]))
        //               if(e quals(Value , Arr[i]))
        //                    return i;
        //            }
        //        }
        //        return -1;
        //    }
        public static void SWAP(ref T X, ref T  Y) /*where T : struct*/
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
