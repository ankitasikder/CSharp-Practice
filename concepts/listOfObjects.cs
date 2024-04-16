using System;
using System.Collections.Generic;
    
    internal class User{
        
        internal string fname;
        internal string lname;
        internal int age;
        internal User()
        {
            
        }
        internal User(string f,string l,int a)
        {
            fname=f;
            lname=l;
            age=a;
        }
        internal bool IsMatured()
        {
            return(age>=30);
        }
    }
    internal class Program {
        
        static void Main(String[] args) {
            
            List<User> users = new List<User>();
            User us1 = new User("Ankita","Sikder",23);
            User us2 = new User("Biswa","Bhatt",22);
            users.Add(us1);
            users.Add(us2);
            foreach(User u in users)
            {
                Console.WriteLine(u.fname+" "+u.lname+"-->"+u.age+" and maturity status-->"+u.IsMatured());
            }
            Console.ReadLine();
                  
     }
  }

