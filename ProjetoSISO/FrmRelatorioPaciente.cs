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
    public partial class FrmRelatorioPaciente : Form
    {
        public FrmRelatorioPaciente()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
          
        }

        private void FrmRelatorioPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ProjetoSISO2DataSet.Pacientes'. Você pode movê-la ou removê-la conforme necessário.
            this.PacientesTableAdapter.Fill(this.ProjetoSISO2DataSet.Pacientes);
        }
    }
}
