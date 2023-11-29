using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EB_Run.Core
{
    internal class OutputTreino
    {
        static string diretorio = AppDomain.CurrentDomain.BaseDirectory;
        static string path = "";

        public static void definePath(string nome){
            //cria o path para o arquivo
            string nomeArquivo = nome + "_teinoEB_Run.txt";
            path = Path.Combine(diretorio, nomeArquivo);

        }
        public static void escreverCabecalho(string nome, int ciclo)
        {

            using (StreamWriter writer = new StreamWriter(path))
            {
                // Escrever o conteúdo no arquivo
                writer.WriteLine($"Nome: {nome}");
                writer.WriteLine($"Ciclo de Treino: {ciclo.ToString()}\n\n");
            }
           
        }

        public static void escreverSemana(int i)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                // Escrever o conteúdo no arquivo
                writer.WriteLine($"Semana: {i.ToString()}");
            }
        }

        public static void escreverContinua(string tempo_continua, int distancia_continua)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                // Escrever o conteúdo no arquivo
                writer.WriteLine("Corrida Continua:");
                writer.WriteLine($"\tTempo: {tempo_continua}");
                writer.WriteLine($"\tDistância (metros): {distancia_continua.ToString()}");
            }
        }

        public static void escreverTiro(string intervalo, int repeticoes)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                // Escrever o conteúdo no arquivo
                writer.WriteLine("Tiro:");
                writer.WriteLine($"\tTempo: 1min30s");
                writer.WriteLine($"\tDistância (metros): 400");
                writer.WriteLine($"\tIntervalo: {intervalo}");
                writer.WriteLine($"\tRepetições: {repeticoes.ToString()}\n");
            }
        }


    }
}
