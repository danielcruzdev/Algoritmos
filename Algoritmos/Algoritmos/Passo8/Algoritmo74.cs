namespace Algoritmos.Algoritmos
{
    public static class Algoritmo74
    {
        /*
            Crie um programa que preencha automaticamente (usando lógica, não apenas
            atribuindo diretamente) um vetor numérico com 10 posições, conforme abaixo:
                                5 3 5 3 5 3 5 3 5 3
                                0 1 2 3 4 5 6 7 8 9       
        */

        public static void Start()
        {
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                int valor;
                if (i % 2 == 0)
                    valor = 5;
                else
                    valor = 3;

                numeros[i] = valor;
                Console.Write($"{numeros[i]} | ");
            }
        }
    }
}
