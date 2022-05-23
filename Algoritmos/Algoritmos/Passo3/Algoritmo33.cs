namespace Algoritmos.Algoritmos
{
    public static class Algoritmo33
    {
        /*
             Escreva um programa para aprovar ou não o empréstimo bancário para a compra
            de uma casa. O programa vai perguntar o valor da casa, o salário do comprador e
            em quantos anos ele vai pagar. Calcule o valor da prestação mensal, sabendo que
            ela não pode exceder 30% do salário ou então o empréstimo será negado.

        */
        public static void Start()
        {
            Console.Write("Valor do imóvel: ");
            var valorImovel = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Salário do comprador: ");
            var salarioComprador = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Em quantos anos será pago? ");
            var anos = double.Parse(Console.ReadLine() ?? "0");

            var parcelaMensal = valorImovel / (anos * 12);

            var trintaPorcSalario = salarioComprador * 30 / 100;

            if (parcelaMensal > trintaPorcSalario)
            {
                Console.WriteLine("Emprestimo NEGADO!");
                Console.WriteLine("A parcela mensal ultrapassa 30% do salário!");
            }
            else
            {
                Console.WriteLine("Emprestimo APROVADO!");
                Console.WriteLine("O valor da parcela cabe no seu bolso");
            }

            Console.WriteLine($"30% Salário: {trintaPorcSalario:F2}");
            Console.WriteLine($"Parcela Mensal: {parcelaMensal:F2}");
        }
    }
}
