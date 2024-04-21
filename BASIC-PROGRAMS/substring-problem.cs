using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Solution
{
    internal int GetMappedValue(char c)
    {
        if(c=='a' || c=='b')
        {
            return 1;
        }
        else if(c=='c' || c=='d'|| c=='e')
        {
            return 2;
        }
        else if(c=='f' || c=='g'|| c=='h')
        {
            return 3;
        }
        else if(c=='i' || c=='j'|| c=='k')
        {
            return 4;
        }
        else if(c=='l' || c=='m'|| c=='n')
        {
            return 5;
        }
        else if(c=='o' || c=='p'|| c=='q')
        {
            return 6;
        }
        else if(c=='r' || c=='s'|| c=='t')
        {
            return 7;
        }
        else if(c=='u' || c=='v'|| c=='w')
        {
            return 8;
        }
        else if(c=='x' || c=='y'|| c=='z')
        {
            return 9;
        }
        else
        {
          return 0;
        }
    }
    internal int ExtraOrdinarySubstring(string s)
    {
      int count=0;
      int n=s.Length;
      for(int i=0;i<n;i++)
      {
        for(int j=i+1;j<=n;j++)
        {
          String sub=s.Substring(i,j);
          int sum=0;
          foreach(char c in sub.ToCharArray())
          {
              sum+=GetMappedValue(c);
          }
          if((sum % sub.Length)==0)
          {
            count++;
           }
        }
      }
      return count;
    }
}
public class Program
{ 
  static void Main(string[] args)
  {
      try{
          Solution sol = new Solution();
    int res = sol.ExtraOrdinarySubstring("asdf");
    Console.WriteLine(res);
      }
      catch(ArgumentOutOfRangeException a)
      {
          Console.WriteLine("Error");
      }
    
  }

}
