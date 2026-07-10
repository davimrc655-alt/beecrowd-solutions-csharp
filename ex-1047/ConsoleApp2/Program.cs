using System;
class Uri
{
    static void Main(string[] args)
    {
        string[] valores = Console.ReadLine().Split(' ');
        int hora_Fim, minutos_Inicio, hora_Inicio, minutos_Fim, duracao_total_minutos, total_min_inicio, total_min_fim;

        hora_Inicio = Convert.ToInt32(valores[0]);
        minutos_Inicio = Convert.ToInt32(valores[1]);
        hora_Fim = Convert.ToInt32(valores[2]);
        minutos_Fim = Convert.ToInt32(valores[3]);

        hora_Inicio *= 60;
        hora_Fim *= 60;
        total_min_inicio = hora_Inicio + minutos_Inicio;
        total_min_fim = hora_Fim + minutos_Fim;
        duracao_total_minutos = total_min_fim - total_min_inicio;

        if (duracao_total_minutos <= 0)
        {
            duracao_total_minutos += 24 * 60;
        }

        int duracao_total_horas = duracao_total_minutos / 60;
        int resto_minutos = duracao_total_minutos % 60;

        Console.WriteLine($"O JOGO DUROU {duracao_total_horas} HORA(S) E {resto_minutos} MINUTO(S)");
    }
}