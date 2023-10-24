using System;

class Program
{
    //(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
    //Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  

    static void Main()
    {
        int a, b;
        Console.WriteLine("Introduceti a=");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti b=");
        b = int.Parse(Console.ReadLine());
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("Numerele schimbate strict sunt a={0}, b={1}", a,b);
    }
}