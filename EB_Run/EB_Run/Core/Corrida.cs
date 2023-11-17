using System;
using System.Windows.Documents;
using System.Collections.Generic;


namespace EB_Run.Core
{
    internal class Corrida
    {
        private int distanciaUltimoTAF = 0;
        private int distanciaAcrescida = 0;
        private int totalSemanasTreino = 0;

        const int distTiro = 400;
        const int min12 = 12 * 60;

        public void inputDistanciaUltimoTAF(int _distanciaUltimoTAF)
        {
            distanciaUltimoTAF = _distanciaUltimoTAF;
        }

        public void inputDistanciaAcrescida(int _distanciaAcrescida)
        {
            distanciaAcrescida = _distanciaAcrescida;
        }
        
        public void inputTotalSemanasTreino(int _totalSemanasTreino)
        {
            totalSemanasTreino = _totalSemanasTreino;
        }

        public List<int> calculaDistanciaRitimada()
        {
            List<int> _distanciasRitimada = new List<int>();
            int distancia = 100*(int)(distanciaUltimoTAF*1.4/100);

            for (int i = 0; i< totalSemanasTreino; i++)
            {
                _distanciasRitimada.Add(distancia);
                distancia = 100 * (int)(distancia * 1.1 / 100);
            }

            return _distanciasRitimada;
        }

        public List<int> calculaTempoRitimada()
        {
            List<int> _temposRitimada = new List<int>();
            int tempo = (int)(min12/((distanciaUltimoTAF+distanciaAcrescida)*0.7));

            for (int i = 0; i < totalSemanasTreino; i++)
            {
                _temposRitimada.Add(tempo);
                tempo = (int)(tempo / 1.05);
            }

            return _temposRitimada;
        }


        public List<int> calculaIntervaloTiro()
        {
            List<int> _intervaloTiro = new List<int>();
            int intervalo = distTiro * min12 / (distanciaUltimoTAF + distanciaAcrescida);

            for ( int i = 0; i< totalSemanasTreino; i++)
            {
                _intervaloTiro.Add(intervalo);
                intervalo = (int)Math.Ceiling(intervalo / 1.1);
            }

            return _intervaloTiro;
        }

        public List<int> calculaRepeticoesTiro()
        {
            List<int> _repeticoesTiro = new List<int>();
            double rep = distanciaUltimoTAF/distTiro;
            int repeticoes = (int)rep;

            for(int i=0;  i< totalSemanasTreino; i++)
            {
                _repeticoesTiro.Add(repeticoes);
                rep = 1.1 * rep;
                repeticoes = (int)rep;
            }

            return _repeticoesTiro;
        }
        
    }
}
