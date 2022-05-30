namespace Algoritmos.Algoritmos
{
    public static class Algoritmo85
    {
        /*
            Faça um algoritmo que leia o nome, o sexo e o salário de 5 funcionários e
            guarde esses dados em três vetores. No final, mostre uma listagem contendo
            apenas os dados das funcionárias mulheres que ganham mais de R$5 mil
        */

        public static void Start()
        {
            var qtd = 5;

            var salarios = new double[qtd];
            var nomes = new string[qtd];
            var sexos = new string[qtd];

            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Digite o sexo (M ou F): ");
                var sexo = Console.ReadLine() ?? "";

                Console.Write("Digite o nome: ");
                var nome = Console.ReadLine() ?? "";

                Console.Write("Digite o salário: ");
                var salario = double.Parse(Console.ReadLine() ?? "0");

                sexos[i] = sexo;
                nomes[i] = nome;
                salarios[i] = salario;

                Console.WriteLine("-------------------------------");
            }

            Console.Clear();

            Console.WriteLine($"--- Mulheres que ganham mais de R$5 mil ---");

            for (int i = 0; i < qtd; i++)
            {
                var sexo = sexos[i];
                var nome = nomes[i];
                var salario = salarios[i];

                if (sexo == "F")
                {
                    Console.WriteLine($"{nome} - R${salario:F2}");
                }
            }
        }
    }
}
