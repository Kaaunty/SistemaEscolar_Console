using CadastroAluno.Controller;
using System;

namespace CadastroAluno.View
{
    internal class MenuProfessor
    {
        internal static void ExibirMenuProfessor()
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--- Bem vindo ao Cadastro de Professor ---");
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
                        ProfessorController.Adicionar();
                        break;
                    case 2:
                        ExibirProfessor.VisualizarProfessores();
                        break;
                    case 3:
                        ProfessorController.Remover();
                        break;
                    case 4:
                        Console.WriteLine("Retornando ao menu principal");
                        Console.WriteLine();
                        Program.Main();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        ExibirMenuProfessor();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                Console.ReadKey();
                ExibirMenuProfessor();
            }
        }
    }
}
