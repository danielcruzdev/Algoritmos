namespace Algoritmos.Algoritmos
{
    public static class Algoritmo92
    {
        /*
            Crie uma lógica que leia um número inteiro e passe para um procedimento
            ParOuImpar() que vai verificar e mostrar na tela se o valor passado como
            parâmetro é PAR ou ÍMPAR.
        */

        public static void Start()
        {
            Console.Write("Digite um número inteiro: ");
            var numero = int.Parse(Console.ReadLine() ?? "0");

            ParOuImpar(numero);
        }

        private static void ParOuImpar(double numero) 
        {
            if (numero % 2 == 0)
                Console.WriteLine($"O número {numero} é PAR");
            else
                Console.WriteLine($"O número {numero} é IMPAR");
        }
    }
}
