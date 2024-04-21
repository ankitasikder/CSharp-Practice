using System;
using System.Linq;

class Program
{
    static void PrintSecondLargest(int[] arr)
    {
        Array.Sort(arr);
        Array.Reverse(arr);

        int n = arr.Length;
        int largest = arr[0];
        int secondLargest = -1;
        for (int i = 1; i < n; i++)
        {
            if (arr[i] != largest)
            {
                secondLargest = arr[i];
                break;
            }
        }

        if (secondLargest != -1)
            Console.WriteLine($"The second largest element is {secondLargest}");
        else
            Console.WriteLine("There is no second largest element");
    }

    static void Main()
    {
        int[] arr = { 12, 35, 1, 10, 34, 1 };
        PrintSecondLargest(arr);
    }
}
