namespace Algoritmos.Algoritmos
{
    public static class Algoritmo79
    {
        /*
            Desenvolva um programa que leia 10 números inteiros e guarde-os em um vetor.
            No final, mostre quais são os números pares que foram digitados e em que
            posições eles estão armazenados.
        */

        public static void Start()
        {
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um número inteiro: ");
                var numero = int.Parse(Console.ReadLine() ?? "0");

                numeros[i] = numero;
            }

            Console.Clear();

            for (int i = 0; i < numeros.Length; i++)
            {
                var valor = numeros[i];

                if (valor % 2 == 0)
                    Console.Write($"{valor}({i}) ");
                else
                    Console.Write($"{valor} ");
            }
        }
    }
}
