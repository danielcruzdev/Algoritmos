namespace Algoritmos.Algoritmos
{
    public static class Algoritmo94
    {
        /*
             [DESAFIO] Desenvolva um aplicativo que tenha um procedimento chamado
            Fibonacci() que recebe um único valor inteiro como parâmetro, indicando quantos
            termos da sequência serão mostrados na tela. O seu procedimento deve receber
            esse valor e mostrar a quantidade de elementos solicitados.
            Obs: Use os exercícios 70 e 75 para te ajudar na solução
            Ex:
            Fibonacci(5) vai gerar 1 >> 1 >> 2 >> 3 >> 5 >> FIM
            Fibonacci(9) vai gerar 1 >> 1 >> 2 >> 3 >> 5 >> 8 >> 13 >> 21 >> 34 >> FIM
        */

        public static void Start()
        {
            Fibonacci(30);
        }

        private static void Fibonacci(int qtd)
        {
            var numero1 = 1;
            var numero2 = 1;

            Console.Write($"{numero1} >> {numero2} >> ");
            if (qtd > 2)
            {
                for (int i = 2; i < qtd; i++)
                {
                    var numero3 = numero1 + numero2;
                    Console.Write($"{numero3} >> ");

                    numero1 = numero2;
                    numero2 = numero3;

                }
            }

            Console.Write($"FIM");
        }
    }
}
