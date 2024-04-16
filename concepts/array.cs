
using System;
class HelloWorld {
  static void Main(string[] args) {
    int[] arr = new int[]{1,5,7,3,4,8,9};
    int n = arr.Length;
    // for(int i=0;i<n;i++)
    // {
    //     Console.WriteLine(arr[i]);
    // }
    foreach(int i in arr)
    {
        Console.WriteLine(i);
    }
    Console.ReadLine();
    
  }
}