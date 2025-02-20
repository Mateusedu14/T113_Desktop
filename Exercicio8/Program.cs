namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== Calculadora Simples =====");
                Console.WriteLine("1. Soma");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Potenciação");
                Console.WriteLine("6. Radiciação");
                Console.WriteLine("7. Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out int opcao) || opcao < 1 || opcao > 7)
                {
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    continue;
                }

                if (opcao == 7) break; // Sai do programa

                // Solicitar números
                double num1 = LerNumero("Digite o primeiro número: ");
                double num2 = opcao == 6 ? 0 : LerNumero("Digite o segundo número: "); // Radiciação só precisa de um número

                double resultado = opcao switch
                {
                    1 => Soma(num1, num2),
                    2 => Subtracao(num1, num2),
                    3 => Multiplicacao(num1, num2),
                    4 => Divisao(num1, num2),
                    5 => Potenciacao(num1, num2),
                    6 => Radiciacao(num1),
                    _ => 0
                };

                Console.WriteLine($"\nResultado: {resultado}\n");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        static double LerNumero(string mensagem)
        {
            double numero;
            Console.Write(mensagem);
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Entrada inválida! Digite um número válido: ");
            }
            return numero;
        }

        static double Soma(double a, double b) => a + b;
        static double Subtracao(double a, double b) => a - b;
        static double Multiplicacao(double a, double b) => a * b;

        static double Divisao(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: divisão por zero não permitida.");
                return double.NaN;
            }
            return a / b;
        }

        static double Potenciacao(double a, double b) => Math.Pow(a, b);
        static double Radiciacao(double a) => a < 0 ? double.NaN : Math.Sqrt(a);
    }
}
    
