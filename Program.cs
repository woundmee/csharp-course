using System;
using System.Collections.Generic;
using System.Linq;



/// Кажется, еще совсем недавно наступил новый 2013 год. А знали ли Вы забавный факт о том, что 2013 год является первым годом после далекого 1987 года, в котором все цифры различны?
/// Теперь же Вам предлагается решить следующую задачу: задан номер года, найдите наименьший номер года, который строго больше заданного и в котором все цифры различны.

/// Вход: В единственной строке задано целое число y (1000 ≤ y ≤ 9000)y (1000 ≤ y ≤ 9000) — номер года.
/// Выход: Выведите единственное целое число — минимальный номер года, который строго больше y, в котором все цифры различны. Гарантируется, что ответ существует.

public class MainClass
{
    public static void Main()
    {
        int year = int.Parse(Console.ReadLine()!);

        var yearList = year.ToString().Select(x => int.Parse(x.ToString())).ToList();
        for (int i = 0; i < yearList.Count(); i++)
        {
            if (yearList[i] == yearList[i+1])
            {
                Console.WriteLine(yearList[i]);
                break;
            }
            else Console.WriteLine("Eror: удалить условие");
        }

        // for (int i = year; i <= 9000; i++)        
        // {

        // }

    }
}