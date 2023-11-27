using System;

class Program
{
    static bool IsPrime(int nr, int i=2)
    {
        if(nr==2)
            return true;
        if(i>Math.Sqrt(nr))
            return true;
        if (nr % i == 0)
            return false;
        return IsPrime(nr, i + 1);

    }

    static void Main()
    {
        int a;
        Console.WriteLine("a=");
        a = int.Parse(Console.ReadLine());
        int[] v = new int[a+1];
        int i = 2;
        while(a>1)
        {
            if (IsPrime(i))
            {
                if (a % i == 0)
                {
                    a /= i;
                    v[i]++;
                }
                else i++;

            }
            else i++;
        }
        for(i=0;i<v.Length; i++)
        {
            if (v[i] != 0)
                Console.Write($"{i}^{v[i]} ");
        }

    }
}