namespace Algoritmos.Algoritmos
{
    public static class Algoritmo82
    {
        /*
            Faça um algoritmo que leia a nota de 10 alunos de uma turma e guarde-as em
            um vetor. No final, mostre:
            a) Qual é a média da turma
            b) Quantos alunos estão acima da média da turma
            c) Qual foi a maior nota digitada
            d) Em que posições a maior nota aparece
        */

        public static void Start()
        {
            var notas = new double[10];

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Digite a nota: ");
                var nota = double.Parse(Console.ReadLine() ?? "0");
                notas[i] = nota;
            }

            var mediaTurma = notas.Average();
            var maiorNota = notas.Max();
            var maioresNotasPosicoes = notas.Select((b, i) => b == maiorNota ? i : -1).Where(i => i != -1).ToArray();
            var qtdAlunosAcimaMedia = notas.Count(x => x > mediaTurma);

            Console.WriteLine($"Média da turma: {mediaTurma}");
            Console.WriteLine($"Maior nota: {maiorNota}");
            Console.WriteLine($"Qtd. Alunos acima da média: {qtdAlunosAcimaMedia}");

            Console.Write($"Posições que temos as maiores notas: ");
            for (int i = 0; i < maioresNotasPosicoes.Length; i++)
            {
                if (i + 1 == maioresNotasPosicoes.Length)
                    Console.WriteLine($"{maioresNotasPosicoes[i]}");
                else
                    Console.Write($"{maioresNotasPosicoes[i]}, ");
            }
        }
    }
}
