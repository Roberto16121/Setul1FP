
using System;


class Program //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
{
    static void Main(string[] args)
    {
        int n, k;
        Console.WriteLine("Introduceti n=");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti k=");
        k=int.Parse(Console.ReadLine());
        if (n % k == 0)
            Console.WriteLine("{0} se divide cu {1}", n,k);
        else
            Console.WriteLine("{0} nu se divide cu {1}", n,k);
    }
}
