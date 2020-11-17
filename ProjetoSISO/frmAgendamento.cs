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
    public partial class frmAgendamento : Form
    {
        dadosDentista dentista = new dadosDentista();
        dadosPacientes paciente = new dadosPacientes();
        dadosAgendamento agendamento;

        Panel p;

        public frmAgendamento(Panel p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void frmAgendamento_Load(object sender, EventArgs e)
        {
            dgAgendamentos.ReadOnly = true;
            dgAgendamentos.MultiSelect = false;
            dgAgendamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            agendamento = new dadosAgendamento(dentista, paciente);
            dentista.NomeDentista = "";
            dgDentista.DataSource = dentista.ListarDadosDentista().Tables[0];
            dgDentista.Columns[0].Visible = false;
            dgDentista.ReadOnly = true;
            dgDentista.MultiSelect = false;
            dgDentista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDentista.Columns[0].Visible = false;
            EsconderColunas(dgDentista);
            dgDentista.Columns[3].Visible = true;
            dgDentista.Columns[3].HeaderText = "Dentista";
            dgDentista.Columns[12].Visible = true;
            dgDentista.Columns[12].HeaderText = "Especialização";


            paciente.NomePacientes = "";
            dgPaciente.DataSource = paciente.ListarDadosPacientes().Tables[0];
            dgPaciente.Columns[0].Visible = false;
            dgPaciente.ReadOnly = true;
            dgPaciente.MultiSelect = false;
            dgPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            EsconderColunas(dgPaciente); //015
            dgPaciente.Columns[1].Visible = true;
            dgPaciente.Columns[1].HeaderText = "Paciente";
            dgPaciente.Columns[2].Visible = true;
            dgPaciente.Columns[2].HeaderText = "CPF";
            dgPaciente.Columns[6].Visible = true;
            dgPaciente.Columns[6].HeaderText = "Cidade";

            dgAgendamentos.Columns[0].HeaderText = "Paciente";
            dgAgendamentos.Columns[1].HeaderText = "Dentista";
            dgAgendamentos.Columns[2].HeaderText = "Data";
            dgAgendamentos.Columns[3].HeaderText = "Hora";

            Limpar();
        }

        private void txtDentista_TextChanged(object sender, EventArgs e)
        {
            dentista.NomeDentista = txtDentista.Text;
            dgDentista.DataSource = dentista.ListarDadosDentista().Tables[0];
        }

        private void txtPaciente_TextChanged(object sender, EventArgs e)
        {
            paciente.NomePacientes = txtPaciente.Text;
            dgPaciente.DataSource = paciente.ListarDadosPacientes().Tables[0];
        }

        private void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            agendamento.DataAgendamento = Calendar.SelectionRange.Start.Date;
            agendamento.ConsultarDadosAgendamento();
            dgAgendamentos.DataSource = agendamento.ListarDadosAgendamentos().Tables[0];
            lbDataAg.Text = Calendar.SelectionRange.Start.Date.ToString("d");
        }

        private void dgDentista_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgDentista.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                dentista.IdDentista = Convert.ToInt32(dgDentista.Rows[e.RowIndex].Cells[0].Value.ToString());
                dentista.ConsultarDadosDentista();
                agendamento.ConsultarDadosAgendamento();
                dgAgendamentos.DataSource = agendamento.ListarDadosAgendamentos().Tables[0];
                lbNomeDent.Text = dentista.NomeDentista;
                lbEspDent.Text = dentista.EspecializacaoDentista;
            }
        }

        private void dgPaciente_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgPaciente.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                paciente.IdPacientes = Convert.ToInt32(dgPaciente.Rows[e.RowIndex].Cells[0].Value.ToString());
                paciente.ConsultarDadosPacientes();
                lbNomePac.Text = paciente.NomePacientes;
                lbCpfPac.Text = paciente.CpfPacientes;
                lbNascPac.Text = paciente.DataNascimentoPacientes.ToString("d");
            }
        }

        private void cbHora_SelectedValueChanged(object sender, EventArgs e)
        {
            lbHora.Text = cbHora.SelectedItem.ToString();
            agendamento.HoraAgendamento = cbHora.SelectedItem.ToString();
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {
            if (Conferir())
            {
                agendamento.InserirAgendamento();
                MessageBox.Show("Agendamento efetuado com sucesso");
                Limpar();
            }
            else
                MessageBox.Show("Preencha todas as informações");
        }

        public bool Conferir()
        {
            if ((lbNomeDent.Text == "") || (lbNomePac.Text == "") || (lbCpfPac.Text == "") || (lbDataAg.Text == "") || (lbEspDent.Text == "") || (lbHora.Text == "") || (lbNascPac.Text == ""))
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
            lbHora.Text = "";
            lbNascPac.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            p.Enabled = true;
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }
        public void EsconderColunas(DataGridView date)
        {
            for (int i = 0; i < date.Columns.Count; i++)
                date.Columns[i].Visible = false;
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            frmExcluirAgendamento frm = new frmExcluirAgendamento();
            frm.Show();
        }
    }
}
