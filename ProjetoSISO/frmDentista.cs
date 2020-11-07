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
    public partial class frmDentista : Form
    {
        Panel p;
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
    }
}
