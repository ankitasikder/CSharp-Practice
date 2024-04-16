
using System;
class HelloWorld {
  static void Main(String[] args) {
    int a=5;
    int b=4;
    int res=Add(a,b);
    Console.WriteLine(res);
    Console.ReadLine();
  }
  static int Add(int a, int b)
  {
      return a+b;
  }
  static double Add(double c, double d)
  {
      return c+d;
  }
}