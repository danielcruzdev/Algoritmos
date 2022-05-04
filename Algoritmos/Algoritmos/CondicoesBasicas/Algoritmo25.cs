namespace Algoritmos.Algoritmos
{
    public static class Algoritmo25
    {
        /*
         [DESAFIO] Crie um programa que leia o tamanho de três segmentos de reta.
            Analise seus comprimentos e diga se é possível formar um triângulo com essas
            retas. Dados três segmentos de reta, nem sempre eles podem formar um triângulo. 
            Para que os três segmentos formem um triângulo,
            existe o que conhecemos como condição de existência, que é a seguinte: 
            a soma de dois lados é sempre maior que o terceiro lado.
        */
        public static void Execute()
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
                Console.WriteLine("As retas informadas podem formar um triângulo!");
            }
            else
            {
                Console.WriteLine("As retas informadas não podem formar um triângulo!");
            }
        }
    }
}
