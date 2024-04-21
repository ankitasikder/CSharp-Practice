using System;

using System.Collections.Generic;

namespace genericList

{

    class Program

    {

        static void Main(string[] args)

        {

            List<int> GenericList = new List<int>();

            GenericList.Add(30);

            GenericList.Add(60);

            GenericList.Add(90);

            GenericList.Add(120);

            foreach (int x in GenericList)

            {

                Console.WriteLine(x);

            }
     List<string> myList = new List<string>{ "Yes", "No", "Maybe"};
     string firstItem = myList.ElementAt(2);
     //string firstItem = myList[0];
     Console.WriteLine(firstItem);
 
//Remove(),Length,Count,Sort()
        }

    }

}