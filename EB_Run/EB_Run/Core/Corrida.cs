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
            int distancia;

            for (int i = 0; i< totalSemanasTreino; i++)
            {
                distancia = distanciaUltimoTAF + distanciaAcrescida * i;
                _distanciasRitimada.Add(distancia);
            }

            return _distanciasRitimada;
        }

        public List<float> calculaTempoRitimada()
        {
            List<float> _temposRitimada = new List<float>();
            float tempo;

            for (int i = 0; i < totalSemanasTreino; i++)
            {
                tempo = 20 * i;
                _temposRitimada.Add(tempo);
            }

            return _temposRitimada;
        }
        
        public List<float> calculaTempoTiro()
        {
            List<float> _temposTiro = new List<float>();
            float tempo;

            for(int i = 0;i < totalSemanasTreino; i++)
            {
                tempo=20 * i;
                _temposTiro.Add(tempo);
            }

            return _temposTiro;
        }


        public List<float> calculaIntervaloTiro()
        {
            List<float> _intervaloTiro = new List<float>();
            float intervalo;

            for( int i = 0; i< totalSemanasTreino; i++)
            {
                intervalo = 20 * i;
                _intervaloTiro.Add(intervalo);
            }

            return _intervaloTiro;
        }

        public List<int> calculaRepeticoesTiro()
        {
            List<int> _repeticoesTiro = new List<int>();
            int repeticoes;

            for(int i=0;  i< totalSemanasTreino; i++)
            {
                repeticoes = 20 * i;
                _repeticoesTiro.Add(repeticoes);
            }

            return _repeticoesTiro;
        }
        
    }
}
