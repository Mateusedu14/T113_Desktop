using System.Reflection.Metadata;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite quanto você ganha por hora: ");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite quantas horas você trabalhou no mês: ");
            double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

            double rendaMensal = valorHora * horasTrabalhadas;

            Console.WriteLine($"{nome}, sua renda mensal é: R$ {rendaMensal:F2}");
        }
    }
}
