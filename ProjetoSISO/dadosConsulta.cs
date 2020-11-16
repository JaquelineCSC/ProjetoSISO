﻿using System;
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

        public dadosConsulta() { }
        public dadosConsulta(dadosAgendamento a, dadosDentista d, dadosPacientes p)
        {
            agendamento = a;
            dentista = d;
            paciente = p;
        }

        public int IdConsulta { get; set; }
        public string DescricaoProcedimentoConsulta { get; set; }
        public double ValorConsulta { get; set; }
        public int IdAgendamento { get; set; }

        public void InserirConsulta()
        {
            string sql = "insert into Consulta (descricaoProcedimentoConsulta, valorConsulta, idAgendamento) values ('" + DescricaoProcedimentoConsulta + "', " + ValorConsulta + ", " + agendamento.IdAgendamento;
            c.Executar(sql);
        }
    }
}
