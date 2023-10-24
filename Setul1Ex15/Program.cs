using System;

class Program
{
    //Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
    static void Main()
    {
        int[] numere = new int[3];
        Console.WriteLine("Introduce numerele a=");
        numere[0]=int.Parse(Console.ReadLine());
        Console.WriteLine("b=");
        numere[1] = int.Parse(Console.ReadLine());
        Console.WriteLine("c=");
        numere[2] = int.Parse(Console.ReadLine());
        for(int i=0; i<3; i++)
        {
            for(int j=i+1; j<3; j++)
            {
                if (numere[i] > numere[j])
                {
                    int temp = numere[i];
                    numere[i] = numere[j];
                    numere[j] = temp;
                }
            }
        }
        for(int i=0; i<3; i++)
        {
            Console.Write(numere[i] + " ");
        }
       

    }
}