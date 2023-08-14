using CadastroAluno.Model;
using CadastroAluno.View;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CadastroAluno.Controller
{
    internal class AdicionarAluno
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
        }
    }
}
