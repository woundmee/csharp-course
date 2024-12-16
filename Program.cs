using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Xml;


public class MainClass
{
    public static void Main()
    {
        string text = "abcba"; //Console.ReadLine();
        char[] textToChar = text.ToCharArray();
        Array.Reverse(textToChar);
        string textReversed = new string(textToChar);

        Console.WriteLine(text == textReversed ? "YES" : "NO");

    }
}