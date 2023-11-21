using System;

class Program //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare. 
{
    static void Main()
    {
        int a, b;
        Console.WriteLine("Introduceti a: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti b: ");
        b = int.Parse(Console.ReadLine());
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Ecuatia are o infinitate de solutii");
            }
            else
            {
                Console.WriteLine("Ecuatia nu are solutii");
            }
        }
        else
        {
            Console.WriteLine("Ecuatia are solutia: " + (float)-b / a);
        }
    }
}