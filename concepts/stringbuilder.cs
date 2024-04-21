using System;
using System.Text;
class Program{
  static void Main(string[] args)
  {
       StringBuilder sb = new StringBuilder("Ankita Sikder");
       sb.Append(" is best.");
       sb.Insert(0,"Topper ");
       int n=sb.Length;
       //sb.Remove(5, 3); 
       sb.Replace("Ankita", "Romi"); 
       Console.WriteLine(n);
       Console.WriteLine(sb);
       String s = sb.ToString();
       Console.WriteLine(s);

       StringBuilder sb1 = new StringBuilder(s);
       sb1.Append(" Happy");
       Console.WriteLine(sb1);



  }
}
