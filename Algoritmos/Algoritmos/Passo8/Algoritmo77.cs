namespace Algoritmos.Algoritmos
{
    public static class Algoritmo77
    {
        /*
            Faça um programa que leia 7 nomes de pessoas e guarde-os em um vetor. No
            final, mostre uma listagem com todos os nomes informados, na ordem inversa
            daquela em que eles foram informados.    
        */

        public static void Start()
        {
            string[] nomes = new string[7];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite o nome: ");
                var nome = Console.ReadLine();

                nomes[i] = nome;
            }

            var index = 6;
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[index]);
                index--;
            }
        }
    }
}
