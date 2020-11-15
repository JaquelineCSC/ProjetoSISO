using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace ProjetoSISO
{
    public partial class FrmRelatório : Form
    {
        dadosDentista dentista = new dadosDentista();
        dadosPacientes pacientes = new dadosPacientes();
        private int i;
        public FrmRelatório()
        {
            InitializeComponent();
        }

        private void cmdDentista_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Relatório de Dentistas";
            pd.BeginPrint += pd_beginPrint;
            pd.PrintPage += ImprimirDentistas;

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private void cmdPacientes_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.DocumentName = "Relatório de Pacientes";
            pd.BeginPrint += pd_beginPrint;
            pd.PrintPage += ImprimirPacientes;

            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private void cmdAgenda_Click(object sender, EventArgs e)
        {

        }

        private void pd_beginPrint(object sender, PrintEventArgs e)
        {
            i = 0;
        }

        private void ImprimirDentistas(object sender, PrintPageEventArgs e)
        {
            //configurações da página
            float linhaPorPagina = 0;
            float posicaoVertical = 0;
            float contador = 0;
            float margemEsquerda = 20;
            float margemSuperior = 20;
            float alturaFonte = 0;
            string linha = "";

            Font fonte = new Font("Calibri", 14);
            alturaFonte = fonte.GetHeight(e.Graphics);
            linhaPorPagina = Convert.ToInt32(e.MarginBounds.Height / alturaFonte);

            //Título
            linha = "Lista de Dentistas";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador += 4;

            //SubTítulo
            linha = "CRO";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            linha = "Dentista";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 150, posicaoVertical);

            linha = "Especialização";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 400, posicaoVertical);

            contador += 1;

            linha = "____________________________________________________________________________________________________";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;

            DataSet ds = dentista.ListarDadosDentista();

            if (ds.Tables[0] != null)
            {
                while (i < ds.Tables[0].Rows.Count && contador < linhaPorPagina)
                {
                    DataRow item = ds.Tables[0].Rows[i];

                    linha = item["croDentista"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

                    linha = item["nomeDentista"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 150, posicaoVertical);

                    linha = item["especializacaoDentista"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 400, posicaoVertical);

                    contador += 2;
                    i++;
                }

                if (contador < linhaPorPagina)
                {
                    linha = "Total de Dentistas: " + i.ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 100, posicaoVertical);
                }
            }
            else MessageBox.Show("Tabela vazia");

            if (contador > linhaPorPagina)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void ImprimirPacientes(object sender, PrintPageEventArgs e)
        {
            //configurações da página
            float linhaPorPagina = 0;
            float posicaoVertical = 0;
            float contador = 0;
            float margemEsquerda = 20;
            float margemSuperior = 20;
            float alturaFonte = 0;
            string linha = "";

            Font fonte = new Font("Calibri", 14);
            alturaFonte = fonte.GetHeight(e.Graphics);
            linhaPorPagina = Convert.ToInt32(e.MarginBounds.Height / alturaFonte);

            //Título
            linha = "Lista de Pacientes";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador += 4;

            //SubTítulo
            linha = "CPF";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            linha = "Nome";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 150, posicaoVertical);

            linha = "Cidade";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 400, posicaoVertical);

            linha = "Celular";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 550, posicaoVertical);

            contador += 1;

            linha = "____________________________________________________________________________________________________";
            posicaoVertical = margemSuperior + contador * alturaFonte;
            e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

            contador++;

            DataSet ds = pacientes.ListarDadosPacientes();

            if (ds.Tables[0] != null)
            {
                while (i < ds.Tables[0].Rows.Count && contador < linhaPorPagina)
                {
                    DataRow item = ds.Tables[0].Rows[i];

                    linha = item["CPFPaciente"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda, posicaoVertical);

                    linha = item["nomePaciente"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 150, posicaoVertical);

                    linha = item["cidadePaciente"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 400, posicaoVertical);

                    linha = item["celularPaciente"].ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 550, posicaoVertical);

                    contador += 2;
                    i++;
                }

                if (contador < linhaPorPagina)
                {
                    linha = "Total de Pacientes: " + i.ToString();
                    posicaoVertical = margemSuperior + contador * alturaFonte;
                    e.Graphics.DrawString(linha, fonte, Brushes.Black, margemEsquerda + 100, posicaoVertical);
                }
            }
            else MessageBox.Show("Tabela vazia");

            if (contador > linhaPorPagina)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }
    }
}
