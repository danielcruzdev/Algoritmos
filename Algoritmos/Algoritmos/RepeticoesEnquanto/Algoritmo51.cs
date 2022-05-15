namespace Algoritmos.Algoritmos
{
    public static class Algoritmo51
    {
        /*
            Faça um aplicativo que leia o preço de 8 produtos. No final, mostre na tela
            qual foi o maior e qual foi o menor preço digitados.
        */
        public static void Start()
        {
            var qtd = 8;
            var i = 1;
            var maior = 0.0d;
            var menor = 0.0d;

            while (i <= qtd)
            {
                Console.Write($"{i}º produto: R$");
                var valor = double.Parse(Console.ReadLine() ?? "0");

                if (i == 1)
                {
                    maior = valor;
                    menor = valor;
                }
                else
                {
                    if (valor > maior)
                        maior = valor;

                    if (valor < menor)
                        menor = valor;
                }

                i++;
            }

            Console.WriteLine($"Maior Valor: R${maior:F2}");
            Console.WriteLine($"Menor valor: R${menor:F2}");
        }
    }
}
