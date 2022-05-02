namespace Algoritmos.Algoritmos
{
    public static class Algoritmo16
    {
        /*
            [DESAFIO] Escreva um programa para calcular a redução do tempo de vida de um
            fumante. Pergunte a quantidade de cigarros fumados por dias e quantos anos ele
            já fumou. Considere que um fumante perde 10 min de vida a cada cigarro. Calcule
            quantos dias de vida um fumante perderá e exiba o total em dias.
        */
        public static void Execute()
        {
            Console.Write("Quantidade de cigarros fumados por dia: ");
            var qtdCigarrosDia = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Por quantos anos você fumou: ");
            var anosFumando = int.Parse(Console.ReadLine() ?? "0");

            var diasFumando = anosFumando * 365;
            var qtdTotalCigarros = diasFumando * qtdCigarrosDia;
            var qtdMinutosPerdidos = qtdTotalCigarros * 10;

            var qtdDiasPerdidos = qtdMinutosPerdidos / 1440;

           Console.Write($"Você perdeu {qtdDiasPerdidos} dias de vida fumando {qtdTotalCigarros} cigarros em {anosFumando} anos");
        }
    }
}
