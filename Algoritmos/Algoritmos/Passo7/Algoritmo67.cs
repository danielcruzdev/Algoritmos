namespace Algoritmos.Algoritmos
{
    public static class Algoritmo67
    {
        /*
            Desenvolva um programa usando a estrutura “para” que mostre na tela a
            seguinte contagem:
            0 5 10 15 20 25 30 35 40 Acabou!
        */
        public static void Start()
        {
            Console.Write("Digite um número inteiro: ");
            var numero = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 0; i <= numero; i++)
            {
                Console.Write($"{i}, ");
            }

            Console.Write($"Fim");
        }
    }
}
