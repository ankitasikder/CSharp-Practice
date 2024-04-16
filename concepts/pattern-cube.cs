
using System;
class HelloWorld {
  static void Main(string[] args) {
     Console.WriteLine("Enter the number to create cube:");
     int n = Convert.ToInt32(Console.ReadLine());
     for(int i=0;i<n;i++)
     {
         for(int j=0;j<n;j++)
         {
             Console.Write("*");
         }
         Console.WriteLine("");
     }
    
  }
}