namespace Algoritmos.Algoritmos
{
    public static class Algoritmo32
    {
        /*
             [DESAFIO] Crie um jogo onde o computador vai sortear um número entre 1 e 5 o
                jogador vai tentar descobrir qual foi o valor sorteado.
        */
        public static void Start()
        {
            var random = new Random();
            var CPUNumber = random.Next(1, 6);

            Console.Write("Para tentar adivinhar qual número o computador armazenou,");
            Console.Write(" digite um número de 1 a 5: ");
            var number = int.Parse(Console.ReadLine() ?? "0");

            if (CPUNumber == number)
                Console.WriteLine($"Você ACERTOU, o número era: {CPUNumber}");
            else
                Console.WriteLine($"Você ERROU, o número era: {CPUNumber}");
        }
    }
}
