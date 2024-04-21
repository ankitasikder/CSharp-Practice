using System;
using System.Collections.Generic;
using System.Collections;
class Program
{
  static void Main()
  {
    int[] ar = new int[]{1,5,8,22,23,14,38};
    int x = 14;
    List<int> lis = new List<int>(ar);
    if(lis.Contains(x)==true)
    {
      Console.WriteLine("Found the value.");
    }
    else
    {
      Console.WriteLine("Not Found");
    }

  }
}