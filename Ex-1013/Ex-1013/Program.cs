using System;
using System.Globalization;
class URI
{

    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' '); 
        int a , b , c ; 
        a = Convert.ToInt32(valores[0], CultureInfo.InvariantCulture); 
        b = Convert.ToInt32(valores[1], CultureInfo.InvariantCulture); 
        c = Convert.ToInt32(valores[2], CultureInfo.InvariantCulture);
        //----
        int AB, ABC;
        AB = CalcABMaiorMaior(a, b);
        ABC = CalcABCMaiorMenor(AB , c) ;
        //
        Console.WriteLine($"{ABC} eh o maior"); 
    }
    static int CalcABMaiorMaior(int a, int b)
    {
        return (a + b + Math.Abs(a - b)) / 2;
    }
    static int CalcABCMaiorMenor(int AB, int c)
    {
        return (AB + c + Math.Abs(AB - c)) / 2;
    }
}