using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSISO {
    class dadosPacientes {
        conexao c = new conexao();
        private int idPacientes;
        private string cpfPacientes;
        private string nomePacientes;
        private string enderecoPacientes;
        private string estadoPacientes;
        private string cepPacientes;
        private string cidadePacientes;
        private string dataNascimentoPacientes;
        private string sexoPacientes;
        private string telefonePacientes;
        private string celularPacientes;

        public int IdPacientes { get => idPacientes; set => idPacientes = value; }
        public string CpfPacientes { get => cpfPacientes; set => cpfPacientes = value; }
        public string NomePacientes { get => nomePacientes; set => nomePacientes = value; }
        public string EnderecoPacientes { get => enderecoPacientes; set => enderecoPacientes = value; }
        public string EstadoPacientes { get => estadoPacientes; set => estadoPacientes = value; }
        public string CepPacientes { get => cepPacientes; set => cepPacientes = value; }
        public string CidadePacientes { get => cidadePacientes; set => cidadePacientes = value; }
        public string DataNascimentoPacientes { get => dataNascimentoPacientes; set => dataNascimentoPacientes = value; }
        public string SexoPacientes { get => sexoPacientes; set => sexoPacientes = value; }
        public string TelefonePacientes { get => telefonePacientes; set => telefonePacientes = value; }
        public string CelularPacientes { get => celularPacientes; set => celularPacientes = value; }

        public void IncluirDadosPacientes() {
            string sql = "";
            sql += "Insert into Pacientes (nomePaciente, CPFPaciente, enderecoPaciente, estadoPaciente, CEPPaciente, cidadePaciente, dataNascPaciente, sexoPaciente, telefonePaciente, celularPaciente) " +
                "values ('" + nomePacientes+ "','" + cpfPacientes + "','" + enderecoPacientes + "','" + estadoPacientes + "','" + cepPacientes + "','" + cidadePacientes + "','" + dataNascimentoPacientes + "','" + sexoPacientes + "','" + telefonePacientes + "','" + celularPacientes + "')";
            c.Executar(sql);
        }


        public void AlterarDadosPacientes() {
            string sql = "";
            sql += "Update Pacientes set nomePaciente = '" + nomePacientes + "', CPFPaciente = '" + CpfPacientes + "', enderecoPaciente = '" + enderecoPacientes + "', estadoPaciente = '" + estadoPacientes + "', CEPPaciente = '" + cepPacientes + "', cidadePaciente = '" + cidadePacientes + "', dataNascPaciente = '" + dataNascimentoPacientes + "', sexoPaciente = '" + sexoPacientes + "', telefonePaciente = '" + telefonePacientes + "', celularPaciente = '" + celularPacientes + "'" +
                "  where idPaciente = " + idPacientes;
            c.Executar(sql);
        }

        public void ExcluirDadosPacientes() {
            string sql = "";
            sql += "Delete from Pacientes where idPaciente = " + idPacientes;
            c.Executar(sql);
        }


        public void ConsultarDadosPacientes() {
            string sql = "";
            sql += "Select * from Pacientes where idPaciente = " + idPacientes;
            c.Consultar(sql);
            string[] auxiliar = c.Campos.Split(';');
            nomePacientes = auxiliar[1];
            CpfPacientes = auxiliar[2];
            enderecoPacientes = auxiliar[3];
            estadoPacientes = auxiliar[4];
            cepPacientes = auxiliar[5];
            cidadePacientes = auxiliar[6];
            dataNascimentoPacientes = auxiliar[7];
            sexoPacientes = auxiliar[8];
            telefonePacientes = auxiliar[9];
            celularPacientes = auxiliar[10];
        }

        public DataSet ListarDadosPacientes() {
            string sql = "SELECT * FROM Pacientes";
            return c.Listar(sql);
        }
    }
}
