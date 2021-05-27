using System;

namespace BubbleSort
{
    public class BubbleSortExercise
    {
        public static int[] BubbleSort(int[] array)
        {
            int temp;
            for (int j = 0; j <= array.Length - 2; j++) 
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            //Bubble sort     
            //Step 1: Checks the adjacent elements and swap
            //Note : The algorithm needs one whole pass without any swap to know it is sorted.

            int[] arr = { 91, 90, 34, 9, 4 };

            var sortedArray = BubbleSort(arr);
            
            Console.WriteLine("Sorted:");
            foreach (int p in sortedArray)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}
