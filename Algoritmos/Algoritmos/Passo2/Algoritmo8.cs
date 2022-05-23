namespace Algoritmos.Algoritmos
{
    public static class Algoritmo8
    {
        /*
            Desenvolva um programa que leia uma distância em metros e mostre os valores
            relativos em outras medidas.
            Ex:
            Digite uma distância em metros: 185.72
            A distância de 85.7m corresponde a:
            0.18572Km
            1.8572Hm
            18.572Dam
            1857.2dm
            18572.0cm
            185720.0mm
        */
        public static void Start()
        {
            Console.Write("Digite uma distância em metros: ");
            var distaciaEmMetros = double.Parse(Console.ReadLine() ?? "0");
            var distanciaEmKilometros = distaciaEmMetros / 1000;
            var distanciaEmHectometros = distaciaEmMetros / 100;
            var distanciaEmDecametros = distaciaEmMetros / 10;
            var distanciaEmDecimetros = distaciaEmMetros * 10;
            var distanciaEmCentimetros = distaciaEmMetros * 100;
            var distanciaEmMilimetros = distaciaEmMetros * 1000;

            Console.WriteLine($"A distância de {distaciaEmMetros}m corresponde a:");
            Console.WriteLine($"{distanciaEmKilometros}Km");
            Console.WriteLine($"{distanciaEmHectometros}Hm");
            Console.WriteLine($"{distanciaEmDecametros}Dam");
            Console.WriteLine($"{distanciaEmDecimetros}dm");
            Console.WriteLine($"{distanciaEmCentimetros}cm");
            Console.WriteLine($"{distanciaEmMilimetros}mm");
        }
    }
}
