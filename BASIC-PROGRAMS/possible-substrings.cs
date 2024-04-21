using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Solution
{
  
    internal static List<string> PossibleSubstrings(string s)
    { 
        List<string> list = new List<string>();
        int n = s.Length;
        for(int i=0;i<n;i++)
        {
          for(int j=i+1;j<=n;j++)
          {
            string sub = s.Substring(i,j);
            list.Add(sub);
          }
        }
        return list;
    }

}
public class Program
{ 
  static void Main()
  {
      
    List<string> res = Solution.PossibleSubstrings("asdf");
    foreach(string r in res)
    {
      Console.Write(r+", ");
    }

    
  }

}
