
using System;
class Pyramid {
  static void PrintPyramid(int size)
  {
       for(int y=1;y<=size;y++)
    {
        for(int h=1;h<=(size-y);h++)
        {
            Console.Write("-");
        }
        for(int p=1;p<=((2*y)-1);p++)
        {
            Console.Write("#"); 
        }
        for(int i=1;i<(size-y);i++)
        {
            Console.Write("-");
        }
        Console.WriteLine("");
    }
  }
  static void Main() {
    Console.WriteLine("Enter the number of rows: ");
    int n=Convert.ToInt32(Console.ReadLine());
    PrintPyramid(n);
  }
}