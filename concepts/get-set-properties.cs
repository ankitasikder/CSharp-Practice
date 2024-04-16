using System;
public class Practice{
    private string name;
    private int age;
    public Practice(string nm,int ag){
        name=nm;
        age=ag;
    }
    public string Name{
        get{
            return name;
        }
        set{
            bool canUpdate=true;
            if(value.Length<=1) 
            {
                canUpdate=false;
            }
            if(canUpdate)
            {
                name=value;
            }
            
        }
    }
     public int Age{
        get{
            return age;
        }
    }
}

internal class Program {
  static void Main() {
      Practice p = new Practice("Ankita",23);
      Practice p1 = new Practice("Biswa",22);
      Practice p2 = new Practice("Soumen",38);
      p1.Name="Damon";// name can be changed
      Console.WriteLine(p1.Name);
      //p1.Age=42;//age is read only
     // Console.WriteLine(p1.Age);
    //   Console.WriteLine(p2.Name);
    //   Console.WriteLine(p2.Age);
      
  }
}