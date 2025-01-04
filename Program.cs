using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks.Dataflow;
using System.Xml;


public class MainClass
{
    static void Main()
    {
        // int n = int.Parse(Console.ReadLine()!);
        // string[] numbs = Console.ReadLine()!.Split(' ');

        int n = 5;
        string[] numbs = "1 2 3 4".Split(' ');
        string res = "";

        for (int i = 1; i < n; i += 2)
        {
            res += numbs[i] + " ";
            res += numbs[i - 1] + " ";
        }

        if (numbs.Length % 2 != 0) res += numbs[numbs.Length - 1];
        Console.WriteLine(res);

    }

}
