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
            Limpar();
            agendamento = new dadosAgendamento(dentista, paciente);
            dgAgenda.ReadOnly = true;
            dgAgenda.MultiSelect = false;
            dgAgenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            agendamento.DataAgendamento = Calendar.SelectionRange.Start.Date;

            dgAgenda.DataSource = agendamento.ListarDadosAgendamentosPorData().Tables[0];
            dgAgenda.Columns[0].Visible = false;
        }

        private void dgAgenda_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgAgenda.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                agendamento.IdAgendamento = Convert.ToInt32(dgAgenda.Rows[e.RowIndex].Cells[0].Value.ToString());
                agendamento.ConsultarDadosAgendamentoPorIdPessoa();
                lbNomeDent.Text = dentista.NomeDentista;
                lbEspDent.Text = dentista.EspecializacaoDentista;
                lbNomePac.Text = paciente.NomePacientes;
                lbCpfPac.Text = paciente.CpfPacientes;
                lbNascPac.Text = paciente.DataNascimentoPacientes.ToString("d");
                lblHora.Text = agendamento.HoraAgendamento;
                lbDataAg.Text = agendamento.DataAgendamento.ToString("d");
                dgAgenda.Columns[1].HeaderText = "Paciente";
                dgAgenda.Columns[2].HeaderText = "Dentista";
                dgAgenda.Columns[3].HeaderText = "Data";
                dgAgenda.Columns[4].HeaderText = "Horário";
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            lblValor.Text = txtValor.Text;
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            if (Conferir())
            {
                consulta = new dadosConsulta(agendamento, dentista, paciente);
                consulta.ValorConsulta = Convert.ToDouble(lblValor.Text.ToString());
                consulta.DescricaoProcedimentoConsulta = txtProcedimento.Text;
                consulta.InserirConsulta();
                MessageBox.Show("Agendamento efetuado com sucesso");
                Limpar();
            }
            else
                MessageBox.Show("Preencha todas as informações");
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Close();
            p.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            paciente.NomePacientes = textBox1.Text;
            dgAgenda.DataSource = agendamento.ListarDadosPorNome().Tables[0];
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public bool Conferir()
        {
            if ((lbNomeDent.Text == "") || (lbNomePac.Text == "") || (lbCpfPac.Text == "") || (lbDataAg.Text == "") || (lbEspDent.Text == "") || (lblHora.Text == "") || (lbNascPac.Text == ""))
                return false;
            else
                return true;
        }

        public void Limpar()
        {
            lbNomeDent.Text = "";
            lbNomePac.Text = "";
            lbCpfPac.Text = "";
            lbDataAg.Text = "";
            lbEspDent.Text = "";
            lblHora.Text = "";
            lbNascPac.Text = "";
            lblValor.Text = "";
        }
    }
}
