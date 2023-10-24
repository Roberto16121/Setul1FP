using System;

class Program
{
    //Determianti daca un numar n este palindrom.
    //(un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
    static void Main()
    {
        int n;
        Console.WriteLine("Introduceti n=");
        n=int.Parse(Console.ReadLine());
        int nInvers = 0, temp = n;
        while(temp > 0)
        {
            nInvers = nInvers*10 + temp % 10;
            temp /= 10;
        }
        if (n == nInvers)
            Console.WriteLine("Numarul {0} este palindrom", n);
        else
            Console.WriteLine("Numarul {0} nu este palindrom", n);
        
    }
}