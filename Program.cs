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
        // ПРОВЕРКА НА СИММЕТРИЧНОСТЬ 2-МЕРНОГО МАССИВА.
        // т.е. чтобы все значения (за исключением главной диагонали) были симметричны.

        // для одномерного массива симметричность - это просто палиндром: 1 2 3 2 1


        // int n = int.Parse(Console.ReadLine()!);
        // string[] arr = Console.ReadLine()!.Split(' ');

        int n = 3;
        int[,] arr = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < n; j++)
                arr[i, j] = int.Parse(input[j]);
        }

        bool isSym = true;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr[i, j] != arr[j, i]) { isSym = false; break; }
            }
            if (!isSym) break;  // чтобы дальше цикл не гонять, т.к. итак уже фолс
        }

        Console.WriteLine(isSym ? "YES" : "NO");

    }

}



// int n = 10;

//         int[,] arr = new int[n, n];

//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 // NOTE: ОБРАТИТЬ ВНИМАНИЕ!
//                 if (j == n - 1 - i) arr[i, j] = 1;
//                 else if (j < n - i) arr[i, j] = 0;
//                 else arr[i, j] = 2;
//             }
//         }


//         for (int i = 0; i < n; i++)
//         {
//             for (int j = 0; j < n; j++)
//             {
//                 Console.Write(arr[i, j] + " ");
//             }
//             Console.WriteLine();
//         }