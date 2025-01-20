using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C__Adv_Demo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1.	The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets.
            // How we can optimise the Bubble Sort algorithm 
            // And implement the code of this optimised bubble sort algorithm

            // we can make a simple improvement by detecting whether the list is already sorted.
            // This can significantly reduce the number of passes if the array is already sorted or becomes sorted early during the algorithm's execution.



            // int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            //
            // BubbleSort(arr);
            //
            // Console.WriteLine("Sorted Array:");
            // PrintArray(arr);

            #endregion

            #region 2.	create a generic Range<T> class that represents a range of values from a minimum value to a maximum value.
            // The range should support basic operations such as checking if a value is within the range and determining the length of the range.
            //Requirements:
            // 1.Create a generic class named Range<T> where T represents the type of values.
            // 2.	Implement a constructor that takes the minimum and maximum values to define the range.
            // 3.	Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
            // 4.	Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
            // 5.	Note: You can assume that the type T used in the Range<T> class implements the IComparable


            // 
            // var intRange = new Range<int>(10, 20);
            // Console.WriteLine(intRange);
            // Console.WriteLine($"Is 15 in range? {intRange.IsInRange(15)}");
            // Console.WriteLine($"Is 25 in range? {intRange.IsInRange(25)}");
            // Console.WriteLine($"Length of range: {intRange.Length()}");
            //
            // Console.WriteLine();
            //
            // 
            // var doubleRange = new Range<double>(1.5, 5.7);
            // Console.WriteLine(doubleRange);
            // Console.WriteLine($"Is 3.4 in range? {doubleRange.IsInRange(3.4)}");
            // Console.WriteLine($"Is 6.8 in range? {doubleRange.IsInRange(6.8)}");
            // Console.WriteLine($"Length of range: {doubleRange.Length()}");
            //
            // Console.WriteLine();
            #endregion

            #region 3.	You are given an ArrayList containing a sequence of elements. try to reverse the order of elements 
            //in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. 
            //Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.

            //
            //   ArrayList arrayList = new ArrayList { 1, 2, 3, 4, 5, 6 };
            //
            //   ReverseInPlace(arrayList);
            //
            //   Console.WriteLine("Reversed ArrayList:");
            //   PrintArrayList(arrayList);
            //



            #endregion

            #region 4.	You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.



            //
            // List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };   
            //
            // List<int> evenNumbers = GetEvenNumbers(numbers);
            //
            // Console.WriteLine("Even Numbers:");
            // PrintList(evenNumbers);
        }  //




        #endregion

        #region  5.	implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
        //Requirements:
        //  1.	Create a generic class named FixedSizeList<T>.
        //  2.	Implement a constructor that takes the fixed capacity of the list as a
        //  parameter.
        //  3.Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
        //  4.Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.





        //
        //   try
        //   {
        //       
        //       var list = new FixedSizeList<int>(3);
        //
        //    
        //       list.Add(10);
        //       list.Add(20);
        //       list.Add(30);
        //
        //     
        //       Console.WriteLine(list);
        //
        //    
        //       Console.WriteLine($"Element at index 1: {list.Get(1)}");
        //
        //      
        //   }
        //
        //   catch (Exception ex)
        //   {
        //       Console.WriteLine($"Error: {ex.Message}");
        //   }


        #endregion


        #region  6.	Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1. Hint you can use dictionary






        //   
        //       string input = "Bassem"; 
        //       int index = FindFirstNonRepeatedCharacterIndex(input);
        //
        //       if (index != -1)
        //       {
        //           Console.WriteLine($"The first non-repeated character is '{input[index]}' at index {index}.");
        //       }
        //       else
        //       {
        //           Console.WriteLine("There is no non-repeated character in the string.");
        //       }


        #endregion






    }


}
}
