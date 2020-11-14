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
    public partial class FrmRelatório : Form
    {
        public FrmRelatório()
        {
            InitializeComponent();
        }

        private void cmdDentista_Click(object sender, EventArgs e)
        {
            FrmRelatorioDentistas relatorioDentistas = new FrmRelatorioDentistas();
            relatorioDentistas.Show();
        }

        private void cmdPacientes_Click(object sender, EventArgs e)
        {
            FrmRelatorioPaciente relatorioPaciente = new FrmRelatorioPaciente();
            relatorioPaciente.Show();
        }
    }
}
