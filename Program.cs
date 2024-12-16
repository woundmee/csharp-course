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
        string str = "abcba    фыфы     !"; //Console.ReadLine();

        var newStr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        System.Console.WriteLine(string.Join(" ", newStr));

    }
}