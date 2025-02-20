namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario, senha;

            while (true)
            {
                Console.Clear();
                Console.Write("Digite o nome de usuário: ");
                usuario = Console.ReadLine()!;

                Console.Write("Digite a senha: ");
                senha = Console.ReadLine()!;

                // Verifica se a senha é igual ao nome de usuário
                if (usuario.Equals(senha, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Erro: A senha não pode ser igual ao nome de usuário.");
                    Console.WriteLine("Tente novamente...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Usuário e senha cadastrados com sucesso!");
                    break; // Sai do loop quando a senha for válida
                }
            }
        }
    }
}
   
