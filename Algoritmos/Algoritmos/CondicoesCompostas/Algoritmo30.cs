namespace Algoritmos.Algoritmos
{
    public static class Algoritmo30
    {
        /*
            [DESAFIO - 25] Crie um programa que leia o tamanho de três segmentos de reta.
            Analise seus comprimentos e diga se é possível formar um triângulo com essas
            retas. Matematicamente, para três segmentos formarem um triângulo, o comprimento
            de cada lado deve ser menor que a soma dos outros dois.

            [DESAFIO] Refaça o algoritmo 25, acrescentando o recurso de mostrar que tipo de triângulo será formado:
             - EQUILÁTERO: todos os lados iguais
             - ISÓSCELES: dois lados iguais
             - ESCALENO: todos os lados diferentes
        */
        public static void Start()
        {
            Console.Write("Valor reta a: ");
            var retaA = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Valor reta b: ");
            var retaB = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Valor reta c: ");
            var retaC = double.Parse(Console.ReadLine() ?? "0");

            if ((retaA + retaB) > retaC &&
                (retaA + retaC) > retaB &&
                (retaB + retaC) > retaA)
            {
                string? type;
                if (retaA != retaB && retaA != retaC && retaC != retaB)
                    type = "escaleno";
                else if (retaA == retaB && retaA == retaC && retaC == retaB)
                    type = "equilátero";
                else
                    type = "isósceles";

                Console.WriteLine($"As retas informadas formam um triângulo {type}");
            }
            else
            {
                Console.WriteLine("As retas informadas não podem formar um triângulo!");
            }


        }
    }
}
