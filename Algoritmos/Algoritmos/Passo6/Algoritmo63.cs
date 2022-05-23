namespace Algoritmos.Algoritmos
{
    public static class Algoritmo63
    {
        /*
            Crie um programa usando a estrutura “faça enquanto” que leia vários números.
            A cada laço, pergunte se o usuário quer continuar ou não. No final, mostre na
            tela:
            a) O somatório entre todos os valores
            b) Qual foi o menor valor digitado
            c) A média entre todos os valores
            d) Quantos valores são pares
        */
        public static void Start()
        {
            var qtdNumeros = 0;
            var somaTotal = 0d;
            var valoresPares = 0;
            var menorValor = double.MaxValue;

            string continuar;
            do
            {
                Console.Write("Digite um número: ");
                var numero = double.Parse(Console.ReadLine() ?? "0");

                somaTotal += numero;
                qtdNumeros++;

                if ((numero % 2) == 0)
                    valoresPares++;

                if(numero < menorValor)
                    menorValor = numero;

                Console.Write($"Continuar? (S ou N): ");
                continuar = Console.ReadLine() ?? "N";
                continuar = continuar.ToUpper();

                Console.WriteLine("--------------------------------");

            } while (continuar == "S");

            var media = somaTotal / qtdNumeros;

            Console.WriteLine($"Soma total: {somaTotal}");
            Console.WriteLine($"Qtd. valores pares: {valoresPares}");
            Console.WriteLine($"Média: {media:F2}");
            Console.WriteLine($"Menor valor: {menorValor}");
        }
    }
}
