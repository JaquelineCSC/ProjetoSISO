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
        dadosPacientes paciente= new dadosPacientes();
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
                dataGridView1.ReadOnly = true;
                dataGridView1.MultiSelect = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Rows[0].Selected = true;
            }
            if(tipo==1)
            {
                paciente.NomePacientes = "";
                dataGridView1.DataSource = paciente.ListarDadosPacientes().Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.MultiSelect = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Rows[0].Selected = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tipo==0)
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
