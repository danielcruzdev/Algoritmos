namespace Algoritmos.Algoritmos
{
    public static class Algoritmo83
    {
        /*
            [DESAFIO] Crie uma lógica que preencha um vetor de 20 posições com números
            aleatórios (entre 0 e 99) gerados pelo computador. Logo em seguida, mostre os
            números gerados e depois coloque o vetor em ordem crescente, mostrando no final
            os valores ordenados.
        */

        public static void Start()
        {
            var numeros = new int[20];

            for (int i = 0; i < numeros.Length; i++)
            {
                var random = new Random();
                var numero = random.Next(0, 100);
                numeros[i] = numero;
            }

            Console.WriteLine("Numeros desordenados");
            foreach (var valor in numeros)
            {
                Console.Write($"{valor} ");
            }

            Console.WriteLine();

            Console.WriteLine("Numeros ordenados");
            foreach (var valor in numeros.OrderBy(x => x))
            {
                Console.Write($"{valor} ");
            }
        }
    }
}
