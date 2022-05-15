namespace Algoritmos.Algoritmos
{
    public static class Algoritmo49
    {
        /*
            Faça um programa que leia 7 números inteiros e no final mostre o somatório
            entre eles.
        */
        public static void Start()
        {
            var qtdNumeros = 6;
            var i = 1;
            var pares = 0;
            var impares = 0;

            while (i <= qtdNumeros)
            {
                Console.Write($"Digite um número: ");
                var numero = int.Parse(Console.ReadLine() ?? "0");

                var resto = numero % 2;

                if (resto == 0)
                    pares++;
                else 
                    impares++;
                
                i++; ;
            }

            Console.WriteLine($"Pares: {pares}");
            Console.WriteLine($"Impares: {impares}");
        }
    }
}
