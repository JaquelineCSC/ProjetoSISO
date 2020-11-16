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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdDentista_Click(object sender, EventArgs e)
        {
            panelMenuEsquerda.Enabled = false;
            frmDentista janela = new frmDentista(panelMenuEsquerda);
            janela.TopLevel = false;
            janela.Visible = true;
            panelForm.Controls.Add(janela);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPacientes janela = new frmPacientes(panelMenuEsquerda);
            janela.TopLevel = false;
            janela.Visible = true;
            panelForm.Controls.Add(janela);
            panelMenuEsquerda.Enabled = false;
        }

        public void HabilitarMenu()
        {
            panelMenuEsquerda.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAgendamento janela = new frmAgendamento(panelMenuEsquerda);
            janela.TopLevel = false;
            janela.Visible = true;
            panelForm.Controls.Add(janela);
            panelMenuEsquerda.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmRelatório relatório = new FrmRelatório();
            relatório.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmConsultaDia janela = new frmConsultaDia(panelMenuEsquerda);
            janela.TopLevel = false;
            janela.Visible = true;
            panelForm.Controls.Add(janela);
            panelMenuEsquerda.Enabled = false;
        }
    }
}
