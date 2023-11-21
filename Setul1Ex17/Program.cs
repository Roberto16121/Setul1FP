using System;

class Program
{
    static int Cmmdc(int a, int b)
    {
        while (a != b)
        {
            if (a > b)
                a -= b;
            else
                b -= a;
        }
        return a;
    }

    static void Main()
    {
        Console.WriteLine("a=");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b=");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(Cmmdc(a,b));
        int multiplu = a * b / Cmmdc(a, b);
        Console.WriteLine(multiplu);
    }
}