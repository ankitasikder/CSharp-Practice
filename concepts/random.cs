using System;
using System.Collections;
using System.Text;
class Program
{
// Instantiate random number generator.
private readonly Random _random = new Random();

// Generates a random number within a range.
public int RandomNumber(int min, int max)
{
  return _random.Next(min, max);
}
// Generates a random string with a given size.
public string RandomString(int size, bool lowerCase = false)
{
  var builder = new StringBuilder(size);


  char offset = lowerCase ? 'a' : 'A';
  const int lettersOffset = 26; // A...Z or a..z: length=26

  for (var i = 0; i < size; i++)
  {
   var @char = (char)_random.Next(offset, offset + lettersOffset);
   builder.Append(@char);
  }

  return lowerCase ? builder.ToString().ToLower() : builder.ToString();
}
// Generates a random password.
// 4-LowerCase + 4-Digits + 2-UpperCase
public string RandomPassword()
{
  var passwordBuilder = new StringBuilder();

  // 4-Letters lower case
  passwordBuilder.Append(RandomString(4, true));

  // 4-Digits between 1000 and 9999
  passwordBuilder.Append(RandomNumber(1000, 9999));

  // 2-Letters upper case
  passwordBuilder.Append(RandomString(2));
  return passwordBuilder.ToString();
}
  static void Main(string[] args)
  {
    Program pg= new Program();
     Random rand= new Random();
     int num = rand.Next(1000,9999);
     Console.WriteLine(num);
     String res=pg.RandomPassword();
     Console.WriteLine(res);

     
  }
}