using System;
namespace ExtensionMethods
{
    public class OldClass
    {
        public int x = 100;
        public void Test1()
        {
            Console.WriteLine("Method one: " + this.x);
        }
        public void Test2()
        {
            Console.WriteLine("Method two: " + this.x);
        }
    }
    public static class NewClass
    {
        public static void Test3(this OldClass O)
        {
            Console.WriteLine("Method Three");
        }
        public static void Test4(this OldClass O, int x)
        {
            Console.WriteLine("Method Four: " + x);
        }
        public static void Test5(this OldClass O)
        {
            Console.WriteLine("Method Five:" + O.x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OldClass obj = new OldClass();
            obj.Test1();
            obj.Test2();
            //Calling Extension Methods
            obj.Test3();
            obj.Test4(10);
            obj.Test5();
            Console.ReadLine();
        }
    }
}