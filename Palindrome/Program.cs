using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;


namespace Palindrome
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                if (arg.Length < 2)
                {
                    Console.WriteLine($"{arg} -> True");
                }
                else Console.WriteLine($"{arg} -> {IsPalindrome(arg)}");

            }
        }


    public static bool IsPalindrome(string text)
    {
        if (text == null) throw new ArgumentNullException();

        if (text.Length > 0 && text.Length < 2)
        {
            return true;
        }

        char[] cArray = text.ToCharArray(); //criaçao de um array 
        Array.Reverse(cArray); //reverse do array
        string revStr = new string(cArray);

        return text == revStr;
    }


    }
}

