using System;

class Program // Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).
{
    static void Main()
    {
        List<int> list = new List<int>();
        int nr1,nr2;
        Console.WriteLine("Introduceti numarul sub forma a/b");
        string input;
        input = Console.ReadLine();
        string[] numbers = input.Split('/');
        nr1 = Convert.ToInt32(numbers[0]);
        nr2 = Convert.ToInt32(numbers[1]);
        
        
    }
}