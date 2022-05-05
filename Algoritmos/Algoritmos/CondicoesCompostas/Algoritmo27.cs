namespace Algoritmos.Algoritmos
{
    public static class Algoritmo27
    {
        /*
        Crie um programa que leia duas notas de um aluno e calcule a sua média, 
        mostrando uma mensagem no final, de acordo com a média atingida:
         - Média até 4.9: REPROVADO
         - Média entre 5.0 e 6.9: RECUPERAÇÃO
         - Média 7.0 ou superior: APROVADO
        */
        public static void Start()
        {
            const float REPROVADO = 4.9f;
            const float APROVADO = 7.0f;

            Console.Write("Digite a primeira nota: ");
            var nota1 = float.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite a segunda nota: ");
            var nota2 = float.Parse(Console.ReadLine() ?? "0");

            var media = (nota1 + nota2) / 2;
            Console.WriteLine($"Média: {media}");

            if (media >= APROVADO)
                Console.WriteLine("Você foi Aprovado.");
            else if (media <= REPROVADO)
                Console.WriteLine("Você foi Reprovado.");
            else
                Console.WriteLine("Você vai para a Recuperação.");
        }
    }
}
