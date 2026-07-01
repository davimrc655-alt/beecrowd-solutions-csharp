using System ; 
using System.Globalization; 
class Uri
{
    static void Main(String[] args)
    {
        int trocoDinheiro = Convert.ToInt32(Console.ReadLine() , CultureInfo.InvariantCulture);
        Console.WriteLine(trocoDinheiro); 
        int restoTroco = trocoDinheiro/100;
        int restoTroco1 = trocoDinheiro%100;
        Console.WriteLine($"{restoTroco} nota (s) de R$ 100,00");
        Console.WriteLine($"{restoTroco1/50} nota (s) de R$ 50,00");
        restoTroco1 %= 50;
        Console.WriteLine($"{restoTroco1/20} nota (s) de R$ 20,00");
        restoTroco1 %= 20;
        Console.WriteLine($"{restoTroco1/10} nota (s) de R$ 10,00");
        restoTroco1 %= 10;
        Console.WriteLine($"{restoTroco1/5} nota (s) de R$ 5,00");
        restoTroco1 %= 5;
        Console.WriteLine($"{restoTroco1/2} nota (s) de R$ 2,00");
        restoTroco1 %= 2;
        Console.WriteLine($"{restoTroco1/1} nota (s) de R$ 1,00");
    }
}