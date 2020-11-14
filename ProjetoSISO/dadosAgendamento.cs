using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSISO
{
    class dadosAgendamento
    {
        int idAgendamento;
        string dataAgendamento;
        string horaAgendamento;

        public int IdAgendamento { get => idAgendamento; set => idAgendamento = value; }
        public string DataAgendamento { get => dataAgendamento; set => dataAgendamento = value; }
        public string HoraAgendamento { get => horaAgendamento; set => horaAgendamento = value; }


    }
}
