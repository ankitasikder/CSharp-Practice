//call by ref effect for integer
using System;
internal class HelloWorld {
  static void Main() {
      int num1=4;
      int num2=5;
      Console.WriteLine("Original value of num1: "+num1);
      Console.WriteLine("Original value of num2: "+num2);
      Reset(ref num1,ref num2);
      Console.WriteLine("Final value of num1 is: "+num1);
      Console.WriteLine("Final value of num2 is: "+num2);
      Console.ReadLine();
      
  }
  private static void Reset(ref int n1,ref int n2)
  {
      n1=0;
      n2=0;
      Console.WriteLine("Inside reset function value of num1 is: "+n1);
      Console.WriteLine("Inside reset function value of num2 is: "+n2);
  }
}