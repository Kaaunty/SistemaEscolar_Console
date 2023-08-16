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
                if (!numero)
                {
                    Console.WriteLine("Opção inválida");
                    ExibirMenuAluno();
                }
                else
                {
                    if (opcao == 1)
                    {
                        AlunoController.Adicionar();
                    }
                    else if (opcao == 2)
                    {
                        ExibirAluno.VisualizarAlunos();
                    }
                    else if (opcao == 3)
                    {
                        AlunoController.Remover();
                    }
                    else if (opcao == 4)
                    {
                        Console.WriteLine("Retornando ao menu principal");
                        Console.WriteLine();
                        Program.Main();
                    }
                    else
                    {

                        Console.WriteLine("Opção inválida");
                        ExibirMenuAluno();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
