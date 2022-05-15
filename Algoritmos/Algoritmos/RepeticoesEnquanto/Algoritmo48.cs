namespace Algoritmos.Algoritmos
{
    public static class Algoritmo48
    {
        /*
            Faça um programa que leia 7 números inteiros e no final mostre o somatório
            entre eles.
        */
        public static void Start()
        {
            var qtdNumeros = 7;
            var i = 1;
            var total = 0;

            while (i <= qtdNumeros)
            {
                Console.Write($"Digite um número: ");
                var numero = int.Parse(Console.ReadLine() ?? "0");

                total += numero;
                i++; ;
            }

            Console.WriteLine($"Soma: {total}");
        }
    }
}
