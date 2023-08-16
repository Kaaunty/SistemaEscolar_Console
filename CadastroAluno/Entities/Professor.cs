using System.Collections.Generic;

namespace CadastroAluno.Model
{
    internal class Professor : Pessoa
    {

        public static List<Professor> ListaProfessor = new List<Professor>();



        public Professor(string nome, string disciplina)
        {
            Nome = nome;
            Disciplinas = disciplina;
        }

    }
}
