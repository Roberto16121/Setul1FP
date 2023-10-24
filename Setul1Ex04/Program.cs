using System;

class Program //Detreminati daca un an y este an bisect. 
{
    static void Main()
    {
        int an = 0;
        Console.WriteLine("Introduceti un an :");
        an = int.Parse(Console.ReadLine());
        if(an % 400 == 0 || (an % 100 != 0 && an % 4 == 0))
            Console.WriteLine("Anul {0} este an bisect", an);
        else 
            Console.WriteLine("Anul {0} nu este an bisect", an);
    }
}