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

        int x = 5;
        string[] arr = "1 1 2 2 3".Split(' ');
        int[] arrInt = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
            arrInt[i] = int.Parse(arr[i]);

        int arrIntDist = arrInt.Distinct().ToArray().Count();
        Console.WriteLine(arrIntDist);
        
        

    }

}

