using System;  
using System.Globalization; 
class Uri
{
    static void Main(string[] args)
    {
        string[] Valores = Console.ReadLine().Split(' ');
        string status ; 
        double y, x;
        x = Convert.ToDouble(Valores[0], CultureInfo.InvariantCulture);
        y = Convert.ToDouble(Valores[1], CultureInfo.InvariantCulture);
        if ( x == 0 && y == 0 )
        {
            status = "Origem" ;
            Console.WriteLine(status);
        }
        else if ( x == 0 && ( y < 0 || y > 0))
        {
            status = "Eixo y" ;
            Console.WriteLine(status);
        }
        else if ( y == 0 && (x < 0 || x > 0))
        {
            status = "Eixo x" ;
            Console.WriteLine(status);
        }
        else if ( x > 0 && y > 0)
        {
            status = "Q1" ;
            Console.WriteLine(status);
        }
        else if ( x < 0 && y > 0)
        {
            status = "Q2" ;
            Console.WriteLine(status);
        }
        else if ( x < 0 && y < 0)
        {
            status = "Q3" ;
            Console.WriteLine(status);
        }
        else if ( x > 0 && y < 0)
        {
            status = "Q4" ;
            Console.WriteLine(status);
        }
        else
        {
            Console.WriteLine("Digite Um valor Valido");
        }
    }
}