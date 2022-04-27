namespace Algoritmos.Algoritmos
{
    public static class Algoritmo9
    {
        /*
            Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$)
            e mostre quantos dólares ela pode comprar. Considere US$1,00 = R$3,45.
        */
        public static void Execute()
        {
            Console.Write("Digite a cotação atual do dolar: ");
            var cotacaoDolar = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Valor em reais:  ");
            var valorEmReais = double.Parse(Console.ReadLine() ?? "0");

            var valorEmDolares = valorEmReais / cotacaoDolar;
            Console.WriteLine($"Você conseguirá comprar ${valorEmDolares:F2} com R${valorEmReais:F2}");
        }
    }
}
