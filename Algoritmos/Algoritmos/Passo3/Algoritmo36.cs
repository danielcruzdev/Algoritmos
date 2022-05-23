namespace Algoritmos.Algoritmos
{
    public static class Algoritmo36
    {
        /*
             Um programa de vida saudável quer dar pontos atividades físicas que podem
            ser trocados por dinheiro. O sistema funciona assim:
             - Cada hora de atividade física no mês vale pontos
             - até 10h de atividade no mês: ganha 2 pontos por hora
             - de 10h até 20h de atividade no mês: ganha 5 pontos por hora
             - acima de 20h de atividade no mês: ganha 10 pontos por hora
             - A cada ponto ganho, o cliente fatura R$0,05 (5 centavos)
            Faça um programa que leia quantas horas de atividade uma pessoa teve por mês,
            calcule e mostre quantos pontos ela teve e quanto dinheiro ela conseguiu ganhar.
        */
        public static void Start()
        {
            Console.Write("Quantas horas de atividade física você fez esse mês: ");
            var horas = double.Parse(Console.ReadLine() ?? "0");

            var valorPorPonto = 0.05;
            int pontosPorHora;

            if (horas <= 10)
                pontosPorHora = 2;
            else if (horas >= 10 && horas <= 20)
                pontosPorHora = 5;
            else
                pontosPorHora = 10;

            var totalPontos = horas * pontosPorHora;
            var totalReceber = totalPontos * valorPorPonto;

            Console.WriteLine($"Você irá receber R${totalReceber:F2}, por ter praticado {horas} horas de atividade física");
        }
    }
}
