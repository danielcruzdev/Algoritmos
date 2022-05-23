namespace Algoritmos.Algoritmos
{
    public static class Algoritmo46
    {
        /*
            Crie um programa que calcule e mostre na tela o resultado da soma entre 6 +
            8 + 10 + 12 + 14 + ... + 98 + 100.
        */
        public static void Start()
        {
            var i = 6;
            var last = 100;
            var increment = 2;
            var total = 0;

            while (i <= last)
            {
                total += i;
                Console.Write($"{i} ");
                i += increment;
            }


            Console.WriteLine("Acabou!");
            Console.WriteLine($"Soma: {total}");
        }
    }
}
