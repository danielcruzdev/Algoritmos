namespace Algoritmos.Algoritmos
{
    public static class Algoritmo55
    {
        /*
             [DESAFIO] Vamos melhorar o jogo que fizemos no exercício 32. A partir de
            agora, o computador vai sortear um número entre 1 e 10 e o jogador vai ter 4
            tentativas para tentar acertar.
        */
        public static void Start()
        {
            var random = new Random();
            var CPUNumber = random.Next(1, 11);
            var tentativas = 4;
            var i = 1;

            Console.WriteLine("Digite um número entre 1 e 10");

            while (i <= tentativas)
            {
                Console.Write($"{i}º tentativa: ");
                var number = int.Parse(Console.ReadLine() ?? "0");


                if (CPUNumber == number)
                {
                    Console.WriteLine($"Você ACERTOU");
                    break;
                }
                else
                {
                    Console.WriteLine($"Você ERROU, tente novamente!");
                    i++;
                }
            }

            Console.WriteLine("Fim do jogo!");
            Console.WriteLine($"O número correto era: {CPUNumber}");
        }
    }
}
