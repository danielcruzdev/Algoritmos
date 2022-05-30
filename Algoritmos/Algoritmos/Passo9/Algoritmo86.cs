namespace Algoritmos.Algoritmos
{
    public static class Algoritmo86
    {
        /*
             Crie um programa que tenha um procedimento Gerador() que, quando chamado,
            mostre a mensagem "Olá, Mundo!" com algum componente visual (linhas)
            Ex: Ao chamar Gerador() aparece:
            +-------=======------+
             Olá, Mundo!
            +-------=======------+
        */

        public static void Start()
        {
            Gerador();
        }

        private static void Gerador()
        {
            Console.WriteLine("+-------=======------+");
            Console.WriteLine("Olá, Mundo!");
            Console.WriteLine("+-------=======------+");
        }
    }
}
