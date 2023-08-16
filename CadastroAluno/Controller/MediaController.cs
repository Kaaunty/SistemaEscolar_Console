using System.Collections.Generic;

namespace CadastroAluno.Controller
{
    internal class MediaController
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
