using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSISO {
    public partial class frmAgendamento : Form {
        dadosDentista dentista = new dadosDentista();
        dadosPacientes paciente = new dadosPacientes();
        dadosAgendamento agendamento;
        
        DateTime hoje = DateTime.Now.Date;

        Panel p;


        public frmAgendamento(Panel p) {
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

            paciente.NomePacientes = "";
            dgPaciente.DataSource = paciente.ListarDadosPacientes().Tables[0];
            dgPaciente.Columns[0].Visible = false;
            dgPaciente.ReadOnly = true;
            dgPaciente.MultiSelect = false;
            dgPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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
            dentista.IdDentista = Convert.ToInt32(dgDentista.Rows[e.RowIndex].Cells[0].Value.ToString());
            dentista.ConsultarDadosDentista();
            agendamento.ConsultarDadosAgendamento();
            dgAgendamentos.DataSource = agendamento.ListarDadosAgendamentos().Tables[0];
            lbNomeDent.Text = dentista.NomeDentista;
            lbEspDent.Text = dentista.EspecializacaoDentista;
        }

        private void dgPaciente_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            paciente.IdPacientes = Convert.ToInt32(dgPaciente.Rows[e.RowIndex].Cells[0].Value.ToString());
            paciente.ConsultarDadosPacientes();
            lbNomePac.Text = paciente.NomePacientes;
            lbCpfPac.Text = paciente.CpfPacientes;
            lbNascPac.Text = paciente.DataNascimentoPacientes.ToString("d");
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
    }
}
