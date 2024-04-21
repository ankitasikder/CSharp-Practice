using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Program
{
  private static void Fibonacci(int n)
  {
    int a=0,b=1,c=0;
    Console.Write(a+" "+b+" ");
    for(int i=2;i<n;i++)
    {
      c=a+b;
      Console.Write(c+" ");
      a=b;
      b=c;
    }
  }
  static void Main(string[] args)
  {
    
    bool f = true;
    while(f)
    {
        Console.WriteLine("Enter the number for fibonacci series: ");
    int n = Convert.ToInt32(Console.ReadLine());
      if(n<2)
      {
        Console.WriteLine("Enter greater number.");
        
      }
      else{
        Fibonacci(n);
        f=false;
      }
    }
    
   }
  }
  



