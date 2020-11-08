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
    public partial class frmDentista : Form
    {
        Panel p;
        dadosDentista dados;
        public frmDentista(Panel pnDentista)
        {
            InitializeComponent();
            p = pnDentista;
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Close();
            p.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            dados = new dadosDentista();
            Limpar();
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            dados.NomeDentista = txtNome.Text;
            bool condition = radioButton1.Checked;
            dados.SexoDentista = condition ? "F" : "M";
            dados.DataNascimentoDentista = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            dados.CpfDentista = txtCPF.Text;
            dados.EnderecoDentista = txtEndereco.Text;
            dados.CidadeDentista = txtCidade.Text;
            dados.EstadoDentista = cbEstado.SelectedIndex.ToString();
            dados.CepDentista = txtCep.Text;
            dados.CelularDentista = txtCelular.Text;
            dados.TelefoneDentista = txtTelefone.Text;
            dados.CroDentista = txtCRO.Text;
            dados.EspecializacaoDentista = txtEspecializacao.Text;
            
            if (Conferir())
            {
                dados.IncluirDadosDentista();
                MessageBox.Show("Cadastro feito com sucesso!");
                Limpar();
                groupBox1.Enabled = false;
            }
            else
                MessageBox.Show("Preencha todas informações!");
        }

        public bool Conferir()
        {
            int i = 0;
            foreach (Control item in this.groupBox1.Controls)
            {
                if ((item is TextBox) && (item.Text == ""))
                    i++;
            }
            if ((radioButton1.Checked == false) && (radioButton2.Checked == false))
                i++;
            if (i == 0)
                return true;
            else
                return false;
        }

        public void Limpar()
        {
            foreach (Control item in this.groupBox1.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                cbEstado.SelectedIndex = 0;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmConsulta frm = new FrmConsulta(0);
            frm.Show();
        }

        private void frmDentista_Load(object sender, EventArgs e)
        {

        }
    }
}
