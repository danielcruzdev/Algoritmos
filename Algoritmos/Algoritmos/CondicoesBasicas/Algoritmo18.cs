namespace Algoritmos.Algoritmos
{
    public static class Algoritmo18
    {
        /*
            Faça um programa que leia o ano de nascimento de uma pessoa, calcule a idade
            dela e depois mostre se ela pode ou não votar.
        */
        public static void Execute()
        {
            Console.Write("Digite seu ano de nascimento: ");
            var anoNascimento = int.Parse(Console.ReadLine() ?? "0");
            var idade = DateTime.Now.Year - anoNascimento;

            if (idade < 16)
                Console.WriteLine($"Com {idade} anos você ainda não pode votar!");
            else if (idade == 16 || idade == 17)
                Console.WriteLine($"Com {idade} anos você já pode votar, mas não é obrigatório!");
            else
                Console.WriteLine($"Com {idade} anos você já pode votar, e o voto é obrigatório!");
        }
    }
}
