namespace Algoritmos.Algoritmos
{
    public static class Algoritmo11
    {
        /*
            Desenvolva uma lógica que leia os valores de A, B e C de uma equação do
            segundo grau e mostre o valor de Delta.
            delta = b² - 4ac
        */
        public static void Start()
        {
            Console.Write("Digite o valor de A: ");
            var a = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o valor de B: ");
            var b = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o valor de C: ");
            var c = double.Parse(Console.ReadLine() ?? "0");

            var delta = Math.Pow(b, 2) - 4 * a * c;

            Console.WriteLine($"O valor de delta é: {delta}");
        }
    }
}
