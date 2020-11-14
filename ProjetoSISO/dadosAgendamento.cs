﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;

namespace ProjetoSISO
{
    class dadosAgendamento
    {
        dadosDentista dentista;
        dadosPacientes paciente;
        conexao c = new conexao();
        int idAgendamento;
        string dataAgendamento;
        string horaAgendamento;

        public dadosAgendamento(dadosDentista d, dadosPacientes p)
        {
            dentista = d;
            paciente = p;
        }
        public int IdAgendamento { get => idAgendamento; set => idAgendamento = value; }
        public string DataAgendamento { get => dataAgendamento; set => dataAgendamento = value; }
        public string HoraAgendamento { get => horaAgendamento; set => horaAgendamento = value; }


        //public void ConsultarDadosAgendamento()
        //{
        //    string sql = "";
        //    sql += "select p.nomePaciente, d.nomeDentista, a.dataAgendamento, a.horaAgendamento from Agendamento a inner join Dentistas d on a.idDentista = d.idDentista inner join Pacientes p on a.idPaciente = p.idPaciente where d.idDentista = " + dentista.IdDentista + " and a.dataAgendamento = " + DataAgendamento;
        //    c.ConsultarAgendamentos(sql);
        //    string[] auxiliar = c.Campos.Split(';');
        //    paciente.NomePacientes = auxiliar[0];
        //    dentista.NomeDentista = auxiliar[1];
        //    DataAgendamento = auxiliar[2];
        //    HoraAgendamento = auxiliar[3];
        //}

        public void ConsultarDadosAgendamento()
        {
            string sql = "";
            sql += "select * from Agendamento where idDentista = " + dentista.IdDentista + " and dataAgendamento = '" + DataAgendamento+"'";
            c.ConsultarAgendamentos(sql);
            string[] auxiliar = c.Campos.Split(';');
            if(auxiliar[0]!="")
            {
                IdAgendamento = int.Parse(auxiliar[0]);
                DataAgendamento = auxiliar[1];
                HoraAgendamento = auxiliar[2];

            }
        }

        public DataSet ListarDadosAgendamentos()
        {
            string sql = "select p.nomePaciente, d.nomeDentista, a.dataAgendamento, a.horaAgendamento from Agendamento a inner join Dentistas d on a.idDentista = d.idDentista inner join Pacientes p on a.idPaciente = p.idPaciente where d.idDentista = " + dentista.IdDentista + " and a.dataAgendamento = '" + DataAgendamento + "'";
            return c.Listar(sql);
        }
    }


}
