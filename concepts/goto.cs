using System;
namespace ControlFlowDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Statment1");
            goto statement4;   //goto label someLabel:
            Console.WriteLine("Executing Statment2");
            Console.WriteLine("Executing Statment3");
            statement4:    //label:
            Console.WriteLine("Executing Statment4");
            Console.WriteLine("Executing Statment5");
            Console.ReadKey();
        }
    }
}