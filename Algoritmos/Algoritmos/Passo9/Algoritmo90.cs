namespace Algoritmos.Algoritmos
{
    public static class Algoritmo90
    {
        /*
            Desenvolva um algoritmo que leia dois valores pelo teclado e passe esses
            valores para um procedimento Somador() que vai calcular e mostrar a soma entre
            eles.
        */

        public static void Start()
        {
            Console.Write("Digite o primeiro numero: ");
            var numero1 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o segundo numero: ");
            var numero2 = double.Parse(Console.ReadLine() ?? "0");

            Somar(numero1, numero2);
        }

        private static void Somar(double numero1, double numero2) 
        {
            var soma = numero1 + numero2;
            Console.WriteLine($"A soma entre {numero1} e {numero2} é: {soma}");
        }
    }
}
