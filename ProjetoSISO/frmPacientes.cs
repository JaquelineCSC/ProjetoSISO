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
    public partial class frmPacientes : Form {
        Panel p;
        dadosPacientes dp = new dadosPacientes();

        public frmPacientes(Panel pnPaciente) {
            InitializeComponent();
            p = pnPaciente;
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Close();
            p.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPacientes_Load(object sender, EventArgs e) {

        }

        private void cmdSalvar_Click(object sender, EventArgs e) {
            dp.NomePacientes = txtNome.Text;
            dp.CpfPacientes = txtCPF.Text;
            dp.EnderecoPacientes = txtEndereco.Text;
            dp.CepPacientes = txtCep.Text;
            dp.TelefonePacientes = txtCelular.Text;
            dp.CelularPacientes = txtCelular.Text;
            dp.DataNascimentoPacientes = dateTimePicker1.Value.ToString("dd/MM/yy");
            dp.EstadoPacientes = cboEstado.SelectedItem.ToString();
            dp.CidadePacientes = txtCidade.Text;
            bool condition = radioButtonFem.Checked;
            dp.SexoPacientes = condition ? "F" : "M";
            dp.IncluirDadosPacientes();
        }
    }
}
