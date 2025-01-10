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
        // input1: 13:00, input2: 17:00
        string sleep = Console.ReadLine()!;
        string alarm = Console.ReadLine()!;

        TimeSpan s = TimeSpan.Parse(sleep);
        TimeSpan a = TimeSpan.Parse(alarm);

        
        if (a < s)
            a = a.Add(new TimeSpan(24, 0, 0));
        
        TimeSpan diff = a - s;

        Console.WriteLine($"Будильник зазвонит через {diff.Hours} час(часов) и {diff.Minutes} минут.");
    }
}

