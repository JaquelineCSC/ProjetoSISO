﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSISO {
    public partial class frmPacientes : Form 
    {
        Panel p;
        dadosPacientes dp;

        public frmPacientes(Panel pnPaciente) 
        {
            InitializeComponent();
            p = pnPaciente;
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            this.Close();
            p.Enabled = true;
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            cboEstado.SelectedIndex = 12;
        }

        private void cmdSalvar_Click(object sender, EventArgs e) 
        {
            dp.NomePacientes = txtNome.Text;
            dp.CpfPacientes = txtCPF.Text;
            dp.EnderecoPacientes = txtEndereco.Text;
            dp.CepPacientes = txtCep.Text;
            dp.TelefonePacientes = txtCelular.Text;
            dp.CelularPacientes = txtCelular.Text;
            dp.DataNascimentoPacientes = dateTimePicker1.Value;
            dp.EstadoPacientes = cboEstado.SelectedItem.ToString();
            dp.CidadePacientes = txtCidade.Text;
            bool condition = radioButtonFem.Checked;
            dp.SexoPacientes = condition ? "F" : "M";
            if (Conferir())
            {
                dp.IncluirDadosPacientes();
                MessageBox.Show("Cadastro feito com sucesso!");
                Limpar();
                groupBox1.Enabled = false;
            }
            else
                MessageBox.Show("Preencha todas informações!");
            
        }

        private void cmdLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        public bool Conferir()
        {
            int i = 0;
            foreach (Control item in this.groupBox1.Controls)
            {
                if ((item is TextBox) && (item.Text == "") && (item != txtTelefone))
                    i++;
            }
            if ((radioButtonFem.Checked == false) && (radioButtonMasc.Checked == false))
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
                cboEstado.SelectedIndex = 12;
                radioButtonMasc.Checked = false;
                radioButtonFem.Checked = false;
            }
        }

        private void cmdAdicionar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            dp = new dadosPacientes();
            Limpar();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            FrmConsulta frm = new FrmConsulta(1);
            frm.Show();
        }
    }
}
