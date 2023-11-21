using System;

class Program
{
    static void Main()
    {
        int[] v = new int[10];
        int nr;
        Console.WriteLine("nr=");
        nr = int.Parse(Console.ReadLine());
        while (nr > 0)
        {
            v[nr % 10]++;
            nr /= 10;
        }
        int n = 0;
        for(int i=0;i<10;i++)
            if (v[i] != 0)
                n++;
        Console.WriteLine(n<=2 ? $"Numarul este format din {n} cifre" : "Numarul este format din mai mult de 2 cifre");
    }
}