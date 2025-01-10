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

        // Цветник
        // Григорий занимается цветочным бизнесом. В его распоряжении имеется парник, поделённый на 15 участков (3*5), на каждом из которых растут розовые кусты. На одном участке могут расти цветы только одного вида. Григорий самостоятельно решает, какие цветы будут расти на каждом участке парника и по какой цене их отпускать.
        // Известно, что фирма занимается выращиванием и реализацией только красных, белых и розовых роз и на каждом участке появляются ровно 100 цветов за год.
        // Напишите программу, которая выведет ежегодную прибыль Григория. Всеми расходами пренебречь.
        
        // Входные данные
            // В качестве входных данных вводится сначала таблица размером 3 на 5, заполненная буквами, обозначающими цвет посаженных на соответствующем участке роз. Так буква "к" обозначает красные розы, "б" - белые, "р" - розовые. 
            // Далее вводятся 3 числа — цены за один цветок, по которым Григорий собирается продавать соответственно красные, белые и розовые розы.

        // Выходные данные
            // Программа должна вывести ежегодную прибыль Григория без учёта всех возможных расходов.

        // Примечание:
            // Распределение роз в парнике и их цены всегда остаются постоянными.
            //  Каждая буква это 100 роз соответствующего цвета.

        
        // Sample Input 1:

        // к к к к к
        // б б б б б
        // р р р р р
        // 100 90 110
        
        // Sample Output 1:
        // 150000



        // int n = int.Parse(Console.ReadLine()!);
        // string[] arr = Console.ReadLine()!.Split(' ');

        //string[] x = Console.ReadLine()!.Split(' ');
        // string[] arr = "1 2 3 -2 -4".Split(' ');


        string[,] arr = new string[3, 5];

        for (int i = 0; i < 3; i++)
        {
            string[] input = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < 5; j++)
            {
                arr[i, j] = input[j];
            }
        }

        string[] prices = Console.ReadLine()!.Split(' ');
        int priceRedRose = int.Parse(prices[0]);
        int priceWhiteRose = int.Parse(prices[1]);
        int pricePinkRose = int.Parse(prices[2]);

        int sumRed = 0;
        int sumWhite = 0;
        int sumPink = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (arr[i, j] == "к") sumRed += priceRedRose;
                else if (arr[i, j] == "б") sumWhite += priceWhiteRose;
                else sumPink += pricePinkRose;
            }
        }

        Console.WriteLine((sumRed + sumWhite + sumPink) * 100);


    }

}

