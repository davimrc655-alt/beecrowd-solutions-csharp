using System ; 
class Program
{
    static void Main(string[] args ) 
    {
        int movimentacaoMes = Convert.ToInt32(Console.ReadLine()); 
        if (movimentacaoMes <= 49)
        {
            Console.Write("movimentacao normal esse mes : )"); 
        }
        else if(movimentacaoMes >= 50 && movimentacaoMes <= 100 )
        {
            Console.WriteLine("movimentacao anormal ,informar gestores. ") ; 
        }
        else 
        {
            Console.WriteLine(" Alarmante , estado critico , sobrecarga do sistema logisco , informar equipe diretiva "); 
        }
    }
}