using System;
public class Animal{
    private string name;
    private int age;
    public Animal(string name,int age)
    {
        this.name=name;
        this.age=age;
    }
    public virtual void MakeNoise()
    {
        Console.WriteLine("Hello");
    }
    public string Name
    {
        get{
            return name;
        }
        set{
            name=value;
        }
    }
    public int Age
    {
        get{
            return age;
        }
        set{
            age=value;
        }
    }
}
public class Dog : Animal{
    private string breed;
    public Dog(string name, int age, string breed):base(name,age)
    {
        this.breed=breed;
    }
   public void Info()
   {
       Console.WriteLine(base.Name);
       Console.WriteLine(base.Age);
       Console.WriteLine(Breed);
   }
    public override void MakeNoise()
    {
        Console.WriteLine("Dog sound bhou bhou");
    }
    public string Breed{
        get{
            return breed;
        }
        set{
            breed=value;
        }
    }
}
public class Program
{
    static void Main(string[] args)
    {
        
        Dog dg = new Dog("Ankita",23,"Human");
       
        dg.Info();
        dg.MakeNoise();
        
        Console.ReadLine();
        
    }
}