//call by value effect for object
using System;
internal class Movie{
    private string title;
    public string Title{
        get{
            return title;
        }
        set{
            title=value;
        }
    }
}
internal class Program {
  static void Main() {
      Movie m = new Movie();
      m.Title="Jawan";
      Console.WriteLine("Original movie title is: "+m.Title);
      Reset(m);
      Console.WriteLine("Final movie title is: "+m.Title);
      Console.ReadLine();
      
  }
  private static void Reset(Movie m)
  {
      //if i use following statement then the value won't be changed finally as it is creating new object
      //m = new Movie();
      m.Title="Fighter";
      Console.WriteLine("Inside reset function movie title is: "+m.Title);
 
  }
}