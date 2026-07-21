using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Uri
{
    static void Main()
    {
        int Cont_alternative_user = 1;

        while (Cont_alternative_user != 2)
        {
            if (Cont_alternative_user == 1)
            {
                double call = Function_validation(); // call to Function 
                Console.WriteLine($"media = {call.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            do
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                Cont_alternative_user = Convert.ToInt32(Console.ReadLine());
            }
            while (Cont_alternative_user != 1 && Cont_alternative_user != 2);
        }
    }

    static double Function_validation() // validacao de notas , enquanto nota_valida nao for == 2 
    {
        double Function_soma = 0;
        int nota_valida = 0;

        while (nota_valida < 2)
        {
            double nota = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (nota >= 0 && nota <= 10)
            {
                nota_valida += 1;
                Function_soma += nota;
            }
            else
            {
                Console.WriteLine("nota invalida"); 
            }
        }

        return Function_soma / 2.0;
    }
}