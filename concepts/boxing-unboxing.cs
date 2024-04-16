//boxing and unboxing
using System;
internal class HelloWorld {
  static void Main() {
      int num=1234;
      Object obj=num;
      num=100;
      int result=(int)obj;
      Console.WriteLine(result);
      Console.WriteLine(num);
      Console.WriteLine(obj);
      
  }

}