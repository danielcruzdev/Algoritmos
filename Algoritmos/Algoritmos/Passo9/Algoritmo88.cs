namespace Algoritmos.Algoritmos
{
    public static class Algoritmo88
    {
        /*
            Crie um programa que melhore o procedimento Gerador() da questão anterior
            para que mostre uma mensagem vário
            Ex: Ao chamar Gerador("Aprendendo C#", 4) aparece:
            +-------=======------+
             Aprendendo C#
             Aprendendo C#
             Aprendendo C#
             Aprendendo C#
            +-------=======------+
        */

        public static void Start()
        {
            Gerador("Aprendendo C#", 4);
        }

        private static void Gerador(string mensagem, int qtd)
        {
            Console.WriteLine("+-------=======------+");
            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine(mensagem);
            }
            Console.WriteLine("+-------=======------+");
        }
    }
}
