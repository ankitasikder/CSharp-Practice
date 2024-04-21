

// C# code to check if a 
// value is in LinkedList 
using System; 
using System.Collections; 
using System.Collections.Generic; 
  
class GFG { 
  
    // Driver code 
    public static void Main() 
    { 
        // Creating a LinkedList of Strings 
        LinkedList<String> myList = new LinkedList<String>(); 
  
        // Adding nodes in LinkedList 
        myList.AddLast("A"); 
        myList.AddLast("B"); 
        myList.AddLast("C"); 
        myList.AddLast("D"); 
        myList.AddLast("E"); 
  
        // To check if a value is in LinkedList 
        Console.WriteLine(myList.Contains("B")); 
    } 
} 