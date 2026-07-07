using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {

        string[] valores = Console.ReadLine().Split(' ');
        double n1, n2, n3, n4, Media, pesoTotal, notaExame, MediaBruta ;
        string status;
        int mediaInteira ; 
        pesoTotal = 2.0 + 3.0 + 4.0 + 1.0;
        n1 = Convert.ToDouble(valores[0] , CultureInfo.InvariantCulture);
        n2 = Convert.ToDouble(valores[1] , CultureInfo.InvariantCulture);
        n3 = Convert.ToDouble(valores[2] , CultureInfo.InvariantCulture);
        n4 = Convert.ToDouble(valores[3] , CultureInfo.InvariantCulture);
        MediaBruta = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / pesoTotal;
        mediaInteira = (int)(MediaBruta * 10) ; 
        Media = mediaInteira / 10.0; 
        if (Media >= 7.00) {
            status = "Aluno aprovado."; 
            Console.WriteLine($"Media: {Media.ToString("F1")}");
            Console.WriteLine(status); 
        }
        else if (Media >= 5.0 && Media <= 6.9)
        {
            Console.WriteLine($"Media: {Media.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine("Aluno em exame.");
            notaExame = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Nota do exame: {notaExame.ToString("F1", CultureInfo.InvariantCulture)}");
            double calc = (Media + notaExame) / 2.0;
            if (calc >= 5.0)
            {
                status = "Aluno aprovado.";
            }
            else
            {
                status = "Aluno reprovado.";
            }
            Console.WriteLine(status);
            Console.WriteLine($"Media final: {calc.ToString("F1", CultureInfo.InvariantCulture)}");
        }
        else { 
            status = "Aluno reprovado.";
            Console.WriteLine($"Media: {Media.ToString("F1")}");
            Console.WriteLine(status);
        }
    }

}