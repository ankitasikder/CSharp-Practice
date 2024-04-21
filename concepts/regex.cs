using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
      // Create a pattern for a word that starts with the letter "M"
      string pattern = @"\b[M]\w+";
      // Create a Regex
      Regex rg = new Regex(pattern,RegexOptions.IgnoreCase);

      // Long string
      string authors = "Mahesh Chand, Raj Kumar, Mike Gold, Allen O'Neill, Marshal Troll";
      // Get all matches
      MatchCollection matchedAuthors = rg.Matches(authors);
      // Print all matched authors
      for (int count = 0; count < matchedAuthors.Count; count++)
       Console.WriteLine(matchedAuthors[count].Value);

       Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");
            //class Regex represents an immutable regular expression.

            string[] str = { "+91-9678967101", "9678967101", "+91-9678-967101", "+91-96789-67101", "+919678967101" };
            //Input strings for Match valid mobile number.
            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid mobile number.", s,
                r.IsMatch(s) ? "is" : "is not");
               
            }
    }
}