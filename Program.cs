using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

public class MainClass
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine()!);
        int b = int.Parse(Console.ReadLine()!);

        for (int i = b; i >= a; i--)
        {
            if (i % 7 == 0) 
            {
                Console.WriteLine(i);
                break;
            }
            
            b--;
        }

        if (b == 0) Console.WriteLine("NO");

    }
}