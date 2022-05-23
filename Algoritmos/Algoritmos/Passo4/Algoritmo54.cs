namespace Algoritmos.Algoritmos
{
    public static class Algoritmo54
    {
        /*
            Desenvolva um aplicativo que leia o peso e a altura de 7 pessoas, mostrando
            no final:
            a) Qual foi a média de altura do grupo
            b) Quantas pessoas pesam mais de 90Kg
            c) Quantas pessoas que pesam menos de 50Kg tem menos de 1.60m
            d) Quantas pessoas que medem mais de 1.90m pesam mais de 100Kg.
        */
        public static void Start()
        {
            var i = 1;
            var qtd = 7;
            var totalAlturaGrupo = 0.0d;
            var qtdMais90Kg = 0;
            var qtdMenos50KgMenos160cm = 0;
            var qtdMais100KgMais190cm = 0;

            while (i <= qtd)
            {
                Console.WriteLine($"{i}º Pessoa");
                Console.Write($"Peso: ");
                var peso = double.Parse(Console.ReadLine() ?? "0");

                Console.Write($"Altura: ");
                var altura = double.Parse(Console.ReadLine() ?? "0");

                totalAlturaGrupo += altura;

                if (peso > 90)
                    qtdMais90Kg++;

                if (peso < 50 && altura < 1.60)
                    qtdMenos50KgMenos160cm++;

                if (peso > 100 && altura > 1.90)
                    qtdMais100KgMais190cm++;

                i++;

                Console.WriteLine("---------------------------");
            }

            var mediaAlturaGrupo = totalAlturaGrupo / qtd;

            Console.WriteLine($"Média altura grupo: {mediaAlturaGrupo:F2}");
            Console.WriteLine($"Quantas pessoas pesam mais de 90Kg: {qtdMais90Kg}");
            Console.WriteLine($"Quantas pessoas que pesam menos de 50Kg tem menos de 1.60m: {qtdMenos50KgMenos160cm}");
            Console.WriteLine($"Quantas pessoas que medem mais de 1.90m pesam mais de 100Kg: {qtdMais100KgMais190cm}");
        }
    }
}
