using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
    int timeDuracaoSegundos = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture); 
    int horas = timeDuracaoSegundos/3600; 
    int minutos = (timeDuracaoSegundos%3600)/60; 
    int segundos = ((timeDuracaoSegundos%3600)%60); 
    Console.WriteLine($"{horas}:{minutos}:{segundos}"); 
    }
}