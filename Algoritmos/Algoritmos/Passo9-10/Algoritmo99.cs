namespace Algoritmos.Algoritmos
{
    public static class Algoritmo99
    {
        /*
             Faça um programa que possua uma função chamada Potencia(), que vai receber
            dois parâmetros numéricos (base e expoente) e vai calcular o resultado da
            exponenciação.
            Ex: Potencia(5,2) vai calcular 52 = 25 
        */


        public static void Start()
        {
            var resultado = Potencia(12, 2);

            Console.WriteLine($"Resultado: {resultado}");
        }

        private static double Potencia(int numero, int expoente)
        {
            return Math.Pow(numero, expoente);
        }
    }
}
