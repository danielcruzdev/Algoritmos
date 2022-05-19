namespace Algoritmos.Algoritmos
{
    public static class Algoritmo57
    {
        /*
            Desenvolva um aplicativo que leia o salário e o sexo de vários funcionários.
            No final, mostre o total de salários pagos aos homens e o total pago às
            mulheres. O programa vai perguntar ao usuário se ele quer continuar ou não
            sempre que ler os dados de um funcionário.
        */
        public static void Start()
        {
            var salarioTotalHomens = 0.0d;
            var salarioTotalMulheres = 0.0d;
            string keep;

            do
            {
                Console.Write("Digite o sexo do funcionário (M ou F): ");
                var sexo = Console.ReadLine();

                Console.Write("Digite o salário do funcionário: R$");
                var salario = double.Parse(Console.ReadLine() ?? "0");

                if (sexo == "M")
                    salarioTotalHomens += salario;
                else
                    salarioTotalMulheres += salario;

                Console.Write("Continuar? (S ou N)");
                keep = Console.ReadLine() ?? "N";
                keep = keep.ToUpper();

            } while (keep != "N");

            Console.WriteLine($"Salário total mulheres: R${salarioTotalMulheres}");
            Console.WriteLine($"Salário total homens: R${salarioTotalHomens}");
        }
    }
}