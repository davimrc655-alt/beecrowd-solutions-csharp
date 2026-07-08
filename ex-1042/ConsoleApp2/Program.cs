using System;

class URI
{

    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        int[] valoresCrescentes = new int[3];
        valoresCrescentes[0] = Convert.ToInt32(valores[0]);
        valoresCrescentes[1] = Convert.ToInt32(valores[1]);
        valoresCrescentes[2] = Convert.ToInt32(valores[2]);
        Array.Sort(valoresCrescentes);
        int a, b, c;
        a = valoresCrescentes[0];
        b = valoresCrescentes[1];
        c = valoresCrescentes[2];
        //-------------------------------
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine($"{c}\n");
        Console.WriteLine(valores[0]);
        Console.WriteLine(valores[1]);
        Console.WriteLine(valores[2]);

    }
}
