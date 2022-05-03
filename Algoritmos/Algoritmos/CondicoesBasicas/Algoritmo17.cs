namespace Algoritmos.Algoritmos
{
    public static class Algoritmo17
    {
        /*
            Escreva um programa que pergunte a velocidade de um carro. Caso ultrapasse
            80Km/h, exiba uma mensagem dizendo que o usuário foi multado. Nesse caso, exiba
            o valor da multa, cobrando R$5 por cada Km acima da velocidade permitida.
        */
        public static void Execute()
        {
            const int velocidadePermitida = 80;
            Console.Write("Digite a velocidade do carro: ");
            var velocidade = int.Parse(Console.ReadLine() ?? "0");

            if (velocidade > velocidadePermitida)
            {
                var diferenca = velocidade - velocidadePermitida;
                var valorMulta = diferenca * 5;

                Console.WriteLine($"Você ultrapassou {diferenca}Km/h do limite permitido de {velocidadePermitida}Km/h");
                Console.WriteLine($"Valor da multa: R${valorMulta}");
            }
            else
                Console.WriteLine("Velocidade dentro do limite permitido de 80Km/h");        
        }
    }
}
