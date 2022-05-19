namespace Algoritmos.Algoritmos
{
    public static class Algoritmo56
    {
        /*
            Crie um programa que leia vários números pelo teclado e mostre no final o
            somatório entre eles.
            Obs: O programa será interrompido quando o número 1111 for digitado
        */
        public static void Start()
        {
            var total = 0;
            int numero;

            do
            {
                Console.Write("Digite um número inteiro: ");
                numero = int.Parse(Console.ReadLine() ?? "0");
                total += numero;
            } while (numero != 1111);

            Console.WriteLine($"Soma total: {total}");
        }
    }
}