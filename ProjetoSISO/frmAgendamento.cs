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
        
        DateTime hoje = DateTime.Now.Date;

        public frmAgendamento() {
            InitializeComponent();
        }

        private void frmAgendamento_Load(object sender, EventArgs e)
        {
            dentista.NomeDentista = "";
            dgDentista.DataSource = dentista.ListarDadosDentista().Tables[0];
            dgDentista.Columns[0].Visible = false;
            dgDentista.ReadOnly = true;
            dgDentista.MultiSelect = false;
            dgDentista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgDentista.Rows[0].Selected = true;

            paciente.NomePacientes = "";
            dgPaciente.DataSource = paciente.ListarDadosPacientes().Tables[0];
            dgPaciente.Columns[0].Visible = false;
            dgPaciente.ReadOnly = true;
            dgPaciente.MultiSelect = false;
            dgPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPaciente.Rows[0].Selected = true;
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

        }
    }
}
