namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            int[] pares, impares;

            // Entrada dos 20 números
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Digite o {i + 1}º número inteiro: ");
                while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.Write("Entrada inválida! Digite um número inteiro: ");
                }
            }

            // Separação de pares e ímpares
            pares = numeros.Where(n => n % 2 == 0).ToArray();
            impares = numeros.Where(n => n % 2 != 0).ToArray();

            // Exibição dos vetores
            Console.WriteLine("\nVetor original:");
            Console.WriteLine($"[{string.Join(", ", numeros)}]");

            Console.WriteLine("\nVetor de números pares:");
            Console.WriteLine($"[{string.Join(", ", pares)}]");

            Console.WriteLine("\nVetor de números ímpares:");
            Console.WriteLine($"[{string.Join(", ", impares)}]");
        }
    }
}
   
