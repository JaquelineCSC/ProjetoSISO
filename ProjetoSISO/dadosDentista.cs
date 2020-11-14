using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSISO
{
    class dadosDentista
    {
        conexao c = new conexao();
        private int idDentista;
        private string cpfDentista;
        private string croDentista;
        private string nomeDentista;
        private string enderecoDentista;
        private string estadoDentista;
        private string cepDentista;
        private string cidadeDentista;
        private string dataNascimentoDentista;
        private string sexoDentista;
        private string telefoneDentista;
        private string celularDentista;
        private string especializacaoDentista;

        public int IdDentista { get => idDentista; set => idDentista = value; }
        public string CpfDentista { get => cpfDentista; set => cpfDentista = value; }
        public string CroDentista { get => croDentista; set => croDentista = value; }
        public string NomeDentista { get => nomeDentista; set => nomeDentista = value; }
        public string EnderecoDentista { get => enderecoDentista; set => enderecoDentista = value; }
        public string EstadoDentista { get => estadoDentista; set => estadoDentista = value; }
        public string CepDentista { get => cepDentista; set => cepDentista = value; }
        public string CidadeDentista { get => cidadeDentista; set => cidadeDentista = value; }
        public string DataNascimentoDentista { get => dataNascimentoDentista; set => dataNascimentoDentista = value; }
        public string SexoDentista { get => sexoDentista; set => sexoDentista = value; }
        public string TelefoneDentista { get => telefoneDentista; set => telefoneDentista = value; }
        public string CelularDentista { get => celularDentista; set => celularDentista = value; }
        public string EspecializacaoDentista { get => especializacaoDentista; set => especializacaoDentista = value; }

        public void IncluirDadosDentista()
        {
            string sql = "";
            sql += "Insert into Dentistas (CPFDentista,CRODentista,nomeDentista,enderecoDentista,estadoDentista,CEPDentista,cidadeDentista,dataNascDentista,sexoDentista,telefoneDentista,celularDentista,especializacaoDentista) " +
                "values ('" + CpfDentista + "','" + CroDentista.ToString() + "','" + NomeDentista + "','" + EnderecoDentista + "','" + EstadoDentista + "','" + CepDentista + "','" + CidadeDentista + "','" + DataNascimentoDentista + "','" + SexoDentista + "','" + TelefoneDentista + "','" + CelularDentista + "','" + EspecializacaoDentista + "')";
            c.Executar(sql);
        }


        public void AlterarDadosDentista()
        {
            string sql = "";
            sql += "Update Dentistas set CPFDentista = '" + CpfDentista + "', CROdentista = '" + CroDentista + "', nomeDentista = '" + NomeDentista + "', enderecoDentista = '" + EnderecoDentista + "', estadoDentista = '" + EstadoDentista + "', CEPDentista = '" + CepDentista + "', cidadeDentista = '" + CidadeDentista + "',dataNascDentista = '" + dataNascimentoDentista + "', sexoDentista = '" + SexoDentista + "', telefoneDentista = '" + TelefoneDentista + "', celularDentista = '" + CelularDentista + "', especializacaoDentista = '" +EspecializacaoDentista + "'  where idDentista = " + IdDentista.ToString();
            c.Executar(sql);
        }

        public void ExcluirDadosDentista()
        {
            string sql = "";
            sql += "Delete from Dentistas where idDentista = " + IdDentista.ToString();
            c.Executar(sql);
        }


        public void ConsultarDadosDentista()
        {
            string sql = "";
            sql += "Select * from Dentistas where idDentista = " + IdDentista;
            c.ConsultarDentistas(sql);
            string[] auxiliar = c.Campos.Split(';');
            CpfDentista = auxiliar[0];
            CroDentista = auxiliar[1];
            NomeDentista = auxiliar[2];
            EnderecoDentista = auxiliar[3];
            EstadoDentista = auxiliar[4];
            cepDentista = auxiliar[5];
            cidadeDentista = auxiliar[6];
            dataNascimentoDentista = auxiliar[7];
            sexoDentista = auxiliar[8];
            telefoneDentista = auxiliar[9];
            celularDentista = auxiliar[10];
            especializacaoDentista = auxiliar[11];
        }

        public DataSet ListarDadosDentista()
        {
            string sql = "SELECT * FROM Dentistas where nomeDentista like '%" + NomeDentista + "%'";
            return c.Listar(sql);
        }
    }
}
