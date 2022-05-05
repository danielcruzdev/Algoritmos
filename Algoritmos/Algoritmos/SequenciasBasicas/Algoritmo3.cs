namespace Algoritmos.Algoritmos
{
    public static class Algoritmo3
    {
        /*
         * Crie um programa que leia o nome e o salário de um funcionário, mostrando no final uma mensagem.
         * Ex: 
         * Nome do Funcionário: Maria do Carmo 
         * Salário: 1850,45
         * O funcionário Maria do Carmo tem um salário de R$1850,45 em Junho.
         */
        public static void Start()
        {
            Console.Write("Nome do Funcionário: ");
            var nome = Console.ReadLine();
            Console.Write("Salário: ");
            var salario = Console.ReadLine();
            Console.WriteLine($"O funcionário(a) {nome} tem um salário de R${salario} em {DateTime.Now:MMMM}.");
        }
    }
}
