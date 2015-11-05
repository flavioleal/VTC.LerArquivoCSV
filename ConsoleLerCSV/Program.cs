using ConsoleLerCSV.Dominio;
using ConsoleLerCSV.Dominio.Contratos;
using ConsoleLerCSV.Infra;
using ConsoleLerCSV.Negocio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLerCSV
{
    class Program
    {
        static void Main(string[] args)
        {

            ITrechoCrud trechoInfra = new TrechoInfra();
            var result = trechoInfra.ObterTodos();

            Console.ReadKey();

        }
    }
}
