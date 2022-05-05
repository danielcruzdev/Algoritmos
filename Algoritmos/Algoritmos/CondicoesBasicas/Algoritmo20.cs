namespace Algoritmos.Algoritmos
{
    public static class Algoritmo20
    {
        /*
            Desenvolva um programa que leia um número inteiro e mostre se ele é PAR ou ÍMPAR.
        */
        public static void Start()
        {
            Console.Write("Digite um numero inteiro: ");
            var numero = int.Parse(Console.ReadLine() ?? "0");

            var sobra = numero % 2;

            if (sobra == 0)
                Console.WriteLine($"O número {numero} é par");
            else
                Console.WriteLine($"O número {numero} é impar");
        }
    }
}
