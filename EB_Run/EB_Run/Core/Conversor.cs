using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB_Run.Core
{
    internal class Conversor
    {

        public static string converterTempo(int tempo)
        {
            int minutos = (int)(tempo / 60);
            int segundos = (tempo % 60);
            segundos = 5*(int)(segundos/5);

            string str = minutos.ToString() + "min" + segundos.ToString() + "s";

            return str;

        }
    }
}
