using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Xml;


public class MainClass
{
    static void Main()
    {
        string text = "ЭЮЯ";
        int key = 2;

        char[] buffer = text.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];  // берем букву
            if (char.IsLetter(letter))  // проверяем буква ли это
            {
                // здесь использованы русские Аа (для анг. версии поменять на англ. буквы)
                char offset = char.IsUpper(letter) ? 'А' : 'а';  // определяем какая это буква (большая/маленькая)
                letter = (char)((((letter + key) - offset) % 32) + offset);
                buffer[i] = letter;
            }
        }

        Console.WriteLine(buffer);
    }

}
