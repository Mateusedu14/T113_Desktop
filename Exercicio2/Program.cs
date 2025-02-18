namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número de 1 a 7: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            string diaSemana = numero switch
            {

                1 => "Domingo",
                2 => "Segunda-feira",
                3 => "Terça-feira",
                4 => "Quarta-feira",
                5 => "Quinta-feira",
                6 => "Sexta-feira",
                7 => "Sábado",
                _ => "Número inválido. Digite um número entre 1 e 7."
            };

            Console.WriteLine(diaSemana);


        }
    }
}
