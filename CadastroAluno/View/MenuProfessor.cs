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
                Console.ForegroundColor = ConsoleColor.DarkGray;
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
                    ExibirMenuProfessor();
                }
                else
                {
                    if (opcao == 1)
                    {
                        AdicionarProfessor.Adicionar();
                    }
                    else if (opcao == 2)
                    {
                        Visualizadores.VisualizarProfessores();
                    }
                    else if (opcao == 3)
                    {
                        Console.WriteLine("Falta Implementar");
                        Console.WriteLine();
                        return;
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
                        ExibirMenuProfessor();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
                Console.ReadKey();
                ExibirMenuProfessor();
            }
        }
    }
}
