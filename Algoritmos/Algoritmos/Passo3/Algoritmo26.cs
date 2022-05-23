namespace Algoritmos.Algoritmos
{
    public static class Algoritmo26
    {
        /*
            Escreva um algoritmo que leia dois números inteiros e compare-os, mostrando 
            na tela uma das mensagens abaixo:
             - O primeiro valor é o maior
             - O segundo valor é o maior
             - Não existe valor maior, os dois são iguais
        */
        public static void Start()
        {
            Console.Write("Digite um número inteiro: ");
            var numero1 = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite outro número inteiro: ");
            var numero2 = int.Parse(Console.ReadLine() ?? "0");

            if (numero1 == numero2)
                Console.WriteLine("Não existe valor maior, os dois são iguais.");
            else if (numero1 > numero2)
                Console.WriteLine($"O primeiro valor é maior.");
            else
                Console.WriteLine($"O segundo valor é o maior.");
        }
    }
}
