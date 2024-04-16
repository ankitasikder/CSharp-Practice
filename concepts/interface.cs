using System; 
internal interface IAnimal{
    void Sound();
}
internal interface ILivingBeing{
    void Breathe();
}
internal class Dog : IAnimal,ILivingBeing
{
    public void Sound()
    {
        Console.WriteLine("Bhou Bhou");
    }
    public void Breathe()
    {
        Console.WriteLine("1,2,3");
    }
}


public class Program
{
    static void Main(string[] args)
    {
        Dog dg = new Dog();
        dg.Sound();
        dg.Breathe();
        
        
    }
}