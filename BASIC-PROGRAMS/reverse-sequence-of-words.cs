// C# program to reverse a string
using System;
public class ReverseWords 
{
    public static void Main()
    {
        string str="Ankita is most powerful woman on earth.";
        string[] arr=str.Split(' ');
        string res="";
        for(int i=arr.Length-1;i>=0;i--)
        {
          res+=arr[i]+" ";
        }
        Console.WriteLine("After reverse the string is: ");
        Console.WriteLine(res.Substring(0,res.Length-1));
    }

}