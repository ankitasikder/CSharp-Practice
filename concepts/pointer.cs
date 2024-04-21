using System;
namespace DataTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                // declare a variable
                int number = 10;

                // store variable number address location in pointer variable ptr
                int* ptr = &number;
                Console.WriteLine($"Value :{number}");
                Console.WriteLine($"Address :{(int)ptr}");
                Console.ReadKey();
            }
        }
    }
}