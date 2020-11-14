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

        private void FrmRelatório_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'ProjetoSISODataSet.Agendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.AgendamentoTableAdapter.Fill(this.ProjetoSISODataSet.Agendamento);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void cmdGerarRelatorio_Click(object sender, EventArgs e)
        {

        }
    }
}
