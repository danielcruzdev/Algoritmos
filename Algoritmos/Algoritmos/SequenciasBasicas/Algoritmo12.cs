namespace Algoritmos.Algoritmos
{
    public static class Algoritmo12
    {
        /*
            Crie um programa que leia o preço de um produto, calcule e mostre o seu
            PREÇO PROMOCIONAL, com 5% de desconto.
        */
        public static void Execute()
        {
            Console.Write("Digite o valor do produto: ");
            var valorProduto = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite a porcentagem do desconto: ");
            var desconto = double.Parse(Console.ReadLine() ?? "0");

            var valorComDesconto = valorProduto - (valorProduto * desconto / 100);
            
            Console.WriteLine($"O valor do produto com desconto de {desconto}% será de R${valorComDesconto:F2}");
        }
    }
}
