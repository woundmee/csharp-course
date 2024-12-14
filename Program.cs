using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Xml;


public class MainClass
{
    public static void Main()
    {

        char c = char.Parse(Console.ReadLine()!);  // 0 = 48, 9 = 57
        // Console.WriteLine((char)(c - 32));

        if (c >= 'a' && c <= 'z') Console.WriteLine((char)(c - 32));
        else if (c >= 'A' && c <= 'Z') Console.WriteLine((char)(c + 32));

    }
}