using System;
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
        DateTime dataAgendamento;
        string horaAgendamento;

        public dadosAgendamento(dadosDentista d, dadosPacientes p)
        {
            dentista = d;
            paciente = p;
        }
        public int IdAgendamento { get => idAgendamento; set => idAgendamento = value; }
        public DateTime DataAgendamento { get => dataAgendamento; set => dataAgendamento = value; }
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
                DataAgendamento = DateTime.Parse(auxiliar[1]);
                HoraAgendamento = auxiliar[2];

            }
        }

        public DataSet ListarDadosAgendamentos()
        {
            string sql = "select p.nomePaciente, d.nomeDentista, a.dataAgendamento, a.horaAgendamento from Agendamento a inner join Dentistas d on a.idDentista = d.idDentista inner join Pacientes p on a.idPaciente = p.idPaciente where d.idDentista = " + dentista.IdDentista + " and a.dataAgendamento = '" + DataAgendamento + "'";
            return c.Listar(sql);
        }

        public void InserirAgendamento()
        {
            string sql = "insert into Agendamento (dataAgendamento, horaAgendamento, idPaciente, idDentista) values ('" + dataAgendamento + "', '" + horaAgendamento + "', " + paciente.IdPacientes + "," +  dentista.IdDentista + ")";
            c.Executar(sql);
        }
    }


}
