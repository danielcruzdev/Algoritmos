namespace Algoritmos.Algoritmos
{
    public static class Algoritmo59
    {
        /*
             Crie um programa que leia o sexo e a idade de várias pessoas. O programa vai
            perguntar se o usuário quer continuar ou não a cada pessoa. No final, mostre:
            a) qual é a maior idade lida
            b) quantos homens foram cadastrados
            c) qual é a idade da mulher mais jovem
            d) qual é a média de idade entre os homens
        */
        public static void Start()
        {
            var maiorIdade = 0;
            var qtdHomens = 0;
            var mulherMaisJovem = 200;
            var idadeTotalHomens = 0;

            string continuar;
            do
            {
                Console.Write("Digite o sexo (M ou F): ");
                var sexo = Console.ReadLine().ToUpper();

                Console.Write("Digite a idade: ");
                var idade = int.Parse(Console.ReadLine() ?? "0");

                if(idade > maiorIdade)
                    maiorIdade = idade;

                if (sexo == "M")
                {
                    qtdHomens++;
                    idadeTotalHomens += idade;
                } 
                else
                {
                    if (idade < mulherMaisJovem)
                        mulherMaisJovem = idade;
                }

                Console.Write($"Continuar? (S ou N): ");
                continuar = Console.ReadLine() ?? "N";
                continuar = continuar.ToUpper();

                Console.WriteLine("--------------------------------");

            } while (continuar == "S");

            var mediaIdadeHomens = idadeTotalHomens / qtdHomens;

            Console.WriteLine($"Maior idade lida: {maiorIdade}");
            Console.WriteLine($"Qtd. Homens: {qtdHomens}");
            Console.WriteLine($"Média idade homens: {mediaIdadeHomens}");
            Console.WriteLine($"Idade da mulher mais jovem: {mulherMaisJovem}");
        }
    }
}
