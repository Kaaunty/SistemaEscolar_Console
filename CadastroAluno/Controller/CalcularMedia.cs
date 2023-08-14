using CadastroAluno.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAluno.Controller
{
    internal class CalcularMedia
    {
        public static double CalculaMedia(List<double> notas)
        {
            if (notas.Count == 0)
            {
                return 0;
            }
            double media = 0;
            foreach (var nota in notas)
            {
                media += nota;
            }
            media = media / notas.Count;

            return media;
        }
    }
}
