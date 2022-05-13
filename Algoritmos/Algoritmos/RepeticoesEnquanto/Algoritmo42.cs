namespace Algoritmos.Algoritmos
{
    public static class Algoritmo42
    {
        /*
            Faça um algoritmo que pergunte ao usuário um número inteiro e positivo
            qualquer e mostre uma contagem até esse valor:
            Ex: Digite um valor: 35
            Contagem: 1 2 3 4 5 6 7 ... 33 34 35 Acabou!
        */
        public static void Start()
        {
            Console.Write("Digite um número inteiro: ");
            var numero = int.Parse(Console.ReadLine() ?? "");

            var i = 1;
            while(i <= numero)
            {
                Console.Write($"{i} ");
                i++;
            }
            Console.WriteLine("Acabou!");
        }
    }
}
