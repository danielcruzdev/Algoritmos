namespace Algoritmos.Algoritmos
{
    public static class Algoritmo87
    {
        /*
            Crie um programa que melhore o procedimento Gerador() da questão anterior
            para que mostre uma mensagem personalizada, passada como parâmetro.

            Ex: Ao chamar Gerador("Aprendendo Portugol") aparece:
            +-------=======------+
             Aprendendo C#
            +-------=======------+
        */

        public static void Start()
        {
            Gerador("Aprendendo C#");
        }

        private static void Gerador(string mensagem)
        {
            Console.WriteLine("+-------=======------+");
            Console.WriteLine(mensagem);
            Console.WriteLine("+-------=======------+");
        }
    }
}
