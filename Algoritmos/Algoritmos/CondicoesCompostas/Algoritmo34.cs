namespace Algoritmos.Algoritmos
{
    public static class Algoritmo34
    {
        /*
            O Índice de Massa Corpórea (IMC) é um valor calculado baseado na altura e no
            peso de uma pessoa. De acordo com o valor do IMC, podemos classificar o
            indivíduo dentro de certas faixas.
             - abaixo de 18.5: Abaixo do peso
             - entre 18.5 e 25: Peso ideal
             - entre 25 e 30: Sobrepeso
             - entre 30 e 40: Obesidade
             - acima de 40: Obseidade mórbida
        */
        public static void Start()
        {
            Console.Write("Digite sua altura: ");
            var altura = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Digite seu peso: ");
            var peso = double.Parse(Console.ReadLine() ?? "0");

            var imc = peso / (altura * altura);

            if (imc < 18.5)
                Console.WriteLine("Abaixo do peso");
            else if (imc >= 18.5 && imc <= 25)
                Console.WriteLine("Peso ideal");
            else if (imc >= 25 && imc <= 30)
                Console.WriteLine("Sobrepeso");
            else if (imc >= 30 && imc <= 40)
                Console.WriteLine("Obesidade");
            else
                Console.WriteLine("Obesidade Morbida");
        }
    }
}
