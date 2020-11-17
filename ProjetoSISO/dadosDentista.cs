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

        public int IdDentista { get; set; }
        public string CpfDentista { get; set; }
        public string CroDentista { get; set; }
        public string NomeDentista { get; set; }
        public string EnderecoDentista { get; set; }
        public string EstadoDentista { get; set; }
        public string CepDentista { get; set; }
        public string CidadeDentista { get; set; }
        public DateTime DataNascimentoDentista { get; set; }
        public string SexoDentista { get; set; }
        public string TelefoneDentista { get; set; }
        public string CelularDentista { get; set; }
        public string EspecializacaoDentista { get; set; }

        //Inserção e Remoção
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
            sql += "Update Dentistas set CPFDentista = '" + CpfDentista + "', CROdentista = '" + CroDentista + "', nomeDentista = '" + NomeDentista + "', enderecoDentista = '" + EnderecoDentista + "', estadoDentista = '" + EstadoDentista + "', CEPDentista = '" + CepDentista + "', cidadeDentista = '" + CidadeDentista + "',dataNascDentista = '" + DataNascimentoDentista + "', sexoDentista = '" + SexoDentista + "', telefoneDentista = '" + TelefoneDentista + "', celularDentista = '" + CelularDentista + "', especializacaoDentista = '" + EspecializacaoDentista + "'  where idDentista = " + IdDentista.ToString();
            c.Executar(sql);
        }

        public void ExcluirDadosDentista()
        {
            string sql = "";
            sql += "Delete from Dentistas where idDentista = " + IdDentista.ToString();
            c.Executar(sql);
        }


        //Consulta
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
            CepDentista = auxiliar[5];
            CidadeDentista = auxiliar[6];
            DataNascimentoDentista = DateTime.Parse(auxiliar[7]);
            SexoDentista = auxiliar[8];
            TelefoneDentista = auxiliar[9];
            CelularDentista = auxiliar[10];
            EspecializacaoDentista = auxiliar[11];
        }

        //Listagem
        public DataSet ListarDadosDentista()
        {
            string sql = "SELECT * FROM Dentistas where nomeDentista like '%" + NomeDentista + "%'";
            return c.Listar(sql);
        }

    }
}
