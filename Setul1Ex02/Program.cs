using System;

class Program //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
{
    static void Main(string[] args)
    {
        int a, b, c;
        Console.WriteLine("Introduceti a: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti b: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti c: ");
        c = int.Parse(Console.ReadLine());
        Console.WriteLine($"{a} {b}");
        int delta = b * b - 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("Ecuatia nu are solutii reale");
        }
        else if (delta == 0)
        {
            Console.WriteLine("Ecuatia are o solutie reala: " + (float)-b / (2 * a));
        }
        else
        {
            Console.WriteLine("Ecuatia are doua solutii reale: " + ((float)-b + Math.Sqrt(delta)) / (2 * a) + " si " + ((float)-b - Math.Sqrt(delta)) / (2 * a));
        }

    }
}