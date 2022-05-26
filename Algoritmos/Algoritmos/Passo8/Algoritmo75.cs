namespace Algoritmos.Algoritmos
{
    public static class Algoritmo75
    {
        /*
            Crie um programa que preencha automaticamente (usando lógica, não apenas
            atribuindo diretamente) um vetor numérico com 15 posições com os primeiros
            elementos da sequência de Fibonacci:       
        */

        public static void Start()
        {
            int[] numeros = new int[16];

            for (int i = 0; i < numeros.Length; i++)
            {
                if (i == 0 || i == 1)
                    numeros[i] = 1;
                else
                {
                    var valor = numeros[i - 2] + numeros[i - 1];
                    numeros[i] = valor;
                }

                Console.Write($"{numeros[i]} | ");
            }
        }
    }
}
