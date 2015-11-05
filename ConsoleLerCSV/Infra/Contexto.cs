using ConsoleLerCSV.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLerCSV.Infra
{
    public class Contexto
    {
        public CsvReader CsvReader { get; private set; }
        public Contexto()
        {
            CsvReader = new CsvReader(@"C:\users\flavio.leal\documents\exercicios\snv.csv");
        }
    }
}
