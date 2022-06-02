namespace Algoritmos.Algoritmos
{
    public static class Algoritmo100
    {
        /*
            Melhore o exercício 96, criando além da função Media() uma outra função
            chamada Situacao(), que vai retornar para o programa principal se o aluno está
            APROVADO, em RECUPERAÇÃO ou REPROVADO. Essa nova função, vai receber como
            parâmetro o resultado retornado pela função Media().
        */


        public static void Start()
        {
            Console.Write("Digite a primeira nota: ");
            var nota1 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite a segunda nota: ");
            var nota2 = double.Parse(Console.ReadLine() ?? "0");

            var media = Media(nota1, nota2);
            var situacao = Situacao(media);

            Console.WriteLine($"A média do aluno é: {media}");
            Console.WriteLine($"Situação do aluno: {situacao}");
        }

        private static double Media(double nota1, double nota2) => (nota1 + nota2) / 2;

        private static string Situacao(double media)
        {

            if (media > 7)
                return "Aprovado!";
            else if (media <= 7 && media >= 5)
                return "Recuperação";
            else
                return "Reprovado!";
        }
    }
}
