namespace Algoritmos.Algoritmos
{
    public static class Algoritmo81
    {
        /*
            Crie um programa que leia a idade de 8 pessoas e guarde-as em um vetor. No
            final, mostre:
            a) Qual é a média de idade das pessoas cadastradas
            b) Em quais posições temos pessoas com mais de 25 anos
            c) Qual foi a maior idade digitada (podem haver repetições)
            d) Em que posições digitamos a maior idade
        */

        public static void Start()
        {
            int[] idades = new int[8];

            for (int i = 0; i < idades.Length; i++)
            {
                Console.Write("Idade da pessoa: ");
                var idade = int.Parse(Console.ReadLine() ?? "0");
                idades[i] = idade;
            }

            var mediaIdade = idades.Average();
            var maiorIdade = idades.Max();
            var mais25AnosPosicoes = idades.Select((b, i) => b > 25 ? i : -1).Where(i => i != -1).ToArray();
            var maioresIdadesPosicoes = idades.Select((b, i) => b == maiorIdade ? i : -1).Where(i => i != -1).ToArray();

            Console.WriteLine($"Média de idade: {mediaIdade}");
            Console.WriteLine($"Maior idade: {maiorIdade}");

            if(mais25AnosPosicoes.Length > 0)
            {
                Console.Write($"Posições que temos pessoas com mais de 25 anos: ");
                for (int i = 0; i < mais25AnosPosicoes.Length; i++)
                {
                    if (i + 1 == mais25AnosPosicoes.Length)
                        Console.WriteLine($"{mais25AnosPosicoes[i]}");
                    else
                        Console.Write($"{mais25AnosPosicoes[i]}, ");
                }
            }

            if (maioresIdadesPosicoes.Length > 0)
            {
                Console.Write($"Posições que temos as maiores idades: ");
                for (int i = 0; i < maioresIdadesPosicoes.Length; i++)
                {
                    if (i + 1 == maioresIdadesPosicoes.Length)
                        Console.Write($"{maioresIdadesPosicoes[i]}");
                    else
                        Console.Write($"{maioresIdadesPosicoes[i]}, ");
                }
            }
        }
    }
}
