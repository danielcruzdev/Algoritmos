namespace Algoritmos.Algoritmos
{
    public static class Algoritmo73
    {
        /*
            Crie um programa que preencha automaticamente (usando lógica, não apenas
            atribuindo diretamente) um vetor numérico com 10 posições, conforme abaixo:
        */
        public static void Start()
        {
            int[] numeros = new int[10];

            var valor = 9;
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = valor;
                Console.Write($"{numeros[i]} | ");
                valor--;
            }
        }
    }
}
