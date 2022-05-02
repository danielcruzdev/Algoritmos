namespace Algoritmos.Algoritmos
{
    public static class Algoritmo15
    {
        /*
            Crie um programa que leia o número de dias trabalhados em um mês e mostre o
            salário de um funcionário, sabendo que ele trabalha 8 horas por dia e ganha R$25
            por hora trabalhada.
        */
        public static void Execute()
        {
            Console.Write("Digite quantos dias foram trabalhados: ");
            var dias = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite a quantidade de horas trabalhas por dia: ");
            var qtdHorasDia = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o valor da hora trabalhada: ");
            var valorHora = double.Parse(Console.ReadLine() ?? "0");

            var valorTotalReceber = dias * qtdHorasDia * valorHora;

            Console.WriteLine($"Valor total a receber: R${valorTotalReceber:F2}");
        }
    }
}
