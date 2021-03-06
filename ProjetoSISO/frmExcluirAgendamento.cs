﻿using System;
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
    public partial class frmExcluirAgendamento : Form
    {
        dadosDentista dentista = new dadosDentista();
        dadosPacientes paciente = new dadosPacientes();
        dadosAgendamento agendamento;

        public frmExcluirAgendamento()
        {
            InitializeComponent();
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja excluir agendamento", "Projeto SISO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                agendamento.ExcluirAgendamento();
                dgAgenda.DataSource = agendamento.ListarDadosPorNome().Tables[0];
                Limpar();
            }
        }

        private void dgAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgAgenda.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                agendamento.IdAgendamento = Convert.ToInt32(dgAgenda.Rows[e.RowIndex].Cells["idAgendamento"].Value.ToString());
                agendamento.ConsultarDadosAgendamentoPorIdPessoa();
                lbNomeDent.Text = dentista.NomeDentista;
                lbEspDent.Text = dentista.EspecializacaoDentista;
                lbNomePac.Text = paciente.NomePacientes;
                lbCpfPac.Text = paciente.CpfPacientes;
                lbNascPac.Text = paciente.DataNascimentoPacientes.ToString("d");
                lblHora.Text = agendamento.HoraAgendamento;
                lbDataAg.Text = agendamento.DataAgendamento.ToString("d");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            paciente.NomePacientes = textBox1.Text;
            dgAgenda.DataSource = agendamento.ListarDadosPorNome().Tables[0];
            
        }

        private void frmExcluirAgendamento_Load(object sender, EventArgs e)
        {
            agendamento = new dadosAgendamento(dentista, paciente);
            paciente.NomePacientes = "";
            dgAgenda.DataSource = agendamento.ListarDadosPorNome().Tables[0];
            Limpar();
            dgAgenda.ReadOnly = true;
            dgAgenda.MultiSelect = false;
            dgAgenda.Columns[0].Visible = false;
            dgAgenda.Columns[1].HeaderText = "Paciente";
            dgAgenda.Columns[2].Visible = false;
            dgAgenda.Columns[3].HeaderText = "Data";
            dgAgenda.Columns[4].HeaderText = "Hora";
            dgAgenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }
    }
}
