using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        double calcImposto, divisaoUm;
        double salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (salario >= 0.00 && salario <= 2000.00)
        {
            Console.WriteLine("Isento");
        }
        else if (salario >= 2000.01 && salario <= 3000.00)
        {
            salario -= 2000.00;
            calcImposto = salario * 8 / 100;
            Console.WriteLine($"R$ {calcImposto.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else if (salario >= 3000.01 && salario <= 4500)
        {
            salario -= 2000.00;
            divisaoUm = 1000;
            salario -= 1000;
            calcImposto = (divisaoUm * 8 / 100) + (salario * 18 / 100);
            Console.WriteLine($"R$ {calcImposto.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else
        {
            calcImposto = 80.00 + 270.00 + ((salario - 4500) * 0.28);
            Console.WriteLine($"R$ {calcImposto.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }

}