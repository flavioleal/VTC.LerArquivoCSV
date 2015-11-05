using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLerCSV.Dominio.Contratos
{
    public interface ITrechoCrud
    {
        List<Trecho> ObterTodos();
        void Incluir();
        void Deletar();
        void Pesquisar(Func<bool, Trecho> func);
    }
}
