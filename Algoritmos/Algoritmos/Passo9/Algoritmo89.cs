namespace Algoritmos.Algoritmos
{
    public static class Algoritmo89
    {
        /*
            Crie um programa que melhore o procedimento Gerador() da questão anterior
            para que o programador possa escolher uma entre três bordas:
             +-------=======------+ Borda 1
             ~~~~~~~~:::::::~~~~~~~ Borda 2
             <<<<<<<<------->>>>>>> Borda 3
            Ex: Uma chamada válida seria Gerador("Portugol Studio", 3, 2)
            ~~~~~~~~:::::::~~~~~~~
             Portugol Studio
             Portugol Studio
             Portugol Studio
            ~~~~~~~~:::::::~~~~~~~
        */

        public static void Start()
        {
            Gerador("Aprendendo C#", 4, 2);
        }

        private static void Gerador(string mensagem, int qtd, int borda)
        {
            string? bordaStyle = borda switch
            {
                1 => "+-------=======------+",
                2 => "~~~~~~~~:::::::~~~~~~~",
                3 => "<<<<<<<<------->>>>>>>",
                _ => "----------------------",
            };

            Console.WriteLine(bordaStyle);
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine(mensagem);
            }
            Console.WriteLine(bordaStyle);
        }
    }
}
