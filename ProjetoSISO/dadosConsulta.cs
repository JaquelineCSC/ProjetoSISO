using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;

namespace ProjetoSISO
{
    class dadosConsulta
    {
        dadosAgendamento agendamento;
        dadosPacientes paciente;
        dadosDentista dentista;
        conexao c = new conexao();
        int idConsulta;
        string descricaoProcedimentoConsulta;
        double valorConsulta;
        int idAgendamento;

        public dadosConsulta() { }
        public dadosConsulta(dadosAgendamento a, dadosDentista d, dadosPacientes p)
        {
            agendamento = a;
            dentista = d;
            paciente = p;
        }

        public int IdConsulta { get => idConsulta; set => idConsulta = value; }
        public string DescricaoProcedimentoConsulta { get => descricaoProcedimentoConsulta; set => descricaoProcedimentoConsulta = value; }
        public double ValorConsulta { get => valorConsulta; set => valorConsulta = value; }
        public int IdAgendamento { get => idAgendamento; set => idAgendamento = value; }

        public void InserirConsulta()
        {
            string sql = "insert into Consulta (descricaoProcedimentoConsulta, valorConsulta, idAgendamento) values ('" + DescricaoProcedimentoConsulta + "', " + ValorConsulta + ", " + agendamento.IdAgendamento;
            c.Executar(sql);
        }
    }
}
