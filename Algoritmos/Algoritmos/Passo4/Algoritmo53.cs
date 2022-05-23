namespace Algoritmos.Algoritmos
{
    public static class Algoritmo53
    {
        /*
            Faça um programa que leia a idade e o sexo de 5 pessoas, mostrando no final:
            a) Quantos homens foram cadastrados
            b) Quantas mulheres foram cadastradas
            c) A média de idade do grupo
            d) A média de idade dos homens
            e) Quantas mulheres tem mais de 20 anos
        */
        public static void Start()
        {
            var i = 1;
            var qtd = 5;
            var qtdMulheres = 0;
            var qtdHomens = 0;
            var totalIdadeGrupo = 0;
            var totalIdadeHomens = 0;
            var qtdMulherMais20Anos = 0;

            while (i <= qtd)
            {
                Console.WriteLine($"{i}º Pessoa");
                Console.Write($"Sexo (M ou F): ");
                var sexo = Console.ReadLine();

                Console.Write($"Idade: ");
                var idade = int.Parse(Console.ReadLine() ?? "0");

                totalIdadeGrupo += idade;

                if (sexo == "F")
                {
                    qtdMulheres++;

                    if (idade > 20)
                        qtdMulherMais20Anos++;
                }
                else
                {
                    qtdHomens++;
                    totalIdadeHomens += idade;
                }

                i++;
            }

            var mediaGrupo = totalIdadeGrupo / qtd;
            var mediaHomens = totalIdadeHomens / qtdHomens;

            Console.WriteLine($"Qtd. Homens: {qtdHomens}");
            Console.WriteLine($"Qtd. Mulheres: {qtdMulheres}");
            Console.WriteLine($"Qtd. Mulhere com mais de 20 anos: {qtdMulherMais20Anos}");
            Console.WriteLine($"Média de idade do grupo: {mediaGrupo} anos");
            Console.WriteLine($"Média de idade dos homens: {mediaHomens} anos");
        }
    }
}
