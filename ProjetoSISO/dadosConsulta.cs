using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSISO
{
    class dadosConsulta
    {
        int idConsulta;
        string descricaoProcedimentoConsulta;
        double valorConsulta;
        int idAgendamento;

        public int IdConsulta { get => idConsulta; set => idConsulta = value; }
        public string DescricaoProcedimentoConsulta { get => descricaoProcedimentoConsulta; set => descricaoProcedimentoConsulta = value; }
        public double ValorConsulta { get => valorConsulta; set => valorConsulta = value; }
        public int IdAgendamento { get => idAgendamento; set => idAgendamento = value; }


    }
}
