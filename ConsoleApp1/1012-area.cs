using System;
using System.Globalization; 
class URI
{

    static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(' ');
        double a , c , b ; 
        a = Convert.ToDouble(vet[0] , CultureInfo.InvariantCulture); 
        b = Convert.ToDouble(vet[1] , CultureInfo.InvariantCulture); 
        c = Convert.ToDouble(vet[2] , CultureInfo.InvariantCulture); 
        double resultadoTriangulo = CalcAreaTriangulo(a , c);
        double resultadoCirculo = CalcAreaCirculo(c); 
        double resultadoTrapezio = CalcAreaTrapezio(a , b , c); 
        double resultadoQuadrado = CalcAreaQuadrado(b); 
        double resultadoRetangulo = CalcAreaRetangulo(a ,b ); 
        Console.WriteLine("TRIANGULO: " + resultadoTriangulo.ToString("F3")); 
        Console.WriteLine("CIRCULO: " + resultadoCirculo.ToString("F3")); 
        Console.WriteLine("TRAPEZIO: " + resultadoTrapezio.ToString("F3")); 
        Console.WriteLine("QUADRADO: " + resultadoQuadrado.ToString("F3")); 
        Console.WriteLine("RETANGULO: " + resultadoRetangulo.ToString("F3")); 
    }
    static double CalcAreaTriangulo(double a , double c )
    {
        return a * c / 2;
    }
    static double CalcAreaCirculo(double c )
    {
        double pi , raio2 ; 
        pi = 3.14159 ; 
        raio2 = Math.Pow( c , 2); 
        return pi * raio2; 
    }
    static double CalcAreaTrapezio(double a , double b , double c )
{
    return (a + b) * c / 2; 
    }
    static double CalcAreaQuadrado(double b)
    {      
        return Math.Pow(b, 2); 
    }
    static double CalcAreaRetangulo(double a , double b)
    {
        return a * b; 
    }
} 