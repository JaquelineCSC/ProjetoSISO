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
    public partial class FrmRelatorioDentistas : Form
    {
        public FrmRelatorioDentistas()
        {
            InitializeComponent();
        }

        private void FrmRelatorioDentistas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ProjetoSISO2DataSet.Dentistas'. Você pode movê-la ou removê-la conforme necessário.
            this.DentistasTableAdapter.Fill(this.ProjetoSISO2DataSet.Dentistas);

            this.reportViewer1.RefreshReport();
        }
    }
}
