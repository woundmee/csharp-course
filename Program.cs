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
        string str = "testers"; //Console.ReadLine();

        var newStr = str
        .Where(x => char.IsLetter(x))
        .GroupBy(x => x)
        .Select(s => new { key = s.Key, count = s.Count() })
        .OrderBy(s => s.key);

        foreach (var item in newStr)
            Console.WriteLine(item.key + " " + item.count);

    }
}