namespace Algoritmos.Algoritmos
{
    public static class Algoritmo44
    {
        /*
         Crie um algoritmo que leia o valor inicial da contagem, o valor final e o incremento, mostrando em seguida todos os valores no intervalo:
        Ex: Digite o primeiro Valor: 3
        Digite o último Valor: 10
        Digite o incremento: 2
        Contagem: 3 5 7 9 Acabou!
        */
        public static void Start()
        {
            Console.WriteLine("Digite o primeiro valor: ");
            var first = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Digite o ultimo valor: ");
            var last = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Digite o incremento: ");
            var increment = int.Parse(Console.ReadLine() ?? "0");

            var i = first;
            while (i <= last)
            {
                Console.Write($"{i} ");
                i += increment;
            }
            Console.WriteLine("Acabou!");
        }
    }
}
