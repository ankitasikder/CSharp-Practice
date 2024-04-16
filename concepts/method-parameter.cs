
using System;
class HelloWorld {
  static void Main(String[] args) {
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    Console.WriteLine("What is your age?");
    int age = Convert.ToInt32(Console.ReadLine());
    SayDetails(name,age);
    
    
  }
  static void SayDetails(string nm,int ag)
  {
      Console.WriteLine("Your name is "+nm+" and your age is "+ag);
  }
}