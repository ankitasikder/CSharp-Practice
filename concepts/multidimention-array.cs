using System;
class HelloWorld {
  static void Main(string[] args) {
      //multi dimention array
      char[,] arr = new char[,]{{'A','B'},{'C','D'},{'E','F'}};
      for(int y=0;y<arr.GetLength(0);y++)
      {
         for(int x=0;x<arr.GetLength(1);x++)
         {
               if(arr[x,y]=='A')
               {
                     Console.WriteLine("A found at location "+x+","+y);
               }
         }
      }

      
  }
}