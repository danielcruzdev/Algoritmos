namespace Algoritmos.Algoritmos
{
    public static class Algoritmo6
    {
        /*
            Faça um programa que leia um número inteiro e mostre o seu antecessor e seu
            sucessor.
            Ex:
            Digite um número: 9
            O antecessor de 9 é 8
            O sucessor de 9 é 10
        */
        public static void Start()
        {
            Console.Write("Digite um Número: ");
            var numero = double.Parse(Console.ReadLine() ?? "0");
            var sucessor = numero + 1;
            var antecessor = numero - 1;

            Console.WriteLine($"O sucessor de {numero} é {sucessor}");
            Console.WriteLine($"O antecessor de {numero} é {antecessor}");
        }
    }
}
