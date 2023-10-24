using System;

class Program
{
    static void Main()  // Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
    {
        int a, b, c;
        Console.WriteLine("Introduceti latura a=");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti latura b=");
        b= int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti latura c=");
        c = int.Parse(Console.ReadLine());
        if (a + b > c && a + c > b && b + c > a)
            Console.WriteLine("Laturile {0}, {1} si {2} pot forma un triunghi", a, b, c);
        else
            Console.WriteLine("Laturile {0}, {1} si {2} nu pot forma un triunghi", a, b, c);
    }
}