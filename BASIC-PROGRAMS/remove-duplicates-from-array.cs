//remove duplicate elements from an array
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void UniqueElements(int[] arr)
    {
      HashSet<int> hs = new HashSet<int>(arr);
      int[] res =hs.ToArray();
      foreach(int e in res)
      {
        Console.Write(e+" ");
      }

    }

    static void Main()
    {
        int[] arr = { 1,1,12,22,22,23,38,31,3 };
        UniqueElements(arr);
    }
}
