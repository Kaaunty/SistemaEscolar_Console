using CadastroAluno.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.ForegroundColor = ConsoleColor.DarkBlue;
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
                if (!numero)
                {
                    Console.WriteLine("Opção inválida");
                    Main();
                }
                else
                {
                    if (opcao == 1)
                    {
                        MenuAluno.ExibirMenuAluno();
                        Console.ResetColor();
                    }
                    else if (opcao == 2)
                    {
                        MenuProfessor.ExibirMenuProfessor();
                        Console.ResetColor();

                    }
                    else if (opcao == 3)
                    {
                        MenuNotas.ExibirMenuNotas();
                        Console.ResetColor();

                    }
                    else if (opcao == 4)
                    {
                        Console.WriteLine("Obrigado por utilizar o Sistema Escolar");
                        Console.WriteLine();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida");
                        Main();

                    }
                }
                Console.WriteLine();
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
                Console.WriteLine("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                Main();
            }
        }
    }
}
