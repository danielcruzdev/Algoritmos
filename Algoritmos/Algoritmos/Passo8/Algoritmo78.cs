namespace Algoritmos.Algoritmos
{
    public static class Algoritmo78
    {
        /*
            Escreva um programa que leia 15 números e guarde-os em um vetor. No final,
            mostre o vetor inteiro na tela e em seguida mostre em que posições foram
            digitados valores que são múltiplos de 10.  
        */

        public static void Start()
        {
            double[] numeros = new double[15];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um numero: ");
                var numero = double.Parse(Console.ReadLine() ?? "0");

                numeros[i] = numero;
            }

            Console.Clear();

            for (int i = 0; i < numeros.Length; i++)
            {
                var valor = numeros[i];

                if (valor % 10 == 0)
                    Console.Write($"{valor}({i}) ");
                else
                    Console.Write($"{valor} ");
            }
        }
    }
}
