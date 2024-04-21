

// C# code to get the number of 
// elements that are contained in HashSet 
using System; 
using System.Collections.Generic; 
  
class GFG { 
  
    // Driver code 
    public static void Main() 
    { 
  
        // Creating a HashSet of integers 
        HashSet<int> mySet = new HashSet<int>(); 
  
        // Inserting elements in HashSet 
        for (int i = 0; i < 5; i++) { 
            mySet.Add(i * 2); 
        } 
  
        // To get the number of 
        // elements that are contained in HashSet 
        Console.WriteLine(mySet.Count); 
    } 
} 