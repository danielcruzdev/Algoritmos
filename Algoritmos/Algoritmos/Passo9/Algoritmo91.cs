namespace Algoritmos.Algoritmos
{
    public static class Algoritmo91
    {
        /*
            Desenvolva um algoritmo que leia dois valores pelo teclado e passe esses
            valores para um procedimento Maior() que vai verificar qual deles é o maior e
            mostrá-lo na tela. Caso os dois valores sejam iguais, mostrar uma mensagem
            informando essa característica.
        */

        public static void Start()
        {
            Console.Write("Digite o primeiro numero: ");
            var numero1 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o segundo numero: ");
            var numero2 = double.Parse(Console.ReadLine() ?? "0");

            Maior(numero1, numero2);
        }

        private static void Maior(double numero1, double numero2) 
        {
            if (numero1 == numero2)
                Console.WriteLine("Os dois numeros são iguais!");
            else if (numero1 > numero2)
                Console.WriteLine($"o número {numero1} é maior que o número {numero2}");
            else
                Console.WriteLine($"o número {numero2} é maior que o número {numero1}");
        }
    }
}
