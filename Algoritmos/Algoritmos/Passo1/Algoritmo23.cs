namespace Algoritmos.Algoritmos
{
    public static class Algoritmo23
    {
        /*
            Numa promoção exclusiva para o Dia da Mulher, uma loja quer dar descontos 
            para todos, mas especialmente para mulheres. Faça um programa que leia nome, 
            sexo e o valor das compras do cliente e calcule o preço com desconto. Sabendo 
            que:
             - Homens ganham 5% de desconto
             - Mulheres ganham 13% de desconto
        */
        public static void Start()
        {
            const int porcentagemDescontoMulher = 13;
            const int porcentagemDescontoHomem = 5;

            Console.Write("Digite seu nome: ");
            var nome = Console.ReadLine();

            Console.Write("Digite seu sexo (M ou F): ");
            var sexo = Console.ReadLine();

            Console.Write("Digite o valor das compras: ");
            var valorCompra = double.Parse(Console.ReadLine() ?? "0");

            if (sexo == "F")
            {
                var valorDesconto = valorCompra * porcentagemDescontoMulher / 100;
                var valorDescontoCompra = valorCompra - valorDesconto;

                Console.WriteLine($"{nome} recebeu {porcentagemDescontoMulher}% de desconto na compra, equivalente a R${valorDesconto:F2}");
                Console.WriteLine($"Valor total a pagar com desconto: R${valorDescontoCompra:F2}");
            }
            else
            {
                var valorDesconto = valorCompra * porcentagemDescontoHomem / 100;
                var valorDescontoCompra = valorCompra - valorDesconto;

                Console.WriteLine($"{nome} recebeu {porcentagemDescontoHomem}% de desconto equivalente a R${valorDesconto:F2}");
                Console.WriteLine($"Valor total a pagar com desconto: R${valorDescontoCompra:F2}");
            }
        }
    }
}
