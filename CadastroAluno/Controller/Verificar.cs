using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CadastroAluno.Controller
{
    internal class Verificar
    {


        public static string VerificarNome()
        {
            while (true)
            {
                string nome = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(nome) && !ContemCaracteresEspeciais(nome) && !ContemNumeros(nome) && nome.Length > 2)
                {
                    return nome;
                }


                Console.WriteLine("Nome inválido. O nome não deve conter caracteres especiais ou números. Digite novamente.");
            }
        }

        public static bool ContemCaracteresEspeciais(string input)
        {
            return Regex.IsMatch(input, @"[^a-zA-ZÀ-ÿ\s]");
        }


        public static bool ContemNumeros(string input)
        {
            return Regex.IsMatch(input, @"[\d]");
        }

        public static DateTime VerificaDataProfessor()
        {
            {
                DateTime maxDataNascimento = DateTime.Now.AddYears(-23);
                DateTime minDataNascimento = DateTime.Now.AddYears(-70);
                DateTime dataNascimento;
                Console.WriteLine("Digite a data de nascimento do professor (formato: dd/mm/aaaa): ");
                string dataNascimentoStr = Console.ReadLine();
                while (!DateTime.TryParseExact(dataNascimentoStr, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento) || dataNascimento > maxDataNascimento || dataNascimento < minDataNascimento)
                {
                    if (dataNascimento > maxDataNascimento)
                        Console.WriteLine("Data de nascimento inválida ou idade abaixo do minimo de 23 anos Digite novamente (formato: dd/MM/yyyy): ");
                    else if (minDataNascimento > dataNascimento)
                        Console.WriteLine("Data de nascimento inválida ou idade acima do maximo de 70 anos Digite novamente (formato: dd/MM/yyyy): ");
                    dataNascimentoStr = Console.ReadLine();
                }
                return dataNascimento;
            }
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
