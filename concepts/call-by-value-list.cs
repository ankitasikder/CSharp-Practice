//call by value effect for list
using System.Collections.Generic;
using System;
internal class Program {
  static void Main() {
      List<int> list =new List<int>(){1,2,3,4};
      Console.WriteLine("Original count of elements in the list is : "+ list.Count);
      Reset(list);
      Console.WriteLine("Final count of elements in the list is: "+ list.Count);
      Console.ReadLine();
      
  }
  private static void Reset(List<int> l)
  {
      //if i use following statement then the value won't be changed finally as it is creating new object
      //l = new List<int>();
      l.Add(5);
      l.Add(6);
      Console.WriteLine("Inside reset function count of elements in the list is: "+l.Count);
 
  }
}