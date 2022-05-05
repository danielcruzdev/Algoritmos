namespace Algoritmos.Algoritmos
{
    public static class Algoritmo7
    {
        /*
            Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a
            sua terça parte.
            Ex:
            Digite um número: 3.5
            O dobro de 3.5 é 7.0
            A terça parte de 3.5 é 1.16666
        */
        public static void Start()
        {
            Console.Write("Digite um Número: ");
            var numero = double.Parse(Console.ReadLine() ?? "0");
            var dobro = numero * 2;
            var tercaParte = numero / 3;

            Console.WriteLine($"O dobro de {numero} é {dobro:F1}");
            Console.WriteLine($"A terça parte de {numero} é {tercaParte:F5}");
        }
    }
}
