
/// Поиск площади круга по теореме пифагора: s = pi * r^2

namespace Lessons;

class Program2_10
{
    static void Main2_10()
    {
        Console.Write("R = ");
        double r = double.Parse(Console.ReadLine()!);
        double s = Math.PI * Math.Pow(r, 2);
        Console.WriteLine(s.ToString("N3")); 
    }
}