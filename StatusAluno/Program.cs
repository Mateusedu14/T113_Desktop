namespace StatusAluno
{


            /*Faça um algoritmo para leitura de duas notas parciais
             * de um aluno.
             * O algoritmo deve calcular a média alcançada por aluno
             * e apresentar:
             

                    A mensagem "Aprovado", se a média alcançada for maior ou igual a sete;
                    A mensagem "Reprovado", se a média for menor do que cinco;
                    A mensagem "Recuperação", se a média estive entre cinco e sete.
            */

         

            using System;

class Program
        {
            static void Main()
            {
                Console.Write("Digite a primeira nota: ");
                double nota1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a segunda nota: ");
                double nota2 = Convert.ToDouble(Console.ReadLine());

                double media = (nota1 + nota2) / 2;

                Console.WriteLine($"Média: {media:F2}");

                if (media >= 7)
                {
                    Console.WriteLine("Aprovado");
                }
                else if (media < 5)
                {
                    Console.WriteLine("Reprovado");
                }
                else
                {
                    Console.WriteLine("Recuperação");
                }
            }
        }


    }
