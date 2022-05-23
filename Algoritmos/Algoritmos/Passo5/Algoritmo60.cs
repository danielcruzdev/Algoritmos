namespace Algoritmos.Algoritmos
{
    public static class Algoritmo60
    {
        /*
             Desenvolva um algoritmo que leia o nome, a idade e o sexo de várias pessoas.
            O programa vai perguntar se o usuário quer ou não continuar. No final, mostre:
            a) O nome da pessoa mais velha
            b) O nome da mulher mais jovem
            c) A média de idade do grupo
            d) Quantos homens tem mais de 30 anos
            e) Quantas mulheres tem menos de 18 anos
        */
        public static void Start()
        {
            var pessoaMaisVelhaNome = "";
            var pessoaMaisVelhaIdade = 0;

            var mulherMaisJovemNome = "";
            var mulherMaisJovemIdade = 200;

            var idadeTotalGrupo = 0;
            var qtdPessoaGrupo = 0;

            var homensMais30Anos = 0;
            var mulheresMenos18Anos = 0;

            string continuar;
            do
            {
                Console.Write("Digite seu nome: ");
                var nome = Console.ReadLine();

                Console.Write("Digite o sexo (M ou F): ");
                var sexo = Console.ReadLine().ToUpper();

                Console.Write("Digite a idade: ");
                var idade = int.Parse(Console.ReadLine() ?? "0");

                qtdPessoaGrupo++;
                idadeTotalGrupo += idade;

                if(idade > pessoaMaisVelhaIdade)
                {
                    pessoaMaisVelhaIdade = idade;
                    pessoaMaisVelhaNome = nome;
                }

                if(sexo == "F")
                {
                    if(idade < mulherMaisJovemIdade)
                    {
                        mulherMaisJovemIdade = idade;
                        mulherMaisJovemNome = nome;
                    }

                    if (idade < 18)
                        mulheresMenos18Anos++;
                }
                else
                {
                    if (idade > 30)
                        homensMais30Anos++;
                }


                Console.Write($"Continuar? (S ou N): ");
                continuar = Console.ReadLine() ?? "N";
                continuar = continuar.ToUpper();

                Console.WriteLine("--------------------------------");

            } while (continuar == "S");

            var mediaIdadeGrupo = idadeTotalGrupo / qtdPessoaGrupo;

            Console.WriteLine($"Pessoa mais velha: {pessoaMaisVelhaNome}");
            Console.WriteLine($"Mulher mais jovem: {mulherMaisJovemNome}");
            Console.WriteLine($"Media de idade grupo: {mediaIdadeGrupo}");
            Console.WriteLine($"Homens com mais de 30 anos: {homensMais30Anos}");
            Console.WriteLine($"Mulheres com menos de 18 anos: {mulheresMenos18Anos}");
        }
    }
}
