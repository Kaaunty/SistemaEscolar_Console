using CadastroAluno.Controller;
using System;

namespace CadastroAluno.View
{
    internal class MenuAluno
    {
        public static void ExibirMenuAluno()
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--- Bem vindo ao Cadastro de Alunos ---");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Visualizar");
                Console.WriteLine("3 - Remover");
                Console.WriteLine("4 - Voltar");
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
                        AlunoController.Adicionar();
                        Console.ResetColor();
                        break;
                    case 2:
                        ExibirAluno.VisualizarAlunos();
                        Console.ResetColor();
                        break;
                    case 3:
                        AlunoController.Remover();
                        Console.ResetColor();
                        break;
                    case 4:
                        Console.WriteLine("Retornando ao menu principal");
                        Console.WriteLine();
                        Program.Main();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        ExibirMenuAluno();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}
