using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Net;

class Program
{

    static int DoubleFact(int x)  // двойной факториал
    {
        bool isEven = false;
        int factSum = 1;

        // проверяю на четность
        if (x % 2 == 0) isEven = true;
        else isEven = false;

        if (isEven)
        {
            for (int i = 1; i <= x; i++)
                if (isEven && i % 2 == 0)
                    factSum *= i;
        }
        else
        {
            for (int i = 1; i <= x; i++)
                if (!isEven && i % 2 != 0)
                    factSum *= i;
        }
        return factSum;
    }

    public static void Main()
    {
        // string[] x = Console.ReadLine()!.Split(' ');

        int a = int.Parse(Console.ReadLine()!);
        int b = int.Parse(Console.ReadLine()!);
        int c = int.Parse(Console.ReadLine()!);

        string res = DoubleFact(a) + " " + DoubleFact(b) + " " + DoubleFact(c);
        Console.WriteLine(res);

    }

}