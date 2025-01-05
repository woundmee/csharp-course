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
        // string[] arr = Console.ReadLine()!.Split(' ');

        int n = 5;
        string[] arr = "1 2 1 3 1".Split(' ');

        int[] arrInt = new int[arr.Length];
        for (int i = 0; i < n; i++)
            arrInt[i] = int.Parse(arr[i]);

        var res = arrInt.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key);
        foreach(var item in res)
            System.Console.Write(item + " ");

    }

}
