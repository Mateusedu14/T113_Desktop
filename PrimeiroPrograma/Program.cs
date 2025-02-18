namespace PrimeiroPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagem = "Hello, World!";
            char caractere = 'S';

            int numeroInteiro = 10;
            double numeroComVirgula = 10.7;

            bool estaAtivo = false;
            bool ehMaior = (numeroInteiro > numeroComVirgula);

            DateTime data = DateTime.Now;

            Console.WriteLine("Infome um numero:");

            numeroInteiro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(mensagem);
        }
    }
}
