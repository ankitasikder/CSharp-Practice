using System;
  internal class Dog{
      public static int age;
      public static void play()
      {
          Console.WriteLine("I am a good dog.");
      }
  }
  public class Program{
     static void Main() {
      Dog.age=5;
      Console.WriteLine(Dog.age);
      Dog.play();
  } 
 }
  
