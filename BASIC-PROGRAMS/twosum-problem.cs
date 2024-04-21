//two sum problem
using System;
internal class Program
{
  private static bool CheckSum(int[] arr,int n,int x)
  {
      for(int i=0;i<(n-1);i++)
      {
        for(int j=(i+1);j<n;j++)
        {
          if((arr[i]+arr[j])==x)
          {
            return true;
          }
        }
      }
      return false;
  }
  static void Main(string[] args)
  {
        int[] A = { 0, -1, 2, -3, 1 };
        int x = -2;
        int size = A.Length;
        if(CheckSum(A,size,x))
        {
          Console.WriteLine("Yes");
        }
        else
        {
          Console.WriteLine("No");
        }
  }
}