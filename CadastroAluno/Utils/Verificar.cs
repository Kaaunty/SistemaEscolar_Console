using System;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CadastroAluno.Controller
{
    internal class Verificar
    {
        public static string VerificarNome()
        {
            string nome;
            do
            {
                nome = Console.ReadLine();
                if (!ValidaNome(nome))
                {
                    Console.WriteLine("Nome inválido! Certifique-se de usar apenas letras e espaços. Por favor, tente novamente.");
                }
            } while (!ValidaNome(nome));

            return nome;
        }

        public static bool ValidaNome(string nome)
        {
            Regex regex = new Regex("^[a-zA-Z ]+$");

            return regex.IsMatch(nome);
        }

        public static DateTime DataNascimentoAluno()
        {
            DateTime maxDataNascimento = DateTime.Now.AddYears(-14);
            DateTime minDataNascimento = DateTime.Now.AddYears(-21);
            DateTime dataNascimento;

            Console.WriteLine("Digite a data de nascimento do aluno (formato: dd/MM/yyyy): ");
            string dataNascimentoStr = Console.ReadLine();

            while (!DateTime.TryParseExact(dataNascimentoStr, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento) || dataNascimento > maxDataNascimento || minDataNascimento > dataNascimento)
            {
                if (dataNascimento > maxDataNascimento)
                    Console.WriteLine("Data de nascimento inválida ou idade abaixo do minimo de 14 anos Digite novamente (formato: dd/MM/yyyy): ");
                else if (minDataNascimento > dataNascimento)
                    Console.WriteLine("Data de nascimento inválida ou idade acima do maximo de 20 anos Digite novamente (formato: dd/MM/yyyy): ");
                dataNascimentoStr = Console.ReadLine();
            }

            return dataNascimento;
        }

    }
}
