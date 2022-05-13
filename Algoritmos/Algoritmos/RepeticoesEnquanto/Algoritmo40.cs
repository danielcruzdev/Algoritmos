namespace Algoritmos.Algoritmos
{
    public static class Algoritmo40
    {
        /*
            Faça um algoritmo que mostre na tela a seguinte contagem:
            0 3 6 9 12 15 18 Acabou!
        */
        public static void Start()
        {
            var i = 0;
            var fim = 18;
            while(i <= fim)
            {
                Console.Write($"{i} ");
                i+=3;
            }
            Console.WriteLine("Acabou!");
        }
    }
}
