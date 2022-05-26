namespace Algoritmos.Algoritmos
{
    public static class Algoritmo76
    {
        /*
            Crie um programa que preencha automaticamente um vetor numérico com 7
            números gerados aleatoriamente pelo computador e depois mostre os valores
            gerados na tela.     
        */

        public static void Start()
        {
            int[] numeros = new int[7];

            for (int i = 0; i < numeros.Length; i++)
            {
                var random = new Random();
                numeros[i] = random.Next(0, 1001);

                Console.Write($"{numeros[i]} | ");
            }
        }
    }
}
