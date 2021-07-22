using System;
using System.Collections.Generic;
namespace _34.SortingAlgorithms
{
    class Program
    { 
        static void Main(string[] args)
        {
            List<int> arr = new List<int>{ 1, 14, 15, 647, 465, 34, 43, 87, 96, 75};
            
            BubbleSort<int> bubbleSort = new BubbleSort<int>();
            DirectSelection<int> directSelection = new DirectSelection<int>();
            InsertSort<int> insertSort = new InsertSort<int>();
            
            Console.WriteLine("Bubble Sort:");
            bubbleSort.Sort(arr);
            foreach(int sort in arr)
            {
                Console.WriteLine(sort);
            }
            Console.WriteLine("---------------------------");


            Console.WriteLine("Direct Sort:");
            directSelection.Sort(arr);
            foreach (int sort in arr)
            {
                Console.WriteLine(sort);
            }
            Console.WriteLine("---------------------------");


            Console.WriteLine("Insert Sort:");
            insertSort.Sort(arr);
            foreach (int sort in arr)
            {
                Console.WriteLine(sort);
            }
            Console.WriteLine("---------------------------");
        }
    }
}
