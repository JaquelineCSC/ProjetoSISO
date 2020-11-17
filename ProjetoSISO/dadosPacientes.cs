using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSISO
{
    class dadosPacientes
    {
        conexao c = new conexao();

        public int IdPacientes { get; set; }
        public string CpfPacientes { get; set; }
        public string NomePacientes { get; set; }
        public string EnderecoPacientes { get; set; }
        public string EstadoPacientes { get; set; }
        public string CepPacientes { get; set; }
        public string CidadePacientes { get; set; }
        public DateTime DataNascimentoPacientes { get; set; }
        public string SexoPacientes { get; set; }
        public string TelefonePacientes { get; set; }
        public string CelularPacientes { get; set; }

        //inserção e Remoção
        public void IncluirDadosPacientes()
        {
            string sql = "";
            sql += "Insert into Pacientes (nomePaciente, CPFPaciente, enderecoPaciente, estadoPaciente, CEPPaciente, cidadePaciente, dataNascPaciente, sexoPaciente, telefonePaciente, celularPaciente) " +
                "values ('" + NomePacientes + "','" + CpfPacientes + "','" + EnderecoPacientes + "','" + EstadoPacientes + "','" + CepPacientes + "','" + CidadePacientes + "','" + DataNascimentoPacientes + "','" + SexoPacientes + "','" + TelefonePacientes + "','" + CelularPacientes + "')";
            c.Executar(sql);
        }

        public void AlterarDadosPacientes()
        {
            string sql = "";
            sql += "Update Pacientes set nomePaciente = '" + NomePacientes + "', CPFPaciente = '" + CpfPacientes + "', enderecoPaciente = '" + EnderecoPacientes + "', estadoPaciente = '" + EstadoPacientes + "', CEPPaciente = '" + CepPacientes + "', cidadePaciente = '" + CidadePacientes + "', dataNascPaciente = '" + DataNascimentoPacientes + "', sexoPaciente = '" + SexoPacientes + "', telefonePaciente = '" + TelefonePacientes + "', celularPaciente = '" + CelularPacientes + "'" +
                "  where idPaciente = " + IdPacientes;
            c.Executar(sql);
        }

        public void ExcluirDadosPacientes()
        {
            string sql = "";
            sql += "Delete from Pacientes where idPaciente = " + IdPacientes;
            c.Executar(sql);
        }

        //Consulta
        public void ConsultarDadosPacientes()
        {
            string sql = "";
            sql += "Select * from Pacientes where idPaciente = " + IdPacientes;
            c.ConsultarPacientes(sql);
            string[] auxiliar = c.Campos.Split(';');
            NomePacientes = auxiliar[0];
            CpfPacientes = auxiliar[1];
            EnderecoPacientes = auxiliar[2];
            EstadoPacientes = auxiliar[3];
            CepPacientes = auxiliar[4];
            CidadePacientes = auxiliar[5];
            DataNascimentoPacientes = DateTime.Parse(auxiliar[6]);
            SexoPacientes = auxiliar[7];
            TelefonePacientes = auxiliar[8];
            CelularPacientes = auxiliar[9];
        }

        //Listagem
        public DataSet ListarDadosPacientes()
        {
            string sql = "SELECT * FROM Pacientes where nomePaciente like '%" + NomePacientes + "%'";
            return c.Listar(sql);
        }
    }
}
