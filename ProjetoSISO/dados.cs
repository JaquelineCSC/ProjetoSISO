using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoSISO {
    class dados {
        private int cpf;
        private string nome;
        private string celular;
        private char sexo;
        private string cidade;
        private string rua;
        private string estado;
        private string bairro;
        private string numero;
        private string cep;
        private string pais;
        private string dataNasc;

        private conexao conexao = new conexao();

        public int Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Celular { get => celular; set => celular = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Rua { get => rua; set => rua = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Pais { get => pais; set => pais = value; }
        public string DataNasc { get => dataNasc; set => dataNasc = value; }

        public void IncluirDados() {
            string sql = "";
            sql += "Insert into Pessoas (CPFPessoa, nomePessoa, ruaPessoa, bairroPessoa, numeroRuaPessoa, cidadePessoa, cepPessoa, estadoPessoa, dataNascPessoa, celularPessoa, paisPessoa, sexoPessoa, CRO, especializacao) " +
                "values " +
                "('" + cpf.ToString() + "', '" + Nome + "', '" + Rua + "', '" + Bairro + "', '" + Numero + "', '" + Cidade + "', '" + Cep + "', '" + Estado + "', '" + DataNasc + "', '" + Celular + "', '" + Pais + "', '" + Sexo + "', '" + "NULL" + "', '" + "NULL" + "')";
            conexao.Incluir(sql);
        }


        public void AlterarDados() {
            string sql = "";
            sql = "Update Pessoas set nomePessoa = '" + Nome + "', ruaPessoa = '" + Rua + "', bairroPessoa = '" + Bairro + "', numeroRuaPessoa = '" + Numero + "', cidadePessoa = '" + Cidade + "', cepPessoa = '" + Cep + "', estadoPessoa = '" + Estado + "', dataNascPessoa = '" + dataNasc + "', celularPessoa = '" + Celular + "', paisPessoa = '" + Pais + "'  where CPFPessoa = " + Cpf.ToString();
            conexao.Alterar(sql);
        }

        public void ExcluirDados() {
            string sql = "";
            sql += "Delete from Pessoas where CPFPessoa = " + Cpf.ToString();
            conexao.Excluir(sql);
        }


        public void ConsultarDados() {
            string sql = "";
            sql = "Select * from Pessoas where CPFPessoa = " + Cpf.ToString();
            conexao.Consultar(sql);
            string[] auxiliar = conexao.Campos.Split(';');
            Nome = auxiliar[0];
            Rua = auxiliar[1];
            Bairro = auxiliar[2];
            Numero = auxiliar[3];
            Cidade = auxiliar[4];
            Cep = auxiliar[5];
            Estado = auxiliar[6];
            DataNasc = auxiliar[7];
            Celular = auxiliar[8];
            Pais = auxiliar[9];
        }

        public DataSet ListarDados() {
            string sql = "SELECT * FROM Pessoas";
            return conexao.Listar(sql);
        }
    }
}
