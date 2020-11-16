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
    public partial class FrmConsulta : Form
    {
        dadosDentista dentista = new dadosDentista();
        dadosPacientes paciente = new dadosPacientes();
        int tipo;
        public FrmConsulta(int t)
        {
            InitializeComponent();
            tipo = t;
        }

        private void FrmConsulta_Load(object sender, EventArgs e)
        {
            if(tipo == 0)
            {
                dentista.NomeDentista = "";
                dataGridView1.DataSource = dentista.ListarDadosDentista().Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].HeaderText = "CRO";
                dataGridView1.Columns[3].HeaderText = "Dentista";
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].HeaderText = "Especialização";
                dataGridView1.ReadOnly = true;
                dataGridView1.MultiSelect = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Rows[0].Selected = true;
            }
            else
            {
                label12.Visible = false;
                label11.Visible = false;
                txtCRO.Visible = false;
                txtEspecializacao.Visible = false;
                txtCRO.Text = ".";
                txtEspecializacao.Text = ".";
                paciente.NomePacientes = "";
                dataGridView1.DataSource = paciente.ListarDadosPacientes().Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Paciente";
                dataGridView1.Columns[2].HeaderText = "CPF";
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].HeaderText = "Cidade";
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].HeaderText = "Celular";
                dataGridView1.ReadOnly = true;
                dataGridView1.MultiSelect = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Rows[0].Selected = true;
            }
        }


        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir?", "Projeto SISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (tipo == 0)
                {
                    dentista.ExcluirDadosDentista();
                    dentista.NomeDentista = "";
                    dataGridView1.DataSource = dentista.ListarDadosDentista().Tables[0];
                }
                else
                {
                    paciente.ExcluirDadosPacientes();
                    paciente.NomePacientes = "";
                    dataGridView1.DataSource = paciente.ListarDadosPacientes().Tables[0];
                }
            }
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            if (tipo==0)
            {
                dentista.NomeDentista = txtNome.Text;
                bool condition = radioButton1.Checked;
                dentista.SexoDentista = condition ? "F" : "M";
                dentista.DataNascimentoDentista = dateTimePicker1.Value;
                dentista.CpfDentista = txtCPF.Text;
                dentista.EnderecoDentista = txtEndereco.Text;
                dentista.CidadeDentista = txtCidade.Text;
                dentista.EstadoDentista = cbEstado.SelectedItem.ToString();
                dentista.CepDentista = txtCep.Text;
                dentista.CelularDentista = txtCelular.Text;
                dentista.TelefoneDentista = txtTelefone.Text;
                dentista.CroDentista = txtCRO.Text;
                dentista.EspecializacaoDentista = txtEspecializacao.Text;

                if (Conferir())
                {
                    dentista.AlterarDadosDentista();
                    MessageBox.Show("Alteração efetuada com sucesso!");
                    dentista.NomeDentista = "";
                    dataGridView1.DataSource = dentista.ListarDadosDentista().Tables[0];
                }
                else
                    MessageBox.Show("Preencha todas informações!");
            }
            else
            {
                paciente.NomePacientes = txtNome.Text;
                bool condition = radioButton1.Checked;
                paciente.SexoPacientes = condition ? "F" : "M";
                paciente.DataNascimentoPacientes = dateTimePicker1.Value;
                paciente.CpfPacientes = txtCPF.Text;
                paciente.EnderecoPacientes = txtEndereco.Text;
                paciente.CidadePacientes = txtCidade.Text;
                paciente.EstadoPacientes = cbEstado.SelectedItem.ToString();
                paciente.CepPacientes = txtCep.Text;
                paciente.CelularPacientes = txtCelular.Text;
                paciente.TelefonePacientes = txtTelefone.Text;

                if (Conferir())
                {
                    paciente.AlterarDadosPacientes();
                    MessageBox.Show("Alteração efetuada com sucesso!");
                    paciente.NomePacientes = "";
                    dataGridView1.DataSource = paciente.ListarDadosPacientes().Tables[0];
                }
                else
                    MessageBox.Show("Preencha todas informações!");
            }            
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                if (tipo == 0)
                {
                    groupBox1.Enabled = true;
                    dentista.IdDentista = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    dentista.ConsultarDadosDentista();
                    txtNome.Text = dentista.NomeDentista;
                    if (dentista.SexoDentista == "F")
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;
                    dateTimePicker1.Value = Convert.ToDateTime(dentista.DataNascimentoDentista);
                    txtCPF.Text = dentista.CpfDentista;
                    txtEndereco.Text = dentista.EnderecoDentista;
                    txtCidade.Text = dentista.CidadeDentista;
                    txtCep.Text = dentista.CepDentista;
                    cbEstado.SelectedItem = dentista.EstadoDentista;
                    txtCelular.Text = dentista.CelularDentista;
                    txtTelefone.Text = dentista.TelefoneDentista;
                    txtCRO.Text = dentista.CroDentista;
                    txtEspecializacao.Text = dentista.EspecializacaoDentista;
                }
                else
                {
                    groupBox1.Enabled = true;
                    paciente.IdPacientes = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    paciente.ConsultarDadosPacientes();
                    txtNome.Text = paciente.NomePacientes;
                    if (paciente.SexoPacientes == "F")
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;
                    dateTimePicker1.Value = Convert.ToDateTime(paciente.DataNascimentoPacientes);
                    txtCPF.Text = paciente.CpfPacientes;
                    txtEndereco.Text = paciente.EnderecoPacientes;
                    txtCidade.Text = paciente.CidadePacientes;
                    txtCep.Text = paciente.CepPacientes;
                    cbEstado.SelectedItem = paciente.EstadoPacientes;
                    txtCelular.Text = paciente.CelularPacientes;
                    txtTelefone.Text = paciente.TelefonePacientes;
                }
            }
        }

        private void txtxNome_TextChanged(object sender, EventArgs e)
        {
            if (tipo == 0)
            {
                dentista.NomeDentista = txtxNome.Text;
                dataGridView1.DataSource = dentista.ListarDadosDentista().Tables[0];
            }
            else
            {
                paciente.NomePacientes = txtxNome.Text;
                dataGridView1.DataSource = paciente.ListarDadosPacientes().Tables[0];
            }
        }
    }
}
