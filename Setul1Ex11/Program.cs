using System;

class Program
{
    //Afisati in ordine inversa cifrele unui numar n. 
    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti n=");
        n=int.Parse(Console.ReadLine());

        while(n>0)
        {
            Console.Write(n%10);
            n/=10;
        }
    }
}