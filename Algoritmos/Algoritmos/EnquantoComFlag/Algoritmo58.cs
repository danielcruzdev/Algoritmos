namespace Algoritmos.Algoritmos
{
    public static class Algoritmo58
    {
        /*
             Faça um algoritmo que leia a idade de vários alunos de uma turma. O programa
            vai parar quando for digitada a idade 999. No final, mostre quantos alunos
            existem na turma e qual é a média de idade do grupo.
        */
        public static void Start()
        {
            var totalIdade = 0;
            var qtdAlunos = 0;
            int idade;

            do
            {
                Console.Write("Digite a idade do aluno: ");
                idade = int.Parse(Console.ReadLine() ?? "999");

                if(idade != 999)
                {
                    qtdAlunos++;
                    totalIdade += idade;
                }

            } while (idade != 999);

            var mediaIdadeTurma = totalIdade / qtdAlunos;

            Console.WriteLine($"Total de alunos: {qtdAlunos}");
            Console.WriteLine($"Média idade da turma: {mediaIdadeTurma}");
        }
    }
}