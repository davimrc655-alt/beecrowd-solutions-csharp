using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        String[] Valores1 = Console.ReadLine().Split(' ');
        String[] Valores2 = Console.ReadLine().Split(' ');
        double x1, x2, y1, y2;
        x1 = Convert.ToDouble(Valores1[0], CultureInfo.InvariantCulture); 
        x2 = Convert.ToDouble(Valores2[0], CultureInfo.InvariantCulture); 
        y1 = Convert.ToDouble(Valores1[1], CultureInfo.InvariantCulture); 
        y2 = Convert.ToDouble(Valores2[1], CultureInfo.InvariantCulture); 
        double diferencaX = x2 - x1 ; 
        double diferencaY = y2 - y1 ; 
        double xDiferenteQuadrado = Math.Pow(diferencaX , 2); 
        double yDiferenteQuadrado = Math.Pow(diferencaY , 2); 
        double calcFinal = Math.Sqrt(xDiferenteQuadrado + yDiferenteQuadrado); 
        Console.WriteLine(calcFinal.ToString("F4")); 
    }

}
