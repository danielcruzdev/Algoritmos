namespace Algoritmos.Algoritmos
{
    public static class Algoritmo62
    {
        /*
             Faça um programa usando a estrutura “faça enquanto” que leia a idade de
            várias pessoas. A cada laço, você deverá perguntar para o usuário se ele quer ou
            não continuar a digitar dados. No final, quando o usuário decidir parar, mostre
            na tela:
            a) Quantas idades foram digitadas
            b) Qual é a média entre as idades digitadas
            c) Quantas pessoas tem 21 anos ou mais.
        */
        public static void Start()
        {
            var qtdPessoas = 0;
            var totalIdadeGrupo = 0;
            var pessoasMais21Anos = 0;

            string continuar;
            do
            {
                Console.Write("Digite a idade: ");
                var idade = int.Parse(Console.ReadLine() ?? "0");

                qtdPessoas++;
                totalIdadeGrupo += idade;

                if (idade >= 21)
                    pessoasMais21Anos++;

                Console.Write($"Continuar? (S ou N): ");
                continuar = Console.ReadLine() ?? "N";
                continuar = continuar.ToUpper();

                Console.WriteLine("--------------------------------");

            } while (continuar == "S");

            int mediaIdade = totalIdadeGrupo / qtdPessoas;

            Console.WriteLine($"Qtd. Pessoas: {qtdPessoas}");
            Console.WriteLine($"Pessoas com 21 anos ou mais: {pessoasMais21Anos}");
            Console.WriteLine($"Media de idade grupo: {mediaIdade}");
        }
    }
}
