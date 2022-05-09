namespace Algoritmos.Algoritmos
{
    public static class Algoritmo31
    {
        /*
            [DESAFIO] Crie um jogo de JoKenPo (Pedra-Papel-Tesoura)
        */
        public static void Start()
        {
            Console.WriteLine("Jogador 1, escolha uma opção:");
            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura");

            var player1 = (JokenPoOpcoes)int.Parse(Console.ReadLine() ?? "0");

            Console.Clear();

            Console.WriteLine("Jogador 2, escolha uma opção:");
            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura");

            var player2 = (JokenPoOpcoes)int.Parse(Console.ReadLine() ?? "0");

            if (player1 == player2)
                Console.WriteLine($"Os dois selecionaram: {player1}, EMPATE!");
            else if (player1 == JokenPoOpcoes.Papel && player2 == JokenPoOpcoes.Pedra)
                Console.WriteLine("Player 1 Ganhou! Papel ganha de pedra");
            else if (player2 == JokenPoOpcoes.Papel && player1 == JokenPoOpcoes.Pedra)
                Console.WriteLine("Player 2 Ganhou! Papel ganha de pedra");
            else if (player1 == JokenPoOpcoes.Papel && player2 == JokenPoOpcoes.Tesoura)
                Console.WriteLine("Player 2 Ganhou! Tesoura ganha de papel");
            else if (player2 == JokenPoOpcoes.Papel && player1 == JokenPoOpcoes.Tesoura)
                Console.WriteLine("Player 1 Ganhou! Tesoura ganha de papel");
            else if (player1 == JokenPoOpcoes.Pedra && player2 == JokenPoOpcoes.Tesoura)
                Console.WriteLine("Player 1 Ganhou! Pedra ganha de tesoura");
            else if (player2 == JokenPoOpcoes.Pedra && player1 == JokenPoOpcoes.Tesoura)
                Console.WriteLine("Player 2 Ganhou! Pedra ganha de tesoura");
            else
                Console.WriteLine("Opçao invalida! Tente novamente!");
        }
    }

    public enum JokenPoOpcoes
    {
       Pedra = 1,
       Papel = 2,
       Tesoura = 3
    }
}
