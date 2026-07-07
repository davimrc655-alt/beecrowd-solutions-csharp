using System; 
using System.Globalization; 
class Uri
{
    static void Main(string[] args)
    {
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
        double calcAumento , novoSalario; 
        int percentual; 

        if ( salario <= 400)
        {
            percentual = 15 ;
        }
        else if (salario >= 400.01 && salario <= 800.00)
        {
            percentual = 12 ; 
        }
        else if (salario >= 800.01 && salario <= 1200.00)
        {
            percentual = 10 ; 
        }
        else if (salario >= 1200.01 && salario <= 2000)
        {
            percentual = 7 ; 
        }
        else
        {
            percentual = 4; 
        }
        calcAumento = CalcSalario(salario , percentual) ;
        novoSalario = calcAumento + salario ; 
        Console.WriteLine($"Novo salario: {novoSalario.ToString("F2")}");
        Console.WriteLine($"Reajuste ganho: {calcAumento.ToString("F2")}");
        Console.WriteLine($"Em percentual: {percentual} %");
    }
    static double CalcSalario(double salario , int percentual)
    {
        return (salario * percentual)/100 ; 
    }
}