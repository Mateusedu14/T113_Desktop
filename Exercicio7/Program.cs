namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[6];
            double[] precos = new double[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Digite o nome do produto {i + 1}: ");
                nomes[i] = Console.ReadLine()!;

                Console.Write($"Digite o preço do produto {i + 1}: ");
                while (!double.TryParse(Console.ReadLine(), out precos[i]) || precos[i] < 0)
                {
                    Console.WriteLine("Preço inválido! Digite um número válido: ");
                }

            }

            int indiceMaisBarato = 0;
            for (int i = 1; i < 6; i++)
            {
                if (precos[i] < precos[indiceMaisBarato])
                {
                    indiceMaisBarato = i;
                }
            }

            Console.WriteLine($"\n0 produto mais barato é '{nomes[indiceMaisBarato]}' custando R$ {precos[indiceMaisBarato]:F2}");

        }
    }

}
