namespace Algoritmos.Algoritmos
{
    public static class Algoritmo35
    {
        /*
            Uma empresa de aluguel de carros precisa cobrar pelos seus serviços. O
            aluguel de um carro custa R$90 por dia para carro popular e R$150 por dia para
            carro de luxo. Além disso, o cliente paga por Km percorrido. Faça um programa
            que leia o tipo de carro alugado (popular ou luxo), quantos dias de aluguel e
            quantos Km foram percorridos. No final mostre o preço a ser pago de acordo com a
            tabela a seguir:
             - Carros populares (aluguel de R$90 por dia)
             - Até 100Km percorridos: R$0,20 por Km
             - Acima de 100Km percorridos: R$0,10 por Km
             - Carros de luxo (aluguel de R$150 por dia)
             - Até 200Km percorridos: R$0,30 por Km
             - Acima de 200Km percorridos: R$0,25 por Km
        */
        public static void Start()
        {
            Console.Write("Digite o tipo do carro (1 - Popular | 2 - Luxo): ");
            var tipo = (TipoCarro)int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Por quantos dias o carro ficará alugado? ");
            var dias = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Quantos KMs foram percorridos? ");
            var kms = int.Parse(Console.ReadLine() ?? "0");

            double valorKm;
            int valorDia;
            if (tipo == TipoCarro.Popular)
            {
                valorDia = 90;
                if (kms > 100)
                    valorKm = 0.1;
                else
                    valorKm = 0.2;
            }
            else
            {
                valorDia = 150;
                if (kms > 200)
                    valorKm = 0.25;
                else
                    valorKm = 0.3;
            }

            var valorTotalKms = kms * valorKm;
            var valorTotalDias = dias * valorDia;
            var valorTotal = valorTotalKms + valorTotalDias;

            Console.WriteLine($"Carro Alugado: {tipo}");
            Console.WriteLine($"Dias Alugado: {dias} | Total: R${valorTotalDias:F2}");
            Console.WriteLine($"KMs Percorridos: {kms} | Total: R${valorTotalKms:F2}");
            Console.WriteLine($"Valor Total à Pagar: R${valorTotal:F2}");
        }
    }

    public enum TipoCarro
    {
        Popular = 1,
        Luxo = 2,
    }
}
