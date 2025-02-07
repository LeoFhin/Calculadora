using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calculadora
{
    internal class Historico
    {
        private static string caminhoArquivo = "historico.txt";

        public static void SalvarNoArquivo(string texto)
        {
            File.AppendAllText(caminhoArquivo, texto + Environment.NewLine);
        }

        public static string CarregarHistorico()
        {
            if (File.Exists(caminhoArquivo))
            {
                return "Histórico:\n" + File.ReadAllText(caminhoArquivo);
            }
            return "Histórico vazio.";
        }

        public static void LimparHistorico()
        {
            File.WriteAllText(caminhoArquivo, string.Empty);
        }
    }
}
