using EB_Run.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EB_Run.MVVM.View
{
    /// <summary>
    /// Interação lógica para TreinoView.xam
    /// </summary>
    public partial class TreinoView : UserControl
    {
        Corrida corrida = new Corrida();
        private string nome = "";
        private int semanas = 0;
        int distancia = 0;
        int incrementoDistancia = 0;
        bool erro = false;

        public TreinoView()
        {
            InitializeComponent();
        }

        //numero de semanas
        private void semanas_10_Checked(object sender, RoutedEventArgs e)
        {
            semanas = 10;
            corrida.inputTotalSemanasTreino(semanas);
        }

        private void semanas_14_Checked(object sender, RoutedEventArgs e)
        {
            semanas = 14;
            corrida.inputTotalSemanasTreino(semanas);
        }

        //Incremento de distância
        private void dist100_Checked(object sender, RoutedEventArgs e)
        {
            incrementoDistancia = 100;
            corrida.inputDistanciaAcrescida(incrementoDistancia);
        }

        private void dist150_Checked(object sender, RoutedEventArgs e)
        {
            incrementoDistancia = 150;
            corrida.inputDistanciaAcrescida(incrementoDistancia);
        }

        private void dist200_Checked(object sender, RoutedEventArgs e)
        {
            incrementoDistancia = 200;
            corrida.inputDistanciaAcrescida(incrementoDistancia);
        }

        private void dist250_Checked(object sender, RoutedEventArgs e)
        {
            incrementoDistancia = 250;
            corrida.inputDistanciaAcrescida(incrementoDistancia);
        }

        private void dist300_Checked(object sender, RoutedEventArgs e)
        {
            incrementoDistancia = 300;
            corrida.inputDistanciaAcrescida(incrementoDistancia);
        }

        private void dist350_Checked(object sender, RoutedEventArgs e)
        {
            incrementoDistancia = 350;
            corrida.inputDistanciaAcrescida(incrementoDistancia);
        }

        private void dist400_Checked(object sender, RoutedEventArgs e)
        {
            incrementoDistancia = 400;
            corrida.inputDistanciaAcrescida(incrementoDistancia);
        }



        //pressionar o botão

        private void GerarTreino_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NomeTextBox.Text))
            {
                nome = NomeTextBox.Text;
            }
            else
            {
                MessageBox.Show("Por favor, insira um nome.");
                erro = true;
            }

            if(semanas == 0)
            {
                MessageBox.Show("Por favor, selecione um ciclo de treinamento.");
                erro = true;
            }

            if (!string.IsNullOrEmpty(distanciaTextBox.Text))
            {
                try
                {
                    distancia = int.Parse(distanciaTextBox.Text);
                    corrida.inputDistanciaUltimoTAF(distancia);
                }
                catch 
                {
                    MessageBox.Show("Por favor, insira um numero válido.");
                    erro = true;
                }

            }
            else
            {
                MessageBox.Show("Por favor, insira um resultado para o último TAF.");
                erro = true;
            }

            if (incrementoDistancia == 0)
            {
                MessageBox.Show("Por favor, selecione um incremento de distância.");
                erro = true;
            }

            //gerar pdf dos treinos
            if (!erro)
            {
                List<int> tempo = corrida.calculaTempoRitimada();
                List<int> distancia = corrida.calculaDistanciaRitimada() ;
                List<int> intervalo = corrida.calculaIntervaloTiro();
                List<int> repeticoes = corrida.calculaRepeticoesTiro();

                string _tempo;
                string _intervalo;
                OutputTreino.escreverCabecalho(nome, semanas);
                
                for(int i = 0; i < semanas; i++)
                {
                    _tempo = Conversor.converterTempo(tempo[i]);
                    _intervalo = Conversor.converterTempo(intervalo[i]);

                    OutputTreino.escreverSemana(i + 1);
                    OutputTreino.escreverContinua(_tempo, distancia[i]);
                    OutputTreino.escreverTiro(_intervalo, repeticoes[i]);
                }

                MessageBox.Show("Arquivo Gerado com Sucesso!");


            }

        }



    }
}
