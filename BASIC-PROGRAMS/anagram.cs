//anagram
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    
    private static bool AreAnagram(string str1, string str2)
    {
        char[] cha1 = str1.ToCharArray();
        char[] cha2 = str2.ToCharArray();
        Array.Sort(cha1);
        Array.Sort(cha2);
        int n1=cha1.Length;
        int n2=cha2.Length;
        if(n1!=n2)
        {
          return false;
        }
        for(int i=0;i<n1;i++)
        {
          if(cha1[i]!=cha2[i])
          {
            return false;
          }
        }
        return true;



    }
    static void Main()
    {
        String str1 = "Fried";
        String str2 = "Fired";
        if(AreAnagram(str1,str2))
        {
          Console.WriteLine("Anagram");
        }
        else
        {
          Console.WriteLine("Not Anagram");
        }
    }
}
