namespace Algoritmos.Algoritmos
{
    public static class Algoritmo98
    {
        /*
             Crie um programa que tenha uma função SuperSomador(), que vai receber dois
            números como parâmetro e depois vai retornar a soma de todos os valores no
            intervalo entre os valores recebidos.
            Ex:
            SuperSomador(1, 6) vai somar 1 + 2 + 3 + 4 + 5 + 6 e vai retornar 21
            SuperSomador(15, 19) vai somar 15 + 16 + 17 + 18 + 19 e vai retornar 85
        */


        public static void Start()
        {
            var soma = SuperSomador(15, 19);

            Console.WriteLine($"Resultado: {soma}");
        }

        private static int SuperSomador(int inicio, int fim)
        {
            var total = 0;
            for (int i = inicio; i <= fim; i++)
                total += i;
            
            return total;
        }
    }
}
