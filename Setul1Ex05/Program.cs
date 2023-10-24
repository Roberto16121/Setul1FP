using System;

class Program  //Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
{
    static void Main()
    {
        int n = 0, k = 0;
        Console.WriteLine("introduceti un nr n=");
        n=int.Parse(Console.ReadLine());
        Console.WriteLine("Introduceti un nr k=");
        k=int.Parse(Console.ReadLine());
        for (int i=0;i<k-1;i++)
        {
            n=n/10;
            if(n==0)
            {
                Console.WriteLine("Numarul are mai putin de {0} cifre", k);
                break;
            }
        }
        Console.WriteLine("A {0} cifra din numar este {1} ", k ,n % 10) ;
    }
}