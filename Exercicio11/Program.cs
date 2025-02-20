namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const double DESCONTO_INSS = 0.12;
            double[] salariosBrutos = new double[5];
            double[] salariosLiquidos = new double[5];

            // Coleta os salários brutos
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Digite o salário bruto da pessoa {i + 1}: ");

                while (!double.TryParse(Console.ReadLine(), out salariosBrutos[i]) || salariosBrutos[i] < 0)
                {
                    Console.Write("Valor inválido! Digite um salário válido: ");
                }

                // Calcula o salário líquido
                salariosLiquidos[i] = salariosBrutos[i] * (1 - DESCONTO_INSS);
            }

            // Exibe os resultados
            Console.WriteLine("\nSalários líquidos após desconto de 12% do INSS:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Pessoa {i + 1}: R$ {salariosLiquidos[i]:F2}");
            }
        }

    }
    }

