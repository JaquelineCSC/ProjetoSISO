using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSISO
{
    class dadosAgendamento
    {
        dadosDentista dentista = new dadosDentista();
        dadosPacientes paciente = new dadosPacientes();
        conexao c = new conexao();
        int idAgendamento;
        string dataAgendamento;
        string horaAgendamento;

        public int IdAgendamento { get => idAgendamento; set => idAgendamento = value; }
        public string DataAgendamento { get => dataAgendamento; set => dataAgendamento = value; }
        public string HoraAgendamento { get => horaAgendamento; set => horaAgendamento = value; }


        public void ConsultarDadosAgendamento()
        {
            string sql = "";
            sql += "select p.nomePaciente, d.nomeDentista, a.dataAgendamento, a.horaAgendamento from Agendamento a inner join Dentistas d on a.idDentista = d.idDentista inner join Pacientes p on a.idPaciente = p.idPaciente";
            c.ConsultarAgendamentos(sql);
            string[] auxiliar = c.Campos.Split(';');
            DataAgendamento = auxiliar[0];
            HoraAgendamento = auxiliar[1];
        }
    }


}
