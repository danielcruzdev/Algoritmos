namespace Algoritmos.Algoritmos
{
    public static class Algoritmo61
    {
        /*
            Crie um programa que mostre na tela a seguinte contagem, usando a estrutura
            “faça enquanto”
            0 3 6 9 12 15 18 21 24 27 30 Acabou!
        */
        public static void Start()
        {
            var i = 0;
            var fim = 30;
            var incremento = 3;
            do
            {
                Console.Write($"{i} ");
                i += incremento;

            } while (i <= fim);

            Console.Write("Acabou!");
        }
    }
}
