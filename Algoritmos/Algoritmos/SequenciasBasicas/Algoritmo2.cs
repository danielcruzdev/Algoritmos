namespace Algoritmos.Algoritmos
{
    public static class Algoritmo2
    {
        /*
         * Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boasvindas para ela:
         * Ex:
         * Qual é o seu nome? João da Silva
         * Olá João da Silva, é um prazer te conhecer!
         */
        public static void Start()
        {
            Console.Write("Qual é o seu nome? ");
            var nome = Console.ReadLine();
            Console.WriteLine($"Olá {nome}, é um prazer te conhecer!");
        }
    }
}
