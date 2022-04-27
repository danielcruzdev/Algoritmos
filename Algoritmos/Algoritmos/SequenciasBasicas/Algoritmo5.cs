namespace Algoritmos.Algoritmos
{
    public static class Algoritmo5
    {
        /*
         * Faça um programa que leia as duas notas de um aluno em uma matéria e mostre na tela a sua média na disciplina.
         * Ex: Nota 1: 4.5
         * Nota 2: 8.5
         * A média entre 4.5 e 8.5 é igual a 6.5
         */
        public static void Execute()
        {
            Console.Write("Nota 1: ");
            var nota1 = Console.ReadLine();
            Console.Write("Nota 2: ");
            var nota2 = Console.ReadLine();

            var soma = double.Parse(nota1.Replace(".", ",")) + double.Parse(nota2.Replace(".", ","));
            var media = soma / 2;

            Console.WriteLine($"A média entre {nota1} e {nota2} é igual a {media.ToString().Replace(",", ".")}");
        }
    }
}
