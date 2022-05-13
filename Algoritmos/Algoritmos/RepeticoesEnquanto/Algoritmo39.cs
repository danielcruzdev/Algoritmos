namespace Algoritmos.Algoritmos
{
    public static class Algoritmo39
    {
        /*
            Faça um algoritmo que mostre na tela a seguinte contagem:
            10 9 8 7 6 5 4 3 Acabou!
        */
        public static void Start()
        {
            var i = 10;
            var fim = 3;
            while(i >= fim)
            {
                Console.Write($"{i} ");
                i--;
            }
            Console.WriteLine("Acabou!");
        }
    }
}
