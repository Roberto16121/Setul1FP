using System;

class Program
{
    //Afisati toti divizorii numarului n. 
    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti n=");
        n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                Console.WriteLine(i);
        }
    }
}