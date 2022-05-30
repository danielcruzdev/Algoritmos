namespace Algoritmos.Algoritmos
{
    public static class Algoritmo84
    {
        /*
            Crie um programa que leia o nome e a idade de 9 pessoas e guarde esses
            valores em dois vetores, em posições relacionadas. No final, mostre uma listagem
            contendo apenas os dados das pessoas menores de idade.
        */

        public static void Start()
        {
            var qtd = 9;

            var idades = new int[qtd];
            var nomes = new string[qtd];

            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Digite o nome: ");
                var nome = Console.ReadLine() ?? "";

                Console.Write("Digite a idade: ");
                var idade = int.Parse(Console.ReadLine() ?? "0");

                nomes[i] = nome;
                idades[i] = idade;

                Console.WriteLine("-------------------------------");
            }

            Console.Clear();

            Console.WriteLine($"--- Menores de idade ---");

            for (int i = 0; i < qtd; i++)
            {
                var idade = idades[i];
                var nome = nomes[i];

                if(idade < 18)
                {
                    Console.WriteLine($"{nome} - {idade} anos");
                }
            }
        }
    }
}
