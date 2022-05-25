namespace Algoritmos.Algoritmos
{
    public static class Algoritmo69
    {
        /*
             [DESAFIO] Desenvolva um programa que leia o primeiro termo e a razão de uma
            PA (Progressão Aritmética), mostrando na tela os 10 primeiros elementos da PA e
            a soma entre todos os valores da sequência.
        */
        public static void Start()
        {
            Console.Write("Primeiro termo da PA: ");
            var inicio = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Razão da PA: ");
            var razao = int.Parse(Console.ReadLine() ?? "0");

            var qtdTermos = 10;

            for (int i = 0; i < qtdTermos; i++)
            {
                var valor = inicio + (i * razao);

                Console.Write($"{valor} ");
            }
        }
    }
}
