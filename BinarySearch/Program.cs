using System;

namespace BinarySearch
{
    public class Program
    {
        public static int binarySearch(int[] arr, int l,
                            int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid] == x)
                    return mid;

                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                return binarySearch(arr, mid + 1, r, x);
            }
            return -1;
        }

        public static void Main()
        {
            //Binary search 
            //Step 1: Arrange in Sorted order
            //Step 2: Divide the array into two
            //Step 3: Continue the same until it is found
            int[] arr = { 1, 2, 3, 4, 5 };
            int n = arr.Length;
            int x = 3;

            //Array index starts with 0
            int result = binarySearch(arr, 0, n - 1, x);

            if (result == -1)
                Console.WriteLine("Element not present");            
            else
                Console.WriteLine("Element found at index "
                                  + result);

            Console.ReadLine();
        }
    }
}
