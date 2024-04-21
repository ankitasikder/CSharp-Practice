using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
  private static bool Armstrong(int n)
  {
    int d=n,rem=0,sum=0;
    for(;n!=0;n=n/10)
    {
      rem=n%10;
      sum+=(rem*rem*rem)+sum;
    }
    if(sum==d)
    {
      return true;
    }
    return false;
  }
  public static void Main()
  {
      Console.WriteLine("Armstrong Number:");
      Console.WriteLine("Enter the lower limit and upper limit: ");
      int low= Convert.ToInt32(Console.ReadLine());
      int up= Convert.ToInt32(Console.ReadLine());
      for(int i=low;i<up;i++)
      {
          if(Armstrong(i))
          {
            Console.Write(i+" ");
          }
      }
  }

  
}
