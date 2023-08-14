using CadastroAluno.Model;
using CadastroAluno.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAluno.Controller
{
    internal class AdicionarProfessor
    {
        public static void Adicionar()
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Digite o nome do professor: ");
            string nome = Verificar.VerificarNome();
            Console.WriteLine("Digite a disciplina do professor: ");
            string disciplina = Verificar.VerificarNome();

            Professor aluno = new Professor(nome, disciplina);
            Professor.ListaProfessor.Add(aluno);
            Console.WriteLine("Professor Adicionado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior...");
            Console.ReadKey();
            MenuProfessor.ExibirMenuProfessor();


        }



    }
}
