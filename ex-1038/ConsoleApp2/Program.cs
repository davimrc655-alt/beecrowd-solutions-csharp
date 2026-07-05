using System ; 

class URI
{
    static void Main()
    {
        string [] codigoEQuantidade = Console.ReadLine().Split(' '); 
        int x , quantidade ; 
        double precoUnitario , total; 
        precoUnitario = 0 ; 
        x = Convert.ToInt32(codigoEQuantidade[0]); 
        quantidade = Convert.ToInt32(codigoEQuantidade[1]); 

        if (x == 1)
        {
            precoUnitario = 4.00 ; 
        }
        else if (x == 2)
        {
            precoUnitario = 4.50 ; 
        }
        else if (x == 3)
        {
            precoUnitario = 5.0 ; 
        }
        else if (x == 4)
        {
            precoUnitario = 2.0 ; 
        }
        else if (x == 5)
        {
            precoUnitario = 1.50 ; 
        }
        total =  precoUnitario * quantidade ; 

        Console.WriteLine($"Total: R$ {total.ToString("F2")}"); 
    }
}