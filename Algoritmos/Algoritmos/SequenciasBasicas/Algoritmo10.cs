namespace Algoritmos.Algoritmos
{
    public static class Algoritmo10
    {
        /*
            Faça um algoritmo que leia a largura e altura de uma parede, calcule e
            mostre a área a ser pintada e a quantidade de tinta necessária para o serviço,
            sabendo que cada litro de tinta pinta uma área de 2metros quadrados.
        */
        public static void Execute()
        {
            const int litrosPorMetroQuadrado = 2;
            Console.Write("Digite a altura da parede: ");
            var altura = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite a largura da parede:  ");
            var largura = double.Parse(Console.ReadLine() ?? "0");

            var metroQuadrado = altura * largura;
            var litrosDeTinta = metroQuadrado / litrosPorMetroQuadrado;

            Console.WriteLine($"A quantidade de tinta necessária para pintar {metroQuadrado}m² é de {litrosDeTinta} litros");
        }
    }
}
