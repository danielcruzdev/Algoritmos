namespace Algoritmos.Algoritmos
{
    public static class Algoritmo37
    {
        /*
            Uma empresa precisa reajustar o salário dos seus funcionários, dando um
            aumento de acordo com alguns fatores. Faça um programa que leia o salário atual,
            o gênero do funcionário e há quantos anos esse funcionário trabalha na empresa.
            No final, mostre o seu novo salário, baseado na tabela a seguir:
            - Mulheres
             - menos de 15 anos de empresa: +5%
             - de 15 até 20 anos de empresa: +12%
             - mais de 20 anos de empresa: +23%
            - Homens
             - menos de 20 anos de empresa: +3%
             - de 20 até 30 anos de empresa: +13%
             - mais de 30 anos de empresa: +25%
        */
        public static void Start()
        {
            Console.Write("Digite seu sexo (1 - Homem | 2 - Mulher): ");
            var genero = (Genero)int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite seu salário: ");
            var salario = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Há quantos anos você trabalha na empresa? ");
            var anos = int.Parse(Console.ReadLine() ?? "0");

            int porcentagemAumento;
            if (genero == Genero.Mulher)
            {
                if (anos < 15)
                    porcentagemAumento = 5;
                else if (anos >= 15 && anos <= 20)
                    porcentagemAumento = 12;
                else
                    porcentagemAumento = 23;
            }
            else
            {
                if (anos < 20)
                    porcentagemAumento = 3;
                else if (anos >= 20 && anos <= 30)
                    porcentagemAumento = 13;
                else
                    porcentagemAumento = 25;
            }

            var aumento = salario * porcentagemAumento / 100;
            salario += aumento;

            Console.WriteLine($"Você terá um aumento de {porcentagemAumento}% no salário por trabalhar {anos} anos na empresa!");
            Console.WriteLine($"Aumento: R${aumento:F2}");
            Console.WriteLine($"Salário Atualizado: R${salario:F2}");
        }
    }

    public enum Genero
    {
        Homem = 1,
        Mulher = 2
    }
}
