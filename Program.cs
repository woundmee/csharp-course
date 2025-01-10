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

        //string[] x = Console.ReadLine()!.Split(' ');
        // string[] arr = "1 2 3 -2 -4".Split(' ');

        int n = 3; //int.Parse(x[0]);
        int m = 3; //int.Parse(x[1]);
        bool captcha = false;

        int[,] arr = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = int.Parse(input[j]);
            }
        }

        int searchNumb = int.Parse(Console.ReadLine()!);  // необходимо найти в массиве
        int attempt = int.Parse(Console.ReadLine()!);  // попытки

        for (int i = 0; i < attempt; i++)
        {
            string[] input = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < attempt; j++)
            {
                int ii = int.Parse(input[0]);
                int jj = int.Parse(input[1]);
                if (arr[ii, jj] == searchNumb)
                {
                    // Console.WriteLine(arr[ii, jj]);
                    captcha = true;
                }
                else {
                    captcha = false;
                    break;
                }
            }
        }


        Console.WriteLine(captcha ? "Captcha успешно пройдена" : "Вы не человек");






    }

}

