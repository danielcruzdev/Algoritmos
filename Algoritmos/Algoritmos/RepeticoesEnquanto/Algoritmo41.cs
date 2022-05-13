namespace Algoritmos.Algoritmos
{
    public static class Algoritmo41
    {
        /*
            Faça um algoritmo que mostre na tela a seguinte contagem:
            100 95 90 85 80 ... 0 Acabou!
        */
        public static void Start()
        {
            var i = 100;
            var fim = 0;
            while(i >= fim)
            {
                Console.Write($"{i} ");
                i-=5;
            }
            Console.WriteLine("Acabou!");
        }
    }
}
