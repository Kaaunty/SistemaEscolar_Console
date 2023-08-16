using CadastroAluno.Controller;
using System;

namespace CadastroAluno.View
{
    internal class MenuNotas
    {
        public static void ExibirMenuNotas()
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--- Bem vindo ao Cadastro de Notas ---");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("Digite a opção desejada: ");
                Console.WriteLine("1 - Adicionar");
                Console.WriteLine("2 - Visualizar");
                Console.WriteLine("3 - Sair");
                Console.WriteLine();

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
                    ExibirMenuNotas();
                }
                else
                {
                    if (opcao == 1)
                    {
                        Console.Clear();

                        NotaController.AdicionarNotasAluno();
                    }
                    else if (opcao == 2)
                    {
                        Console.Clear();
                        ExibirNotas.VisualizarNotas();

                    }
                    else if (opcao == 3)
                    {
                        Console.WriteLine("Retornando ao menu principal");
                        Console.Clear();
                        Console.WriteLine();
                        Program.Main();

                    }
                    else
                    {

                        Console.WriteLine("Opção inválida");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Opção inválida");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }
        }
    }
}
