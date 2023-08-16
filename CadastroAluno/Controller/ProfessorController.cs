using CadastroAluno.Model;
using CadastroAluno.View;
using System;
using System.Collections.Generic;

namespace CadastroAluno.Controller
{
    internal class ProfessorController
    {

        public static List<Professor> ListaProfessor = Professor.ListaProfessor;
        public static void Adicionar()
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Digite o nome do professor: ");

            string nome = Verificar.VerificarNome();

            Console.WriteLine("Digite a disciplina do professor: ");
            string disciplina = Verificar.VerificarNome();

            Professor professor = new Professor(nome, disciplina);
            Professor.ListaProfessor.Add(professor);
            Console.WriteLine("Professor Adicionado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
            Console.ReadKey();
            MenuProfessor.ExibirMenuProfessor();
        }

        // OK

        public static void Remover()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Lista de professores cadastrados:");

                for (int i = 0; i < ListaProfessor.Count; i++)
                {
                    Console.WriteLine($"{i}. Nome: {ListaProfessor[i].Nome} Disciplina: {ListaProfessor[i].Disciplinas}");
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("Índice do professor a ser excluído:");
                string indiceprofessorStr = Console.ReadLine();

                if (int.TryParse(indiceprofessorStr, out int indiceprofessor))
                {
                    if (indiceprofessor >= 0 && indiceprofessor < ListaProfessor.Count)
                    {
                        Console.WriteLine($"Professor {ListaProfessor[indiceprofessor].Nome} excluído com sucesso!");
                        ListaProfessor.RemoveAt(indiceprofessor);
                    }
                    else
                    {
                        Console.WriteLine("Índice inválido. O professor não foi encontrado na lista.");
                    }
                }
                else
                {
                    Console.WriteLine("Índice inválido. Certifique-se de inserir um número válido.");
                }

                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                MenuProfessor.ExibirMenuProfessor();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao excluir professor!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
                Console.ReadKey();
                MenuProfessor.ExibirMenuProfessor();
            }
        }


    }
}
