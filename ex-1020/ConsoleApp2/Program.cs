using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        int timeDiasDeVida = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
        int Anos = timeDiasDeVida / 365;
        int Meses = (timeDiasDeVida % 365) / 30;
        int Dias = ((timeDiasDeVida % 365) % 30);
        Console.WriteLine($"{Anos} ano(s)");
        Console.WriteLine($"{Meses} mes(es)");
        Console.WriteLine($"{Dias} dia(s)");
    }
}