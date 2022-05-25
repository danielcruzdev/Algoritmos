namespace Algoritmos.Algoritmos
{
    public static class Algoritmo70
    {
        /*
            [DESAFIO] Faça um programa que mostre os 10 primeiros elementos da Sequência
            de Fibonacci:
            1 1 2 3 5 8 13 21...
        */
        public static void Start()
        {
            var numero1 = 1;
            var numero2 = 1;

            Console.Write($"{numero1} {numero2} ");
            for (int i = 2; i < 10; i++)
            {
                var numero3 = numero1 + numero2;
                Console.Write($"{numero3} ");

                numero1 = numero2;
                numero2 = numero3;
            }
        }
    }
}
