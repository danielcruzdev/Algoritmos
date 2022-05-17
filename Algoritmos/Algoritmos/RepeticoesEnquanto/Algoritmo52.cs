namespace Algoritmos.Algoritmos
{
    public static class Algoritmo52
    {
        /*
            Crie um algoritmo que leia a idade de 10 pessoas, mostrando no final:
            a) Qual é a média de idade do grupo
            b) Quantas pessoas tem mais de 18 anos
            c) Quantas pessoas tem menos de 5 anos
            d) Qual foi a maior idade lida
        */
        public static void Start()
        {
            var qtd = 10;
            var i = 1;
            var total = 0;
            var maisDe18 = 0;
            var menor5 = 0;
            var maiorIdade = 0;

            while (i <= qtd)
            {
                Console.Write($"{i}º idade: ");
                var idade = int.Parse(Console.ReadLine() ?? "0");

                total += idade;

                if (i == 1)
                    maiorIdade = idade;           
                else
                {
                    if (idade > maiorIdade)
                        maiorIdade = idade;
                }

                if (idade < 5)
                    menor5++;

                if (idade > 18)
                    maisDe18++;
                i++;
            }

            var media = total / qtd;

            Console.WriteLine($"Idade média do grupo: {media}");
            Console.WriteLine($"Maiores de 18 anos: {maisDe18}");
            Console.WriteLine($"Menores de 5 anos: {menor5}");
            Console.WriteLine($"Maior idade do grupo: {maiorIdade}");
        }
    }
}
