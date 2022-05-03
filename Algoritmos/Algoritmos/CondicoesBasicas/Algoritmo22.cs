namespace Algoritmos.Algoritmos
{
    public static class Algoritmo22
    {
        /*
          Escreva um programa que leia o ano de nascimento de um rapaz e mostre a sua situação em relação ao alistamento militar.
             - Se estiver antes dos 18 anos, mostre em quantos anos faltam para o
            alistamento.
             - Se já tiver depois dos 18 anos, mostre quantos anos já se passaram do
            alistamento.
        */
        public static void Execute()
        {
            Console.Write("Digite seu ano de nascimento: ");
            var nascimento = int.Parse(Console.ReadLine() ?? "0");
            var idade = DateTime.Now.Year - nascimento;
            var diferenca = idade - 18;

            if (idade < 18)
                Console.WriteLine($"Ainda falta {diferenca * -1} ano(s) para você se alistar");
            else if (idade == 18)
                Console.WriteLine($"Você deve se alistar esse ano no serviço militar!");
            else
                Console.WriteLine($"Você deveria ter se alistado a {diferenca} ano(s) atrás");
        }
    }
}
