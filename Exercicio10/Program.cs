namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Digite um número inteiro para gerar a tabuada: ");

                if (!int.TryParse(Console.ReadLine(), out int numero))
                {
                    Console.WriteLine("Entrada inválida! Digite um número inteiro.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine($"\nTabuada de {numero}:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{numero} x {i} = {numero * i}");
                }

                Console.Write("\nDeseja gerar outra tabuada? (S/N): ");
                string resposta = Console.ReadLine()!.Trim().ToUpper();

                if (resposta != "S")
                {
                    Console.WriteLine("Encerrando o programa...");
                    break;
                }
            }
        }
        }
    }
