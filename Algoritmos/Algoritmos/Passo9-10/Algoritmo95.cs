namespace Algoritmos.Algoritmos
{
    public static class Algoritmo95
    {
        /*
            Refaça o exercício 90, só que agora em forma de função Somador(), que vai
            receber dois parâmetros e vai retornar o resultado da soma entre eles para o
            programa principal.
        */


        public static void Start()
        {
            Console.Write("Digite o primeiro numero: ");
            var numero1 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o segundo numero: ");
            var numero2 = double.Parse(Console.ReadLine() ?? "0");

            var resultado = Somar(numero1, numero2);

            Console.WriteLine($"A soma entre {numero1} e {numero2} é: {resultado}");
        }

        private static double Somar(double numero1, double numero2) => numero1 + numero2;
    }
}
