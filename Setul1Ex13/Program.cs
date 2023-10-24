using System;

class Program
{
    //Determianti cati ani bisecti sunt intre anii y1 si y2.
    static void Main()
    {
        int y1, y2;
        Console.WriteLine("Introduceti anul 1 :");
        try
        {
            y1 = int.Parse(Console.ReadLine());
        }
        catch(Exception)
        {
            Console.WriteLine("Anul 1 nu este un numar valid");
            return;
        }
        Console.WriteLine("Introduceti anul 2 :");
        try
        {
            y2 = int.Parse(Console.ReadLine());
        }
        catch(Exception)
        {
            Console.WriteLine("Anul 2 nu este un numar valid");
            return;
        }
        
        if(y1 > y2)
        {
            int temp = y1;
            y1 = y2;
            y2 = temp;
        }
        int nr = 0;
        for(int i=y1; i<=y2; i++) 
        {
            if(i%4==0)
                nr++;
        }
        Console.WriteLine(nr);
    }
}
