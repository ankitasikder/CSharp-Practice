
using System;
using System.IO;
internal class RecursionFile
{
   
    static void Main(string[] args)
    {
         
        Console.WriteLine("Enter the search term: ");
        string term = Console.ReadLine();
        List<string> results = Search("C:\\Users\\ANKITA\\Downloads\\C#PROGRAMS", term);
        foreach(string s in results)
        {
            Console.WriteLine(s);
        }
        if(results.Count == 0) {
            Console.WriteLine("No Results to show.");
        }
        Console.ReadLine();
    }
    private static List<string> Search(string path,string term)
    {
        string[] dirs = Directory.GetDirectories(path);
        List<string> results= new List<string>();
        foreach (string dir in dirs)
        {
            results.AddRange(Search(dir, term));
        }
        string[] files = Directory.GetFiles(path);
        foreach(string file in files)
        {
            if(Path.GetFileNameWithoutExtension(file.ToLower()).Contains(term.ToLower()))
            {
                results.Add(file);

            }
        }
        return results;
    }
}