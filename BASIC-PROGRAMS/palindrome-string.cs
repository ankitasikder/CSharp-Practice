using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Program
{
  private static bool Palindrome(string n)
  {
     String s=n.ToLower();
     char[] chars = s.ToCharArray();
     Array.Reverse(chars);
     String rev= new String(chars);
     if(rev==s)
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
    Console.WriteLine("Enter the string: ");
    string s = Console.ReadLine();
    
    if(Palindrome(s))
    {
        Console.WriteLine("Palindrome String.");
    }
    else
    {
        Console.WriteLine("Not palindrome.");
    }
   }
    
}
    




