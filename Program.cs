


using System.IO.Pipes;

namespace Main;

class Program
{
    static void Main()
    {
        Book book = new Book(new JsonPrinter());
        book.Text = "loren ipsum...";
        book.Print();
    }
}


interface IPrinter
{
    void Print(string text);
}

class Book
{
    public string Text { get; set; } = "";
    private readonly IPrinter _printer;

    internal Book(IPrinter printer)
    {
        _printer = printer;
    }

    internal void Print()
    {
        _printer.Print(Text);
    }

}

class ConsolePrinter : IPrinter
{
    public void Print(string text)
        => Console.WriteLine("Вывод в консоль: " + text);
}

class JsonPrinter : IPrinter
{
    public void Print(string text)
        => Console.WriteLine("Вывод в json: " + text);
}
