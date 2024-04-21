using System;
using System.Linq;
using System.Collections.Generic;
class Student
{
    public int StudentID { get; set; }
    public String StudentName { get; set; }
    public int age { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Student[] studentArray = { 
                    new Student() { StudentID = 1, StudentName = "John", age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "Steve",  age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "Bill",  age = 25 } ,
                    new Student() { StudentID = 4, StudentName = "Ram" , age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "Ron" , age = 31 } ,
                    new Student() { StudentID = 6, StudentName = "Chris",  age = 17 } ,
                    new Student() { StudentID = 7, StudentName = "Rob",age = 19  } ,
                };

        // Use LINQ to find teenager students
        Student[] teenAgerStudents = studentArray.Where(s => s.age > 12 && s.age < 20).ToArray();
       
        // Use LINQ to find first student whose name is Bill 
        Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();
        
        IList<string> stringList = new List<string>() { 
    "C# Tutorials",
    "VB.NET Tutorials",
    "Learn C++",
    "MVC Tutorials" ,
    "Java" 
     };

    // LINQ Method Syntax
 var result = stringList.Where(s => s.Contains("Tutorials"));

     IList<Student> studentList = new List<Student>() { 
        new Student() { StudentID = 1, StudentName = "John", age = 13} ,
        new Student() { StudentID = 2, StudentName = "Moin",  age = 21 } ,
        new Student() { StudentID = 3, StudentName = "Bill",  age = 18 } ,
        new Student() { StudentID = 4, StudentName = "Ram" , age = 20} ,
        new Student() { StudentID = 5, StudentName = "Ron" , age = 15 } 
    };
//Linq method syntax
var teenAgerStudent = from s in studentList
                      where s.age > 12 && s.age < 20
                      select s;
    }
}