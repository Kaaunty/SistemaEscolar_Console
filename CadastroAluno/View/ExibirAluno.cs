using CadastroAluno.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAluno.View
{
    internal class ExibirAluno
    {
        public static void VisualizarAlunos()
        {
            try
            {
                {
                    if (Aluno.ListaAluno.Count == 0)
                    {
                        Console.WriteLine("Não há alunos cadastrados.");
                        Console.ReadKey();
                        Console.WriteLine("Voltando ao menu anterior.");
                        MenuAluno.ExibirMenuAluno();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Alunos cadastrados:");
                        Console.WriteLine();

                        Aluno.ListaAluno.Sort((a, b) => string.Compare(a.Nome, b.Nome));

                        foreach (Aluno aluno in Aluno.ListaAluno)
                        {
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("Nome: " + aluno.Nome);
                            Console.WriteLine("RA: " + aluno.RA);
                            Console.WriteLine("Data de nascimento: " + aluno.DataNascimento.ToString("dd/MM/yyyy"));
                            Console.WriteLine("Turma: " + aluno.TurmaNumero + "°" + aluno.TurmaLetra);
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine();
                        }
                    }
                    Console.ReadKey();
                    MenuAluno.ExibirMenuAluno();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
