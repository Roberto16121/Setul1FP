using System;

class Program  
{
    //(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
    //Se cere sa se inverseze valorile lor. 
    static void Main()
    {
        int a, b;
        Console.WriteLine("Introduceti a=");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Indroduceti b=");
        b=int.Parse(Console.ReadLine());

        int temp = a;
        a = b;
        b = temp;
        
        Console.WriteLine("Numerele schimbate : a={0}, b={1}", a,b);
    }
}