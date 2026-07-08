using System;  
using System.Globalization ;
class Urin
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' '); 
        double[] valoresOrdenados = new double[3]; 
        valoresOrdenados[0] = Convert.ToDouble(valores[0] , CultureInfo.InvariantCulture); 
        valoresOrdenados[1] = Convert.ToDouble(valores[1] , CultureInfo.InvariantCulture); 
        valoresOrdenados[2] = Convert.ToDouble(valores[2], CultureInfo.InvariantCulture); 
        Array.Sort(valoresOrdenados); 
        Array.Reverse(valoresOrdenados); 
        double a, b, c;
        a = valoresOrdenados[0]; 
        b = valoresOrdenados[1]; 
        c = valoresOrdenados[2]; 

        string tipo ; 
        // por angulos 
        if ( a >= (b + c) )
        {
            tipo = "NAO FORMA TRIANGULO";
            Console.WriteLine(tipo); 
        }
        else {
            if ( Math.Pow( a , 2) == Math.Pow(b , 2) + Math.Pow(c , 2)) { 
                tipo = "TRIANGULO RETANGULO";
                Console.WriteLine(tipo);
            }
            else if (Math.Pow(a, 2) > Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                tipo = "TRIANGULO OBTUSANGULO";
                Console.WriteLine(tipo);
            }
            else if (Math.Pow(a, 2) < Math.Pow(b, 2) + Math.Pow(c, 2))
            {
                tipo = "TRIANGULO ACUTANGULO";
                Console.WriteLine(tipo);
            }

            // por lados 
            if (a == b && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (a == b || b == c)
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}