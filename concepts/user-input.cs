
using System;
class HelloWorld {
  static void Main(String[] args) {
    Console.WriteLine("What is your age?");
    int res=SayDetails();
    Console.WriteLine("The age is "+res);
    Console.ReadLine();
    
    
  }
  static int SayDetails()
  {
      int num= Convert.ToInt32(Console.ReadLine());
      return num;
  }
}