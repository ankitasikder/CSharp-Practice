using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  private static bool IsPrime(int n)
  {
    for(int i=2;i<n/2;i++)
    {
      if(n%i==0)
      {
        return false;
      }
    }
    return true;
  }
  public static void Main()
  {
    Console.WriteLine("Enter lower and upper limit: ");
    int low = Convert.ToInt32(Console.ReadLine());
    int up = Convert.ToInt32(Console.ReadLine());
    for(int i=low;i<up;i++)
    {
        if(IsPrime(i))
        {
           Console.WriteLine(i+" ");
        }
    }
    
  }

  
}
