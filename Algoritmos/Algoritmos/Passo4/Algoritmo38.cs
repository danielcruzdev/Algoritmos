namespace Algoritmos.Algoritmos
{
    public static class Algoritmo38
    {
        /*
            Escreva um programa que mostre na tela a seguinte contagem:
            6 7 8 9 10 11 Acabou!
        */
        public static void Start()
        {
            var i = 6;
            var fim = 11;
            while(i <= fim)
            {
                Console.Write($"{i} ");
                i++;
            }
            Console.WriteLine("Acabou!");
        }
    }
}
