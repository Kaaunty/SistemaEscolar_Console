using CadastroAluno.Model;
using CadastroAluno.View;
using System;

namespace CadastroAluno.Controller
{
    internal class NotaController
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
                } //ok

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
                                if (aluno.Notas.Count == 4)
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
                                    do
                                    {
                                        Console.WriteLine("Digite a nota do aluno (0 a 10) :");
                                        double NotaEntrada = Double.Parse(Console.ReadLine());
                                        if (double.TryParse(NotaEntrada.ToString(), out double nota) && nota >= 0 && nota <= 10)
                                        {
                                            aluno.Notas.Add(nota);
                                            quantidadeNotas++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Nota inválida!");
                                        }
                                    }
                                    while (quantidadeNotas < 4);
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
        } // OK



        private static string SelecionarProfessor()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Lista de professores cadastrados:");

                for (int i = 0; i < Professor.ListaProfessor.Count; i++)
                {
                    int indicedisplay = i;
                    Console.WriteLine($"{indicedisplay}. Nome: {Professor.ListaProfessor[i].Nome} Disciplina: {Professor.ListaProfessor[i].Disciplinas}");
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("Digite o número correspondente ao professor: ");
                string professorEntrada = Console.ReadLine();
                int professorSelecionado;

                if ((!int.TryParse(professorEntrada, out professorSelecionado)))
                {
                    Console.WriteLine("Professor inválido!");
                    professorEntrada = Console.ReadLine();
                }
                else
                {
                    Professor professorEscolhido = Professor.ListaProfessor[professorSelecionado];
                    return professorEscolhido.Disciplinas;
                }
                Console.WriteLine("Número de professor inválido!");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
                Console.ReadKey();
                MenuNotas.ExibirMenuNotas();
                return "";

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


