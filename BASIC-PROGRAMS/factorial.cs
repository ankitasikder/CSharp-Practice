using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
  private static int Factorial(int n)
  {
    int res=1;
     for(int i=1;i<=n;i++)
     {
        res=res*i;
     }
     return res;
  }
  public static void Main()
  {
      Console.WriteLine("Enter the number: ");
      int n= Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Factorial is: "+Factorial(n));
      
  }

  
}
