namespace Algoritmos.Algoritmos
{
    public static class Algoritmo93
    {
        /*
            Crie uma lógica que leia um número inteiro e passe para um procedimento
            Faça um programa que tenha um procedimento chamado Contador() que recebe
            três valores como parâmetro: o início, o fim e o incremento de uma contagem. O
            programa principal deve solicitar a digitação desses valores e passá-los ao
            procedimento, que vai mostrar a contagem na tela.

            Ex: Para os valores de início (4), fim (20) e incremento(3) teremos
            Contador(4, 20, 3) vai mostrar na tela 4 >> 7 >> 10 >> 13 >> 16 >> 19 >> FIM
        */

        public static void Start()
        {
            Console.Write("Digite o valor inicial: ");
            var inicio = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o valor final: ");
            var final = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o incremento: ");
            var incremento = int.Parse(Console.ReadLine() ?? "0");

            Contador(inicio, final, incremento);
        }

        private static void Contador(int inicio, int fim, int incremento) 
        {
            for (int i = inicio; i < fim; i += incremento)
            {
                Console.Write($"{i} >> ");
            }

            Console.WriteLine("Fim");
        }
    }
}
