using CadastroAluno.View;
using System;

namespace CadastroAluno
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--- Bem vindo ao Sistema Escolar ---");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("1 - Aluno");
                Console.WriteLine("2 - Professor");
                Console.WriteLine("3 - Notas");
                Console.WriteLine("4 - Sair");
                Console.WriteLine();

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                bool numero = int.TryParse(key.KeyChar.ToString(), out int opcao);

                switch (opcao)
                {
                    case 1:

                        MenuAluno.ExibirMenuAluno();
                        Console.ResetColor();
                        break;
                    case 2:
                        MenuProfessor.ExibirMenuProfessor();
                        Console.ResetColor();
                        break;
                    case 3:
                        MenuNotas.ExibirMenuNotas();
                        Console.ResetColor();
                        break;
                    case 4:
                        Console.WriteLine("Obrigado por utilizar o Sistema Escolar");
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        Main();
                        break;

                }



            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                Main();
            }
        }
    }
}
