using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLerCSV.Negocio
{
    public class CsvReader
    {
        private StreamReader _rd;

        public CsvReader(string caminho)
        {
            _rd = new StreamReader(caminho);
        }

        public List<string> LerArquivo()
        {
            var linhas = new List<string>();
            string linha = null;

            bool cabecalho = false;

            while ((linha = _rd.ReadLine()) != null)
            {
                if (!cabecalho)
                {
                    cabecalho = true;
                    continue;
                }
                linhas.Add(linha);
                Console.WriteLine(linha);
            }

            return linhas; 
        }

        public static List<string[]> Split(List<string> linhas)
        {
            var splits = new List<string[]>();
            foreach (var linha in linhas)
            {
                var split = linha.Split(';');
                splits.Add(split);
            }

            return splits;
        }
    }
}
