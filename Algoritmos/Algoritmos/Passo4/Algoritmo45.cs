namespace Algoritmos.Algoritmos
{
    public static class Algoritmo45
    {
        /*
        O algoritmo 44 vai ter um problema quando digitarmos o primeiro valor
        maior que o último. Resolva esse problema com um código que funcione em qualquer
        situação.
        */
        public static void Start()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            var first = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Digite o ultimo valor: ");
            var last = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Digite o incremento: ");
            var increment = int.Parse(Console.ReadLine() ?? "0");

            var i = first;
            if (first <= last)
            {
                while (i <= last)
                {
                    Console.Write($"{i} ");
                    i += increment;
                }

            }
            else
            {
                while (i >= last)
                {
                    Console.Write($"{i} ");
                    i -= increment;
                }
            }


            Console.WriteLine("Acabou!");
        }
    }
}
