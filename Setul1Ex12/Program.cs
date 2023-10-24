using System;

class Program
{
    //Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
    static void Main()
    {
        int a, b, n;
        Console.WriteLine("Introduceti intervalul [a,b] cu a=");
        a=int.Parse(Console.ReadLine());
        Console.WriteLine("b=");
        b=int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti un divizor n=");
        n=int.Parse(Console.ReadLine());

        int nr = 0;
        for(int i=a; i<=b; i++)
        {
            if(i%n==0)
            {
                nr++;
            }
        }
        Console.WriteLine("Sunt {0} numere divizibile cu {1} in intervalul [{2}, {3}]", nr, n, a, b);
    }
}