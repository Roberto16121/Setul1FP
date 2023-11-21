class Program
{
    //Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)  
    static void Main()
    {
        int a, b, c, d, e;
        Console.Write("a = ");
        a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        d = int.Parse(Console.ReadLine());
        Console.Write("e = ");
        e = int.Parse(Console.ReadLine());

        //sort 5 numbers without using array
        
        for(int i=0; i<5; i++)
        {
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            if (b > c)
            {
                int temp = b;
                b = c;
                c = temp;
            }
            if (c > d)
            {
                int temp = c;
                c = d;
                d = temp;
            }
            if (d > e)
            {
                int temp = d;
                d = e;
                e = temp;
            }
        }
        Console.WriteLine("{0} {1} {2} {3} {4}", a,b,c,d,e);

    }

   
}

