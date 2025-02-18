namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            double numero3 = Convert.ToDouble(Console.ReadLine());

            double maior = (numero1 > numero2) ? ((numero1 > numero3) ? numero1 : numero3) : ((numero2 > numero3) ? numero2 : numero3);
            double menor = (numero1 < numero2) ? ((numero1 < numero3) ? numero1 : numero3) : ((numero2 < numero3) ? numero2 : numero3);

            Console.WriteLine($"O maior número é: {maior}");
            Console.WriteLine($"O menor número é: {menor}");
        }
    }
}
