using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAluno.Model
{
    internal class Aluno : Pessoa
    {
        public int RA { get; set; }
        public List<double> Notas { get; set; }
        public double media { get; set; }
        public string situacao { get; set; }
        public int TurmaNumero { get; set; }
        public string TurmaLetra { get; set; }

        public Aluno(string nome)
        {
            Nome = nome;
            Notas = new List<double>();
        }

        public static List<Aluno> ListaAluno = new List<Aluno>();

    }
}
