using System;

using System.Collections.Generic;

namespace genericStack

{

    class Program

    {

        static void Main(string[] args)

        {

            Stack<string> steak = new Stack<string>();

            steak.Push("Rare");

            steak.Push("Medium Rare");

            steak.Push("Medium");

            steak.Push("Well done");

            steak.Pop();

            foreach (string s in steak)

            {

                Console.WriteLine(s);

            }

        }

    }

}

