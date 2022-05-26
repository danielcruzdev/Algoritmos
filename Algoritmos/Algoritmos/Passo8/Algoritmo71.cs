namespace Algoritmos.Algoritmos
{
    public static class Algoritmo71
    {
        /*
            Faça um programa que preencha automaticamente um vetor numérico com 8
            posições, conforme abaixo:
        */
        public static void Start()
        {
            int[] numeros = new int[8];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 999;
                Console.Write($"{numeros[i]} | ");
            }
        }
    }
}
