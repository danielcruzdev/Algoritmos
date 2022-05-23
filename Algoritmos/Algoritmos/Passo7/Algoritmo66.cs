namespace Algoritmos.Algoritmos
{
    public static class Algoritmo66
    {
        /*
            Desenvolva um programa usando a estrutura “para” que mostre na tela a
            seguinte contagem:
            0 5 10 15 20 25 30 35 40 Acabou!
        */
        public static void Start()
        {
            Console.Write("Digite um número inteiro: ");
            var numero = int.Parse(Console.ReadLine() ?? "0");

            Console.Clear();

            Console.WriteLine($"Tabuada do número: {numero}");
            for (int i = 1; i <= 10; i++)
            {
                var total = numero * i;
                Console.WriteLine($"{numero} x {i} = {total}");
            }
        }
    }
}
