namespace Algoritmos.Algoritmos
{
    public static class Algoritmo24
    {
        /*
            Faça um algoritmo que pergunte a distância que um passageiro deseja 
            percorrer em Km. Calcule o preço da passagem, cobrando R$0.50 por Km para 
            viagens até 200Km e R$0.45 para viagens mais longas.
        */
        public static void Start()
        {
            Console.Write("Digite a distancia em Km que você irá percorrer: ");
            var distanciaEmKm = double.Parse(Console.ReadLine() ?? "0");

            var valorCobradoPorKM = 0.5f;

            if (distanciaEmKm > 200)
                valorCobradoPorKM = 0.45f;

            var totalViagem = distanciaEmKm * valorCobradoPorKM;

            Console.WriteLine($"Você irá pagar R${totalViagem:F2} por uma viagem de {distanciaEmKm}Km, R${valorCobradoPorKM:F2} por Km rodado");
        }
    }
}
