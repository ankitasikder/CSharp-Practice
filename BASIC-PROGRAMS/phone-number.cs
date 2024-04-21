// C# program to implement above approach
using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
 
class GFG
{
 
  // Function to convert double, triple, quad etc
  // into 2, 3, 4 etc respectively
  static int prefixFreq(String word)
  {
    if (word.Equals("double"))
      return 2;
    else if (word.Equals("triple"))
      return 3;
    else if (word.Equals("quad"))
      return 4;
    else if (word.Equals("penta"))
      return 5;
    else if (word.Equals("hexa"))
      return 6;
    else if (word.Equals("hepta"))
      return 7;
    else if (word.Equals("octa"))
      return 8;
    else if (word.Equals("nona"))
      return 9;
    else if (word.Equals("deca"))
      return 10;
 
    return -1;
  }
 
  // Function to convert zero, one, two etc
  // into 0, 1, 2 respectively
  static char strTOnum(String word)
  {
    if (word.Equals("zero"))
      return '0';
    else if (word.Equals("one"))
      return '1';
    else if (word.Equals("two"))
      return '2';
    else if (word.Equals("three"))
      return '3';
    else if (word.Equals("four"))
      return '4';
    else if (word.Equals("five"))
      return '5';
    else if (word.Equals("six"))
      return '6';
    else if (word.Equals("seven"))
      return '7';
    else if (word.Equals("eight"))
      return '8';
    else if (word.Equals("nine"))
      return '9';
 
    return (char)0;
  }
 
  // Function to extract the number from string
  static String TextToNum(String TXTNO)
  {
    String resnum = "";
    List<String> strarr = TXTNO.Split(" ").ToList();
    int i = 0, j = 0;
    int temp;
 
    for (i = 0 ; i < strarr.Count ; i++) {
      temp = prefixFreq(strarr[i]);
 
      if (temp == -1)
        resnum += strTOnum(strarr[i]);
 
      else {
        for (j = 0 ; j < temp ; j++){
          resnum += strTOnum(strarr[i+1]);
        }
 
        i++;
      }
    }
 
    return resnum;
  }
 
  // Driver Code
  public static void Main(string[] args){
 
    String s = "five eight quad two four triple eight";
    Console.WriteLine(TextToNum(s));
 
  }
}