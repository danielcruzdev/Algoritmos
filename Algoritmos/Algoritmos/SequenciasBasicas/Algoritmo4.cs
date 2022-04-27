namespace Algoritmos.Algoritmos
{
    public static class Algoritmo4
    {
        /*
         * Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório entre eles.
         * Ex:
         * Digite um valor: 8
         * Digite outro valor: 5
         * A soma entre 8 e 5 é igual a 13.
         */
        public static void Execute()
        {
            Console.Write("Digite um valor: ");
            var primeiroValor = Console.ReadLine();
            Console.Write("Digite outro valor: ");
            var segundoValor = Console.ReadLine();

            var soma = double.Parse(primeiroValor) + double.Parse(segundoValor);

            Console.WriteLine($"A soma entre {primeiroValor} e {segundoValor} é igual a {soma}.");
        }
    }
}
