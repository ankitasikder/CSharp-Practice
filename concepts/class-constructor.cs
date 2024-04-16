using System;
    
    internal class Good{
        
        internal string fname;
        internal string lname;
        internal Good(string f,string l)
        {
            fname=f;
            lname=l;
        }
    }
    internal class Program {
        
        static void Main(String[] args) {
            
                  Good gd = new Good("Ankita","Sikder");
                //   gd.fname="Ankita";
                //   gd.lname="Sikder";
                  Console.WriteLine(gd.fname+" "+gd.lname);
                  
     }
  }

