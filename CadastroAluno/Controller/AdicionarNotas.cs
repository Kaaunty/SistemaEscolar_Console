using CadastroAluno.Model;
using CadastroAluno.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CadastroAluno.Controller
{

    internal class AdicionarNotas
    {
        public static void AdicionarNotasAluno()
        {
            try
            {
                Console.Clear();
                if (Aluno.ListaAluno.Count == 0)
                {
                    Console.WriteLine("Não há alunos cadastrados");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
                    Console.ReadKey();
                    MenuAluno.ExibirMenuAluno();
                }

                foreach (Aluno estudante in Aluno.ListaAluno)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine($"- RA: {estudante.RA}");
                    Console.WriteLine($"- Aluno: {estudante.Nome}");
                    Console.WriteLine("-----------------------------");
                }

                Console.WriteLine("Digite o RA do aluno que deseja adicionar notas: ");
                string raEntrada = Console.ReadLine();

                if (!int.TryParse(raEntrada, out int ra))
                {
                    Console.WriteLine("RA inválido!");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
                    Console.ReadKey();
                    MenuNotas.ExibirMenuNotas();
                }
                else
                {
                    if (Professor.ListaProfessor.Count == 0)
                    {
                        Console.WriteLine("Não há professores cadastrados!");
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
                        Console.ReadKey();
                        MenuNotas.ExibirMenuNotas();
                    }
                    else
                    {
                        Console.WriteLine("Selecione o professor para adicionar a nota:");
                        string disciplinaSelecionada = SelecionarProfessor();

                        foreach (Aluno aluno in Aluno.ListaAluno)
                        {
                            if (aluno.RA == ra)
                            {
                                if (aluno.Notas.Count >= 4)
                                {
                                    Console.WriteLine("O aluno já possui notas cadastradas para todas as disciplinas!");
                                    Console.WriteLine();
                                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
                                    Console.ReadKey();
                                    MenuNotas.ExibirMenuNotas();
                                }
                                else
                                {
                                    int quantidadeNotas = 0;
                                    Console.WriteLine("Digite a nota do aluno (0 a 10) :");
                                    string NotaEntrada = Console.ReadLine();

                                    do
                                    {
                                        if (double.TryParse(NotaEntrada, out double nota) && nota >= 0 && nota <= 10)
                                        {
                                            aluno.Notas.Add(nota);
                                            quantidadeNotas++;
                                            if (quantidadeNotas < 4)
                                            {
                                                Console.WriteLine("Digite a nota do aluno (0 a 10) :");
                                                NotaEntrada = Console.ReadLine();
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Nota inválida!");
                                            Console.WriteLine("Digite a nota do aluno (0 a 10) :");
                                            NotaEntrada = Console.ReadLine();
                                        }
                                    }
                                    while (aluno.Notas.Count < 4);
                                }
                                Console.WriteLine("Notas adicionadas com sucesso!");
                                Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
                                Console.ReadKey();
                                MenuNotas.ExibirMenuNotas();

                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar nota!");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
                Console.ReadKey();
                MenuNotas.ExibirMenuNotas();
            }
        }



        private static string SelecionarProfessor()
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Professores cadastrados: ");
                int professorindex = 1;

                foreach (Professor professor in Professor.ListaProfessor)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine($"- {professorindex} -");
                    Console.WriteLine($"- Nome: {professor.Nome}");
                    Console.WriteLine($"- Disciplina: {professor.Disciplinas}");
                    Console.WriteLine("-----------------------------");
                    professorindex++;
                }
                Console.WriteLine("Digite o número correspondente ao professor: ");
                string professorEntrada = Console.ReadLine();
                int professorSelecionado;
                while (!int.TryParse(professorEntrada, out professorSelecionado))
                {
                    Console.WriteLine("Professor inválido!");
                    professorEntrada = Console.ReadLine();
                }

                if (professorSelecionado >= 1 && professorSelecionado <= Professor.ListaProfessor.Count)
                {
                    Professor professorEscolhido = Professor.ListaProfessor[professorSelecionado - 1];
                    return professorEscolhido.Disciplinas;
                }
                else
                {
                    Console.WriteLine("Número de professor inválido!");
                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
                    Console.ReadKey();
                    MenuNotas.ExibirMenuNotas();
                    return "";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao selecionar professor!");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
                Console.ReadKey();
                MenuNotas.ExibirMenuNotas();
                return "";
            }
        }
    }
}


