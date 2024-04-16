
using System;
class HelloWorld {
  static void Main(String[] args) {
    string fname="Ankita";
    string lname="Sikder";
    
    string full=fname+" "+lname;
    
    //string st=full.Substring(0,6);
    
    string st=full.Replace("Sikder","Bhattacharjee");
    
    int index=fname.IndexOf("i");
    
    //int len=fname.Length;
    
    double p=Math.Pow(2.0,5.0);
    
    
    Console.WriteLine(p);
    Console.WriteLine(index);
    Console.WriteLine(st);
    
    Console.WriteLine("Enter the number:");
    int num= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(num);
    
    Console.WriteLine("What is your name?");
    string nm=Console.ReadLine();
    Console.WriteLine("Hello"+" "+nm);
    Console.ReadLine();
    
  }
}
