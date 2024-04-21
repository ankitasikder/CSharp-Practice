using System;

class Program{
    
    public static String ModifyPalindrome(String palindrome) {
    char[] chars = palindrome.ToCharArray();
    int n = chars.Length;

    // Find the first character from the left that is not 'a'.
    int i = 0;
    while (i < n && chars[i] == 'a') {
        i++;
    }

    // If the string consists of 'a's only, it's not possible to create the desired string.
    if (i == n) {
        return "IMPOSSIBLE";
    }

    // Change the first non-'a' character to 'a' to meet the conditions.
    chars[i] = 'a';

    // Convert the modified array back to a string.
    String modified = new String(chars);

    return modified;
}

 static void Main(String[] args) {
    String palindrome = "aaaaabbaaaaa";
    String result = ModifyPalindrome(palindrome);
    Console.WriteLine(result);
}
}