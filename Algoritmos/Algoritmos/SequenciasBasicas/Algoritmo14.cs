namespace Algoritmos.Algoritmos
{
    public static class Algoritmo14
    {
        /*
            A locadora de carros precisa da sua ajuda para cobrar seus serviços. Escreva
            um programa que pergunte a quantidade de Km percorridos por um carro alugado e a
            quantidade de dias pelos quais ele foi alugado. Calcule o preço total a pagar,
            sabendo que o carro custa R$90 por dia e R$0,20 por Km rodado.
        */
        public static void Execute()
        {
            Console.Write("Digite quantos KMs foram percorridos com o veiculo: ");
            var quilometros = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite a quantidade de dias que o carro foi alugado:  ");
            var dias = double.Parse(Console.ReadLine() ?? "0");

            var valorDias = dias * 90;
            var valorKm = quilometros * 0.20;
            var valorTotal = valorDias + valorKm;

            Console.WriteLine($"Valor dos dias alugado: R${valorDias:F2}");
            Console.WriteLine($"Valor dos Kms percorridos: R${valorKm:F2}");
            Console.WriteLine($"Valor total: R${valorTotal:F2}");
        }
    }
}
