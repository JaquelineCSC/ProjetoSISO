using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSISO
{
    public partial class frmConsultaDia : Form
    {
        Panel p;
        dadosDentista dentista = new dadosDentista();
        dadosPacientes paciente = new dadosPacientes();
        dadosAgendamento agendamento;
        dadosConsulta consulta;

        public frmConsultaDia(Panel p)
        {
            this.p = p;
            InitializeComponent();
        }

        private void frmConsultaDia_Load(object sender, EventArgs e)
        {
            agendamento = new dadosAgendamento(dentista, paciente);
            dgAgenda.ReadOnly = true;
            dgAgenda.MultiSelect = false;
            dgAgenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            agendamento.DataAgendamento = Calendar.SelectionRange.Start.Date;
            agendamento.ConsultarDadosAgendamento();
            dgAgenda.DataSource = agendamento.ListarDadosAgendamentos().Tables[0];
            

        }

        private void dgAgenda_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            agendamento.IdAgendamento = Convert.ToInt32(dgAgenda.Rows[e.RowIndex].Cells[0].Value.ToString());
            lbNomeDent.Text = dentista.NomeDentista;
            lbEspDent.Text = dentista.EspecializacaoDentista;
            lbCpfPac.Text = paciente.CpfPacientes;
            lbNascPac.Text = paciente.DataNascimentoPacientes.ToString("d");
            lblHora.Text = agendamento.HoraAgendamento;
            lbDataAg.Text = agendamento.DataAgendamento.ToString("d");
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            lblValor.Text = txtValor.Text;

        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {

            consulta = new dadosConsulta();

        }
    }
}
