using System ; 
using System.Globalization; 

class Uri
{
    static void Main(string[] args)
    {
    // rece os dados 
    string[] diaDeInicio = Console.ReadLine().Split(' '); 
    string[] tempoInicio = Console.ReadLine().Split(':');
    string[] diaDoFIm = Console.ReadLine().Split(' ');
    string[] tempoFIm = Console.ReadLine().Split(':');

    int diaInicio = Convert.ToInt32(diaDeInicio[1]); 
    int diaFim = Convert.ToInt32(diaDoFIm[1]);

    int horas = Convert.ToInt32(tempoInicio[0].Trim());
    int minutos = Convert.ToInt32(tempoInicio[1].Trim());
    int segundos = Convert.ToInt32(tempoInicio[2].Trim());

    int horasFim = Convert.ToInt32(tempoFIm[0].Trim());
    int minutosFim = Convert.ToInt32(tempoFIm[1].Trim());
    int segundosFim = Convert.ToInt32(tempoFIm[2].Trim());

    // converte dias , horas , minutos para segundo . 
    int SegundosInicio = (diaInicio * 86400) + (horas * 3600)+ (minutos * 60) + segundos ; 
    int SegundosFimCalc = (diaFim * 86400) + (horasFim * 3600)  + (minutosFim * 60) + segundosFim;

    int TotalsegundosConvertido = SegundosFimCalc - SegundosInicio; //-- calculamos o total de segundos entre esse periodo 

        //--- aqui eu faco um calculo simples de divisao e resto , para decompor a todos os momentos disponineis ( dia , hora , minuto ), o que sobrar eu atribuo a segundosRest.
    int diasResultado = TotalsegundosConvertido / 86400 ; 
    TotalsegundosConvertido %= 86400 ; 
    int horasResultado = TotalsegundosConvertido / 3600 ; 
    TotalsegundosConvertido %= 3600 ; 
    int minutosResultado = TotalsegundosConvertido / 60 ; 
    TotalsegundosConvertido %= 60 ;
    int segundosRest = TotalsegundosConvertido ; 

    Console.WriteLine($"{diasResultado} dia(s)"); 
    Console.WriteLine($"{horasResultado} hora(s)"); 
    Console.WriteLine($"{minutosResultado} minuto(s)"); 
    Console.WriteLine($"{segundosRest} segundo(s)"); 
    }
}