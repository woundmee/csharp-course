using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;


public class MainClass
{
    public static void Main()
    {
        char c = '1';
        Console.WriteLine((int)c);

        char first = 'B';
        char second = 'v';

        Console.WriteLine(first < second); // true
        // [!] когда сравниваем char, то сравниваем их коды (они заданы таблице ASCII)

    }
}