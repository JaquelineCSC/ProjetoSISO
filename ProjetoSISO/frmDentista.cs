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
    public partial class frmDentista : Form
    {
        Panel p;
        dadosDentista dados = new dadosDentista();
        public frmDentista(Panel pnDentista)
        {
            InitializeComponent();
            p = pnDentista;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Close();
            p.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
            dados.IncluirDadosDentista();

        }
    }
}
