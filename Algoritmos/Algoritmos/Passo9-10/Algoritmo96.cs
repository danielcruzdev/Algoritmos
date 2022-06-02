namespace Algoritmos.Algoritmos
{
    public static class Algoritmo96
    {
        /*
             Crie um programa que tenha uma função Media(), que vai receber as 2 notas de
             um aluno e retornar a sua média para o programa principal.
        */


        public static void Start()
        {
            Console.Write("Digite a primeira nota: ");
            var nota1 = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite a segunda nota: ");
            var nota2 = double.Parse(Console.ReadLine() ?? "0");

            var resultado = Media(nota1, nota2);

            Console.WriteLine($"A média do aluno é: {resultado}");
        }

        private static double Media(double nota1, double nota2) => (nota1 + nota2) / 2;
    }
}
