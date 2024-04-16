using System;
class HelloWorld {
  static void Main(string[] args) {
    try{
        Console.WriteLine("Enter first number:");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int b=Convert.ToInt32(Console.ReadLine());
        int res = a/b;
        Console.WriteLine(res);
    }
    catch(FormatException f)
    {
        Console.WriteLine("Check the format correctly.");
    }
    catch(DivideByZeroException d)
    {
        Console.WriteLine("Cannot divide by zero.");
    }
    catch(Exception e)
    {
        Console.WriteLine("Unexpected error");
    }
    finally
    {
        Console.WriteLine("Thanks for using this program.");
    }
  }
}