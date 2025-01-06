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
        // ДВУМЕРНЫЙ МАССИВ: ТАБЛИЦА УМНОЖЕНИЯ


        // int n = int.Parse(Console.ReadLine()!);
        // string[] arr = Console.ReadLine()!.Split(' ');

        string[] x = "2 3".Split(' ');
        
        int n = int.Parse(x[0]);
        int m = int.Parse(x[1]);

        int[,] arr = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = (i + 1) * (j + 1);
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
                Console.Write(arr[i, j] + " ");
            Console.WriteLine();
        }
            



    }

}

