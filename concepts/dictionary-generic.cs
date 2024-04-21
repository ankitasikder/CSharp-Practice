using System;
using System.Collections.Generic;
class Program
{
  static void Main(string[] args)
  {
     Dictionary<int,string> dic = new Dictionary<int,string>();
     List<string> list = new List<string>();

     dic.Add(1,"Ankita");
     dic.Add(2,"Biswa");
     dic.Add(3,"Soumen");
     dic.Add(4,"Ranveer");
     dic.Add(5,"Damon");
     dic.Add(6,"Abhishek");

     Console.WriteLine("The count of the elements are: " +dic.Count);
    
    foreach(KeyValuePair<int,string> kvp in dic)
    {
      Console.WriteLine(kvp.Key+" "+kvp.Value);
    }

     foreach(string p in dic.Values)
     {
         Console.WriteLine($"value: {p}");
     }

     foreach(int f in dic.Keys)
     {
       Console.WriteLine($"key: {f}");
     }

     if(dic.ContainsKey(4)==true)//also contains value can be used
     {
       list.Add(dic[4]);
     }
     foreach(string s in list)
     {
       Console.WriteLine("The best man is: "+s);
     }
  }
}