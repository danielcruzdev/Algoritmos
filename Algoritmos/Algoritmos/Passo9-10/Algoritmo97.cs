namespace Algoritmos.Algoritmos
{
    public static class Algoritmo97
    {
        /*
            Refaça o exercício 91, só que agora em forma de função Maior(), mas faça uma
            adaptação que vai receber TRÊS números como parâmetro e vai retornar qual foi o
            maior entre eles.
        */


        public static void Start()
        {
            Console.Write("Digite o primeiro número: ");
            var numero1 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o segundo número: ");
            var numero2 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o terceiro número: ");
            var numero3 = double.Parse(Console.ReadLine() ?? "0");

            var maiorNumero = Maior(numero1, numero2, numero3);

            Console.WriteLine($"O maior número digitado foi: {maiorNumero}");
        }

        private static double Maior(double numero1, double numero2, double numero3)
        {
            var numeros = new double[3];

            numeros[0] = numero1;
            numeros[1] = numero2;
            numeros[2] = numero3;

            return numeros.Max();
        }
    }
}
