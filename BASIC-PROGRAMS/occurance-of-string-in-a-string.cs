// C# program to find the occurance of a string in a given string
using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
 
class Program
{
  static void Main(string[] args){
 
    string MyString = "Ankita is best. Ankita has dome Btech. Ankita is nice.";
    string stringToFind = "Ankita";

   List<int> positions = new List<int>();
   int pos = 0;
   while ((pos < MyString.Length) && (pos = MyString.IndexOf(stringToFind, pos)) != -1)
  {
       positions.Add(pos);
       pos += stringToFind.Length;
  }

   Console.WriteLine("{0} occurrences", positions.Count);
   foreach (int p in positions)
   {
        Console.WriteLine(p);
  }
 
  }
}