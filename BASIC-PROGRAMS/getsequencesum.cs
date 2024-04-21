using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int GetSequenceSum(int i, int j, int k) {
        int sum = 0;

        // Calculate sum from i to j 
        for (int x = i; x <= j; x++) {
            sum += x;
        }

        // Calculate sum from j-1 down to k (including k)
        for (int x = j - 1; x >= k; x--) {
            sum += x;
        }

        return sum;
    }
  public static void Main()
  {
        int i = Convert.ToInt32(Console.ReadLine());
        int j = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());

        int result = GetSequenceSum(i, j, k);
        Console.WriteLine($"Sequence Sum: {result}");
  }

 
}
