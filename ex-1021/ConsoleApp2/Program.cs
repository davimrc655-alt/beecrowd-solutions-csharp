using System;
using System.Globalization;
class Uri
{
    static void Main(String[] args)
    {
        double valorRecebido = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture); 
        double calcCentavos = valorRecebido * 100; 
        int totalCentavosConvertido = Convert.ToInt32(Math.Round(calcCentavos)); 
        
        Console.WriteLine("NOTAS:");
        
        totalCentavosConvertido = ProcessarValor(totalCentavosConvertido, 10000, "nota(s) de R$", "100.00");
        totalCentavosConvertido = ProcessarValor(totalCentavosConvertido, 5000, "nota(s) de R$", "50.00");
        totalCentavosConvertido = ProcessarValor(totalCentavosConvertido, 2000, "nota(s) de R$", "20.00");
        totalCentavosConvertido = ProcessarValor(totalCentavosConvertido, 1000, "nota(s) de R$", "10.00");
        totalCentavosConvertido = ProcessarValor(totalCentavosConvertido, 500, "nota(s) de R$", "5.00");
        totalCentavosConvertido = ProcessarValor(totalCentavosConvertido, 200, "nota(s) de R$", "2.00");
        Console.WriteLine("MOEDAS:");
        //------------------------------------------Moedas---------------------------------------------------------
        totalCentavosConvertido = ProcessarValor(totalCentavosConvertido, 100, "moeda(s) de R$", "1.00");
        totalCentavosConvertido = ProcessarValor(totalCentavosConvertido, 50, "moeda(s) de R$", "0.50");
        totalCentavosConvertido = ProcessarValor(totalCentavosConvertido, 25, "moeda(s) de R$", "0.25");
        totalCentavosConvertido = ProcessarValor(totalCentavosConvertido, 10, "moeda(s) de R$", "0.10");
        totalCentavosConvertido = ProcessarValor(totalCentavosConvertido, 5, "moeda(s) de R$", "0.05");
        totalCentavosConvertido = ProcessarValor(totalCentavosConvertido, 1, "moeda(s) de R$", "0.01");
    }
    static int  ProcessarValor(int centavosAtual, int valorNota , string tipo , string valorTexto )
    {
        int Calc = centavosAtual / valorNota ; 
        Console.WriteLine($"{Calc} {tipo} {valorTexto}"); 
        return centavosAtual % valorNota; 
    }
}
