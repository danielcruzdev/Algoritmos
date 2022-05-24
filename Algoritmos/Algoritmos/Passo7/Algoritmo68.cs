namespace Algoritmos.Algoritmos
{
    public static class Algoritmo68
    {
        /*
            Crie um programa que leia sexo e peso de 8 pessoas, usando a estrutura
            “para”. No final, mostre na tela:
            a) Quantas mulheres foram cadastradas
            b) Quantos homens pesam mais de 100Kg
            c) A média de peso entre as mulheres
            d) O maior peso entre os homens
        */
        public static void Start()
        {
            var qtdPessoas = 8;
            var qtdMulheres = 0;
            var totalPesoMulheres = 0d;
            var qtdHomensMais100Kg = 0;
            var maiorPesoHomem = 0d;

            for (int i = 0; i <= qtdPessoas; i++)
            {
                Console.Write("Digite o sexo da pessoa (M ou F): ");
                var sexo = Console.ReadLine().ToUpper();

                Console.Write("Digite o peso: ");
                var peso = double.Parse(Console.ReadLine() ?? "0");

                if(sexo == "F")
                {
                    qtdMulheres++;
                    totalPesoMulheres += peso;
                } 
                else
                {
                    if (peso > 100)
                        qtdHomensMais100Kg++;

                    if (peso > maiorPesoHomem)
                        maiorPesoHomem = peso;
                }
            }

            var mediaPesoMulheres = totalPesoMulheres / qtdMulheres;

            Console.WriteLine($"Qtd. Mulheres: {qtdMulheres}");
            Console.WriteLine($"Qtd. Homens com mais de 100Kg: {qtdHomensMais100Kg}");
            Console.WriteLine($"Média peso entre mulheres: {mediaPesoMulheres}");
            Console.WriteLine($"Maior peso entre os homens: {maiorPesoHomem}");
        }
    }
}
