using System;

class Program // Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 
{
    static void Main()
    {
        int x;
        int minim = 1, maxim = 1024;
        Console.WriteLine("Introduceti un numar cuprins intre 1 si 1024, x-");
        x = int.Parse(Console.ReadLine());
        while (x < minim || x > maxim)
        {
            Console.WriteLine("Numarul trebuie sa fie intre 1 si 1024");
            Console.WriteLine("Introduceti un numar x=");
            x = int.Parse(Console.ReadLine());
        }
        bool test = false;
        while(minim != maxim || test)
        {
            int mid = (minim + maxim) / 2;
            Console.WriteLine($"Numarul este mai mare sau egal decat {mid} (da/nu):");
            string raspuns = Console.ReadLine();

            while(raspuns.Contains("da") == false && raspuns.Contains("nu") == false)
            {
                Console.WriteLine("Raspunsul trebuie sa fie da sau nu");
                Console.WriteLine($"Numarul este mai mare sau egal decat {mid}");
                raspuns = Console.ReadLine();
            }
            
            if (raspuns.Contains("da"))
            {
                if (minim == mid && !test)
                {
                    test = true;
                    maxim--;
                }
                else if(minim == mid && test)
                {
                    test = false;
                    minim++;
                    maxim++;
                }
                else minim = mid;
                Console.WriteLine(minim + " " + maxim);

            }
            else
            {
                maxim = mid - 1;
                Console.WriteLine(minim + " " + maxim);
            }
           
        }
        Console.WriteLine($"Numarul este {minim}");
    }
}
