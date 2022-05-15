namespace Algoritmos.Algoritmos
{
    public static class Algoritmo47
    {
        /*
            Desenvolva um aplicativo que mostre na tela o resultado da expressão 500 +
            450 + 400 + 350 + 300 + ... + 50 + 0
        */
        public static void Start()
        {
            var i = 500;
            var last = 0;
            var decrement = 50;
            var total = 0;

            while (i >= last)
            {
                total += i;
                Console.Write($"{i} ");
                i -= decrement;
            }

            Console.WriteLine("Acabou!");
            Console.WriteLine($"Soma: {total}");
        }
    }
}
