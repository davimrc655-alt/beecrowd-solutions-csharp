using System;
class Uri
{
    static void Main(string[] args)
    {
        int x, y;
        string[] valores = Console.ReadLine().Split(' ');
        x = Convert.ToInt32(valores[0]);
        y = Convert.ToInt32(valores[1]);
        while (true)
        {
            if (x == 0 || y == 0)
            {
                break;
            }
            else
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                    valores = Console.ReadLine().Split(' ');
                    x = Convert.ToInt32(valores[0]);
                    y = Convert.ToInt32(valores[1]);
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                    valores = Console.ReadLine().Split(' ');
                    x = Convert.ToInt32(valores[0]);
                    y = Convert.ToInt32(valores[1]);
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                    valores = Console.ReadLine().Split(' ');
                    x = Convert.ToInt32(valores[0]);
                    y = Convert.ToInt32(valores[1]);
                }
                else
                {
                    Console.WriteLine("quarto");
                    valores = Console.ReadLine().Split(' ');
                    x = Convert.ToInt32(valores[0]);
                    y = Convert.ToInt32(valores[1]);
                }
            }
        }
    }
}