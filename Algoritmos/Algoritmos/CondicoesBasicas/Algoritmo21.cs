namespace Algoritmos.Algoritmos
{
    public static class Algoritmo21
    {
        /*
             Faça um algoritmo que leia um determinado ano e mostre se ele é ou não BISSEXTO.
        */
        public static void Start()
        {
            Console.Write("Digite o ano: ");
            var ano = int.Parse(Console.ReadLine() ?? "0");
            var isBissexto = DateTime.IsLeapYear(ano);

            if (isBissexto)
                Console.WriteLine($"O ano {ano} é bissexto");
            else
                Console.WriteLine($"o ano {ano} não é bissexto");            
        }
    }
}
