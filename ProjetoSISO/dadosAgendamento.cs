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
        DateTime dataAgendamento;

        public dadosAgendamento(dadosDentista d, dadosPacientes p)
        {
            dentista = d;
            paciente = p;
        }

        public dadosAgendamento() { }

        public int IdAgendamento { get; set; }
        public DateTime DataAgendamento { get => dataAgendamento; set => dataAgendamento = value; }
        public string HoraAgendamento { get; set; }


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
            sql += "select * from Agendamento where idDentista = " + dentista.IdDentista + " and dataAgendamento = '" + DataAgendamento + "'";
            c.ConsultarAgendamentos(sql);
            string[] auxiliar = c.Campos.Split(';');
            if (auxiliar[0] != "")
            {
                IdAgendamento = int.Parse(auxiliar[0]);
                DataAgendamento = DateTime.Parse(auxiliar[1]);
                HoraAgendamento = auxiliar[2];
            }
        }

        public void ConsultarDadosAgendamentoPorIdPessoa()
        {
            string sql = "";
            sql += "select p.nomePaciente, p.CPFPaciente, p.dataNascPaciente, d.nomeDentista, d.especializacaoDentista, a.dataAgendamento, a.horaAgendamento from Agendamento a inner join Dentistas d on a.idDentista = d.idDentista inner join Pacientes p on a.idPaciente = p.idPaciente where idAgendamento = " + IdAgendamento;
            c.ConsultarAgendamentosIDPessoa(sql);
            string[] auxiliar = c.Campos.Split(';');
            if (auxiliar[0] != "")
            {
                paciente.NomePacientes = auxiliar[0];
                paciente.CpfPacientes = auxiliar[1];
                paciente.DataNascimentoPacientes = Convert.ToDateTime(auxiliar[2]);
                dentista.NomeDentista = auxiliar[3];
                dentista.EspecializacaoDentista = auxiliar[4];
                DataAgendamento = Convert.ToDateTime(auxiliar[5]);
                HoraAgendamento = auxiliar[6];
            }
        }

        public void ConsultarDadosAgendamentoPorId()
        {
            string sql = "";
            sql += "select * from Agendamento where idDentista = " + dentista.IdDentista;
            c.ConsultarAgendamentos(sql);
            string[] auxiliar = c.Campos.Split(';');
            if (auxiliar[0] != "")
            {
                IdAgendamento = int.Parse(auxiliar[0]);
                DataAgendamento = DateTime.Parse(auxiliar[1]);
                HoraAgendamento = auxiliar[2];
            }
        }

        public DataSet ListarDadosAgendamentosPorData()
        {
            string sql = "select a.idAgendamento, p.nomePaciente, d.nomeDentista, a.dataAgendamento, a.horaAgendamento from Agendamento a inner join Dentistas d on a.idDentista = d.idDentista inner join Pacientes p on a.idPaciente = p.idPaciente where a.dataAgendamento = '" + DataAgendamento.ToString() + "'";
            return c.Listar(sql);
        }

        public DataSet ListarDadosAgendamentos()
        {
            string sql = "select p.nomePaciente, d.nomeDentista, a.dataAgendamento, a.horaAgendamento from Agendamento a inner join Dentistas d on a.idDentista = d.idDentista inner join Pacientes p on a.idPaciente = p.idPaciente where d.idDentista = " + dentista.IdDentista + " and a.dataAgendamento = '" + DataAgendamento + "'";
            return c.Listar(sql);
        }

        public DataSet ListarDadosPorNome()
        {
            string sql = "select a.idAgendamento, p.nomePaciente, d.nomeDentista, a.dataAgendamento, a.horaAgendamento from Agendamento a inner join Dentistas d on a.idDentista = d.idDentista inner join Pacientes p on a.idPaciente = p.idPaciente where p.nomePaciente  like '%" + paciente.NomePacientes + "%'";
            return c.Listar(sql);
        }

        public DataSet ListarDadosAgendamentosSemOID()
        {
            string sql = "select p.nomePaciente, d.nomeDentista, a.dataAgendamento, a.horaAgendamento from Agendamento a inner join Dentistas d on a.idDentista = d.idDentista inner join Pacientes p on a.idPaciente = p.idPaciente";
            return c.Listar(sql);
        }

        public void InserirAgendamento()
        {
            string sql = "insert into Agendamento (dataAgendamento, horaAgendamento, idPaciente, idDentista) values ('" + dataAgendamento + "', '" + HoraAgendamento + "', " + paciente.IdPacientes + "," + dentista.IdDentista + ")";
            c.Executar(sql);
        }

        public void ExcluirAgendamento()
        {
            string sql = "delete from Agendamento where idAgendamento = " + IdAgendamento;
            c.Executar(sql);
        }
    }


}
