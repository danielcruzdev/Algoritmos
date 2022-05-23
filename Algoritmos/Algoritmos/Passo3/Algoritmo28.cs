namespace Algoritmos.Algoritmos
{
    public static class Algoritmo28
    {
        /*
            Faça um programa que leia a largura e o comprimento de um terreno
            retangular, calculando e mostrando a sua área em m². O programa também
            devemostrar a classificação desse terreno, de acordo com a lista abaixo:
             - Abaixo de 100m² = TERRENO POPULAR
             - Entre 100m² e 500m² = TERRENO MASTER
             - Acima de 500m² = TERRENO VIP
        */
        public static void Start()
        {
            Console.Write("Digite a largura do terreno: ");
            var largura = float.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite o comprimento do terreno: ");
            var comprimento = float.Parse(Console.ReadLine() ?? "0");

            var metrosQuadrados = largura * comprimento;
            Console.WriteLine($"Terreno: {metrosQuadrados:F2}m²");

            if (metrosQuadrados < 100)
                Console.WriteLine("Terreno Popular");
            else if (metrosQuadrados >= 100 && metrosQuadrados <= 500)
                Console.WriteLine("Terreno Master");
            else
                Console.WriteLine("Terreno Vip");
        }
    }
}
