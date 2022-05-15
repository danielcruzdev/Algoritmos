namespace Algoritmos.Algoritmos
{
    public static class Algoritmo50
    {
        /*
            Desenvolva um programa que faça o sorteio de 20 números entre 0 e 10 e
            mostre na tela:
            a) Quais foram os números sorteados
            b) Quantos números estão acima de 5
            c) Quantos números são divisíveis por 3
        */
        public static void Start()
        {
            var qtd = 20;
            var i = 1;
            var acimaCinco = 0;
            var divisiveisPor3 = 0;

            while (i <= qtd)
            {
                var random = new Random();
                var numero = random.Next(0, 11);
                var resto = numero % 3;

                if (resto == 0)
                    divisiveisPor3++;

                if (numero > 5)
                    acimaCinco++;

                Console.Write($"{numero} ");

                i++; ;
            }
            Console.WriteLine($"Sorteados");
            Console.WriteLine($"Divisiveis por 3: {divisiveisPor3}");
            Console.WriteLine($"Acima de 5: {acimaCinco}");
        }
    }
}
