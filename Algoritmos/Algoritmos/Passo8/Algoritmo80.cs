namespace Algoritmos.Algoritmos
{
    public static class Algoritmo80
    {
        /*
            Faça um algoritmo que preencha um vetor de 30 posições com números entre 1 e
            15 sorteados pelo computador. Depois disso, peça para o usuário digitar um
            número (chave) e seu programa deve mostrar em que posições essa chave foi
            encontrada. Mostre também quantas vezes a chave foi sorteada.
        */

        public static void Start()
        {
            int[] numeros = new int[30];

            for (int i = 0; i < numeros.Length; i++)
            {
                var random = new Random();
                var numero = random.Next(1, 16);

                numeros[i] = numero;
            }

            Console.Write("Digite um número de 1 à 15: ");
            var userNumber = int.Parse(Console.ReadLine() ?? "0");

            var qtd = numeros.Count(x => x == userNumber);
            var posicoes = numeros.Select((b, i) => b == userNumber ? i : -1).Where(i => i != -1).ToArray();

            Console.WriteLine($"Qtd do número {userNumber} encontrada: {qtd}");

            if (qtd > 0)
            {
                Console.Write($"Posicões no array: ");
                for (int i = 0; i < posicoes.Length; i++)
                {
                    if (i + 1 == posicoes.Length)
                        Console.Write($"{posicoes[i]}");
                    else
                        Console.Write($"{posicoes[i]}, ");
                }
            }
        }
    }
}
