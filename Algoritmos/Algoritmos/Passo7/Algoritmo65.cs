namespace Algoritmos.Algoritmos
{
    public static class Algoritmo65
    {
        /*
            Desenvolva um programa usando a estrutura “para” que mostre na tela a
            seguinte contagem:
            0 5 10 15 20 25 30 35 40 Acabou!
        */
        public static void Start()
        {
            for (int i = 100; i >= 0; i-=10)
            {
                Console.Write($"{i} ");
            }

            Console.Write("Acabou!");
        }
    }
}
