using CadastroAluno.Model;
using CadastroAluno.View;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CadastroAluno.Controller
{
    internal class AlunoController
    {
        public static List<Aluno> ListaAluno = Aluno.ListaAluno;
        public static void Adicionar()
        {
            try
            {
                Console.ResetColor();
                Console.Clear();
                Console.WriteLine("Digite o nome do aluno: ");
                string nome = Verificar.VerificarNome();
                Aluno aluno = new Aluno(nome);

                DateTime dataNascimento = Verificar.DataNascimentoAluno();
                aluno.DataNascimento = dataNascimento;

                Random random = new Random();
                int ra = random.Next(1, 100);
                aluno.RA = ra;

                Console.WriteLine("Digite o número da turma (1 a 3): ");
                string turmaNumeroStr = Console.ReadLine();
                int turmaNumero;
                while (!int.TryParse(turmaNumeroStr, out turmaNumero) || turmaNumero < 1 || turmaNumero > 3)
                {
                    Console.WriteLine("Número da turma inválido!");
                    turmaNumeroStr = Console.ReadLine();
                }
                aluno.TurmaNumero = turmaNumero;

                Console.WriteLine("Digite a letra da turma (A a D): ");
                string turmaLetraStr = Console.ReadLine().ToUpper();
                Regex regex = new Regex(@"^[A-D]$");
                while (!regex.IsMatch(turmaLetraStr))
                {
                    Console.WriteLine("Letra da turma inválida!");
                    turmaLetraStr = Console.ReadLine().ToUpper();
                }
                aluno.TurmaLetra = turmaLetraStr;
                ListaAluno.Add(aluno);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Aluno adicionado com sucesso!");
                Console.ResetColor();
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
                Console.ReadKey();
                MenuAluno.ExibirMenuAluno();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar aluno!");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
                Console.ReadKey();
                MenuAluno.ExibirMenuAluno();
            }
        } // OK

        public static void Remover()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Lista de aluno cadastrados:");

                for (int i = 0; i < ListaAluno.Count; i++)
                {
                    int indicedisplay = i;
                    Console.WriteLine($"{indicedisplay}. Nome: {ListaAluno[i].Nome} RA: {ListaAluno[i].RA}");
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("Índice do aluno a ser excluído:");
                string indicealunoStr = Console.ReadLine();
                if (int.TryParse(indicealunoStr, out int indicealuno))
                {
                    if (indicealuno >= 0 && indicealuno < ListaAluno.Count)
                    {
                        Console.WriteLine($"Aluno {ListaAluno[indicealuno].Nome} excluído com sucesso!");
                        ListaAluno.RemoveAt(indicealuno);
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
                Console.WriteLine($"Aluno excluído com sucesso!");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                MenuAluno.ExibirMenuAluno();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro ao excluir aluno!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
                Console.ReadKey();
                MenuAluno.ExibirMenuAluno();
            }
        }

    }
}
