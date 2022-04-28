namespace Algoritmos.Algoritmos
{
    public static class Algoritmo13
    {
        /*
            Faça um algoritmo que leia o salário de um funcionário, calcule e mostre o
            seu novo salário, com 15% de aumento.
        */
        public static void Execute()
        {
            Console.Write("Digite o valor do salário: ");
            var valorSalario = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite a porcentagem do aumento: ");
            var aumento = double.Parse(Console.ReadLine() ?? "0");

            var valorComAumento = valorSalario + (valorSalario * aumento / 100);
            
            Console.WriteLine($"O valor do salário com aumento de {aumento}% será de R${valorComAumento:F2}");
        }
    }
}
