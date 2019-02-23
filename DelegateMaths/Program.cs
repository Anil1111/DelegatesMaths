using System;


class Program
{
    delegate void mathfunc(); 

    static void Main(string[] args)
    {
        mathfunc[] mets = { Add, Mul, Div,Sub };
        foreach (var i in mets)
        {
            i();
        }
    }

    static void Add()
    {
        Console.WriteLine("Add");
    }

    static void Sub()
    {
        Console.WriteLine("Sub");
    }

    static void Mul()
    {
        Console.WriteLine("Mul");
    }
    static void Div()
    {
        Console.WriteLine("Div");
    }
}