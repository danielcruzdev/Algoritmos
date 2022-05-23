namespace Algoritmos.Algoritmos
{
    public static class Algoritmo29
    {
        /*
         Desenvolva um programa que leia o nome de um funcionário, seu salário,
        quantos anos ele trabalha na empresa e mostre seu novo salário, reajustado de
        acordo com a tabela a seguir:
         - Até 3 anos de empresa: aumento de 3%
         - entre 3 e 10 anos: aumento de 12.5%
         - 10 anos ou mais: aumento de 20%
        */
        public static void Start()
        {
            Console.Write("Digite o nome do funcionario: ");
            var nome = Console.ReadLine();

            Console.Write("Digite o salário do funcionário: ");
            var salario = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite quantos anos o funcionário trabalha na empresa: ");
            var anos = int.Parse(Console.ReadLine() ?? "0");

            double salarioAumento;

            if (anos < 3)
            {
                var valorAumento = salario * 3 / 100;
                salarioAumento = salario + valorAumento;
            }
            else if (anos >= 3 && anos < 10)
            {
                var valorAumento = salario * 12.5 / 100;
                salarioAumento = salario + valorAumento;
            }
            else
            {
                var valorAumento = salario * 20 / 100;
                salarioAumento = salario + valorAumento;
            }

            Console.WriteLine($"O novo salário do funcionario {nome} será de R${salarioAumento:F2}");
        }
    }
}
