using System;

class Program
{
    //Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)  
    static void Main()
    {
        int a, b, c, d, e;
        Console.Write("a = ");
        a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        d = int.Parse(Console.ReadLine());
        Console.Write("e = ");
        e = int.Parse(Console.ReadLine());

        int swap;
        if (a > b) { swap = a; a = b; b = swap; }
        if (c > d) { swap = c; c = d; d = swap; }
        if (a > c) { swap = a; a = c; c = swap; }
        if (b > d) { swap = b; b = d; d = swap; }
        if (b > c) { swap = b; b = c; c = swap; }

        Console.WriteLine("{0} {1} {2} {3} {4}", a,b,c,d,e);
    }
}
