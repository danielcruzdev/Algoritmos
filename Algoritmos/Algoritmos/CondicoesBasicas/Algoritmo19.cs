namespace Algoritmos.Algoritmos
{
    public static class Algoritmo19
    {
        /*
            Crie um algoritmo que leia o nome e as duas notas de um aluno, calcule a sua
            média e mostre na tela. No final, analise a média e mostre se o aluno teve ou
            não um bom aproveitamento (se ficou acima da média 7.0).
        */
        public static void Start()
        {
            const double acimaMedia = 7.0F;

            Console.Write("Digite o nome do aluno: ");
            var aluno = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            var nota1 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite a segunda nota: ");
            var nota2 = double.Parse(Console.ReadLine() ?? "0");

            var total = nota1 + nota2;
            var media = total / 2;

            if (media > acimaMedia)
                Console.WriteLine($"O aluno {aluno} ficou acima da média (7.0), com a média {media}");
            else
                Console.WriteLine($"O aluno {aluno} ficou abaixo da média (7.0), com a média {media}");
        }
    }
}
