using ConsoleLerCSV.Dominio;
using ConsoleLerCSV.Dominio.Contratos;
using ConsoleLerCSV.Dominio.TrechoBO;
using ConsoleLerCSV.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLerCSV.Infra
{
    public class TrechoInfra : ITrechoCrud
    {
        TrechoBO trechoBO = new TrechoBO();
        private Contexto _contexto;

        public TrechoInfra()
        {
            _contexto = new Contexto();
        }


        public List<Dominio.Trecho> ObterTodos()
        {
            var result = _contexto.CsvReader.LerArquivo();
            var splits = CsvReader.Split(result);

            var trechos = new List<Trecho>();

            foreach (var split in splits)
            {

                var trecho = new Trecho
                {
                    BR = split[0],
                    UF = split[1],
                    Codigo = split[2],
                    LocalInicio = split[3],
                    LocalFim = split[4],
                    kmInicial = Double.Parse(split[5]),
                    KmFinal = Double.Parse(split[6]),

                };

                if (trechoBO.TrechoEhValido(trecho))
                {
                    trechos.Add(trecho);
                }
            }

            return trechos;
        }


        public void Incluir()
        {
            throw new NotImplementedException();
        }

        public void Deletar()
        {
            throw new NotImplementedException();
        }

        public void Pesquisar(Func<bool, Dominio.Trecho> func)
        {
            throw new NotImplementedException();
        }
    }
}
