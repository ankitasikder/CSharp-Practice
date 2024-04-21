using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Program
{
  private static bool Palindrome(int n)
  {
     int d=n;
     int rem=0,rev=0;
     for(;n!=0;n=n/10)
     {
         rem=n%10;
         rev=(rev*10)+rem;
     }
     if(rev==d)
     {
         return true;
     }
     else
     {
         return false;
     }
  }
  static void Main(string[] args)
  {
    Console.WriteLine("Enter the number: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    if(Palindrome(n))
    {
        Console.WriteLine("Palindrome number.");
    }
    else
    {
        Console.WriteLine("Not palindrome.");
    }
   }
    
}
    




