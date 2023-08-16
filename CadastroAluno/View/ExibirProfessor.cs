using CadastroAluno.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAluno.View
{
    internal class ExibirProfessor
    {
        internal static void VisualizarProfessores()
        {
            try
            {
                if (Professor.ListaProfessor.Count == 0)
                {
                    Console.WriteLine("Não há professores cadastrados.");
                    Console.ReadKey();
                    Console.WriteLine("Voltando ao menu anterior.");
                    MenuProfessor.ExibirMenuProfessor();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Professores cadastrados:");
                    Console.WriteLine();
                    Professor.ListaProfessor.Sort((a, b) => string.Compare(a.Nome, b.Nome));
                    foreach (Professor professor in Professor.ListaProfessor)
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Nome: " + professor.Nome);
                        Console.WriteLine("Disciplina: " + professor.Disciplinas);
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine();
                    }
                }
                Console.ReadKey();
                MenuProfessor.ExibirMenuProfessor();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao visualizar professores");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
                Console.ReadKey();
                MenuProfessor.ExibirMenuProfessor();

            }
        }



    }
}
