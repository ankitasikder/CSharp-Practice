using System;
public class Animal{
    private string name;
    private int age;
    public void SayName()
    {
        Console.WriteLine("My name is: "+name);
    }
    public void SayAge()
    {
        Console.WriteLine("I am "+age+" years old!");
    }
    public virtual void MakeNoise()
    {
        Console.WriteLine("General animal sound.");
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
    public void Barks()
    {
        Console.WriteLine("Bhou Bhou");
    }
    public override void MakeNoise()
    {
        Console.WriteLine("Dog sound bhou bhou");
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Animal an = new Animal();
        an.Name="Ankita";
        an.Age=23;
        an.SayName();
        an.SayAge();
        an.MakeNoise();
        
        Dog dg = new Dog();
        dg.Name="Romi";
        dg.Age=23;
        dg.SayName();
        dg.SayAge();
        dg.Barks();
        dg.MakeNoise();
        
        Console.ReadLine();
        
    }
}