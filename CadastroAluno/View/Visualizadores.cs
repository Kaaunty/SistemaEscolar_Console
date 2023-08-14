using CadastroAluno.Controller;
using CadastroAluno.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAluno.View
{
    internal class Visualizadores
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



        public static void VisualizarNotas()
        {
            try
            {


                if (Aluno.ListaAluno.Count == 0)
                {
                    Console.WriteLine("Não há alunos cadastrados.");
                    Console.ReadKey();
                    Console.WriteLine("Voltando ao menu anterior.");
                    MenuNotas.ExibirMenuNotas();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Alunos cadastrados:");
                    Console.WriteLine();


                    Aluno.ListaAluno.Sort((a, b) => string.Compare(a.Nome, b.Nome));


                    foreach (Aluno aluno in Aluno.ListaAluno)
                    {
                        if (aluno.Notas.Count == 0)
                        {
                            Console.WriteLine("---------------------------------------------------");
                            Console.Write("Algum Aluno não tem notas definidas");
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("Nome: " + aluno.Nome + " RA: " + aluno.RA);
                            Console.WriteLine("Turma: " + aluno.TurmaNumero + "°" + aluno.TurmaLetra);
                            Console.WriteLine("Disciplina: " + aluno.Disciplinas);
                            Console.WriteLine($"Notas: " + aluno.Notas[0] + ", " + aluno.Notas[1] + ", " + aluno.Notas[2] + ", " + aluno.Notas[3]);
                            double media = CalcularMedia.CalculaMedia(aluno.Notas);
                            Console.WriteLine($"Media: {media.ToString("N2")} ");
                            Console.Write("Situação do aluno: ");
                            if (media >= 7)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Aprovado");
                            }
                            else if (media >= 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Recuperação");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Reprovado");
                            }
                            Console.ResetColor();
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao visualizar notas");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
                Console.ReadKey();
                MenuNotas.ExibirMenuNotas();

            }
            Console.ReadKey();
            MenuNotas.ExibirMenuNotas();
        }

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

