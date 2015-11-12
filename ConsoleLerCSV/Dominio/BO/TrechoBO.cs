using ConsoleLerCSV.Dominio.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLerCSV.Dominio.TrechoBO
{
    public class TrechoBO
    {
        MessageBO messageBO = new MessageBO();

        public bool TrechoEhValido(Trecho trecho)
        {
            return !(trecho.KmFinal <= trecho.kmInicial);
        }
    }
}
