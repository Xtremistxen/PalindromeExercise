using System;
using System.Security.Cryptography.X509Certificates;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsAPalindrome(string thuum)
    {
        var reversed = "";


        for (int i = thuum.Length - 1; i >= 0; i--)
        {
            reversed += thuum[i];
        }

        var wordCharArray = thuum.ToCharArray();
        Array.Reverse(wordCharArray);
        var reversed = new string(wordCharArray);

        if (thuum.ToLower() == reversed.ToLower())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}