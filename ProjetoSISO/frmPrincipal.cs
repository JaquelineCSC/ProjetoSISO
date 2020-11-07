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

        private void Form1_Load(object sender, EventArgs e)
        {
            
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

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
