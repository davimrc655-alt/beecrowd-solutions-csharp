using System;
class URI
{
    static void Main(string[] args)
    {
        string caracteristicaUm, caracteristicaDois, caracteristicaTres, tipo;
        caracteristicaUm = Console.ReadLine();
        caracteristicaDois = Console.ReadLine();
        caracteristicaTres = Console.ReadLine();
        if (caracteristicaUm == "vertebrado" && caracteristicaDois == "mamifero" && caracteristicaTres == "onivoro")
        {
            tipo = "homem";
            Console.WriteLine(tipo);
        }
        else if (caracteristicaUm == "vertebrado" && caracteristicaDois == "mamifero" && caracteristicaTres == "herbivoro")
        {
            tipo = "vaca";
            Console.WriteLine(tipo);
        }
        else if (caracteristicaUm == "vertebrado" && caracteristicaDois == "ave" && caracteristicaTres == "carnivoro")
        {
            tipo = "aguia";
            Console.WriteLine(tipo);
        }
        else if (caracteristicaUm == "vertebrado" && caracteristicaDois == "ave" && caracteristicaTres == "onivoro")
        {
            tipo = "pomba";
            Console.WriteLine(tipo);
        }
        else if (caracteristicaUm == "invertebrado" && caracteristicaDois == "inseto" && caracteristicaTres == "hematofago")
        {
            tipo = "pulga";
            Console.WriteLine(tipo);
        }
        else if (caracteristicaUm == "invertebrado" && caracteristicaDois == "inseto" && caracteristicaTres == "herbivoro")
        {
            tipo = "lagarta";
            Console.WriteLine(tipo);
        }
        else if (caracteristicaUm == "invertebrado" && caracteristicaDois == "anelideo" && caracteristicaTres == "hematofago")
        {
            tipo = "sanguessuga";
            Console.WriteLine(tipo);
        }
        else
        {
            tipo = "minhoca";
            Console.WriteLine(tipo);
        }

    }
}
