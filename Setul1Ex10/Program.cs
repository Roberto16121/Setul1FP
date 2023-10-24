using System;

class Program
{
    //Test de primalitate: determinati daca un numar n este prim.

    static bool Prime(int n, int i)
    {
        if (i >= n)
            return true;
        if (n % i == 0)
            return false;
        else return Prime(n, i + 1);
    }

    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti n=");
        n = int.Parse(Console.ReadLine());
        if(Prime(n, 2))
            Console.WriteLine("Numarul {0} este prim", n);
        else Console.WriteLine("Numarul {0} nu este prim", n);
    }
}