using System;
  public class Dog{
      private readonly string breed;
      private Guid id;
      public Dog(string breed)
      {
          this.breed=breed;
          id=Guid.NewGuid();
      }
      public string Breed
      {
          get
          {
              return breed;
          }
      }
      public Guid Id
      {
          get
          {
              return id;
          }
      }
      
  }
  public class Program{
     static void Main() {
        Dog dg = new Dog("Shitzu");
        Console.WriteLine(dg.Breed);
        Console.WriteLine(dg.Id);
        
  } 
  
 }
  
