using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
  public static void Main()
  {
    //int to char
    int a = 65;
    char c = (char)a;
    Console.WriteLine(c);

    //char to int
    char c1 = 'S';
    int a1 = (int)c1;
    Console.WriteLine(a1);

    //char to string
    char c2 = 'B';
    string s = c2.ToString();
    Console.WriteLine(s.GetType());

    //int to string
    int b = 101;
    string si = b.ToString();
    Console.WriteLine(b.GetType());

    // char array to string
    char[] arr = {'s','o','u','m','e','n'};
    string s1 = new string(arr);
    Console.WriteLine(arr.GetType()+" "+s1);

    //string to char array
    string s2 = "ankita";
    char[] arr1 = s2.ToCharArray();
    foreach(char c3 in arr1)
    {
      Console.Write(c3+" ");
    }
    Console.WriteLine("");
    //string to string array
    string str = "Ankita is the best winner and topper.";
    string[] star = str.Split(' ');
    int count=1;
    foreach (string s3 in star)
    {
      Console.WriteLine(count+" "+s3);
      count++;
    }

    //string array to string
    string[] star1 = {"Ankita","is","Strong","enough","To","Win"};
    string joined = string.Join(" ", star1);
    Console.WriteLine(joined);

    //string to stringbuiilder
    StringBuilder sb = new StringBuilder(joined);
    sb.Append(".");
    Console.WriteLine(sb);

    //stringbuilder to string
    string stri = sb.ToString();
    Console.WriteLine(stri.GetType());
   
    //array to list
    string[] names ={"Ankita","Biswa","Soumen","Damon","Wanda","Denerys","Diana"};
    List<string> namelist = names.ToList();
    Console.WriteLine(namelist.GetType());
  
    //list to array
    String[] names2 = namelist.ToArray();
    Console.WriteLine(names2.GetType());






  }

  
}
