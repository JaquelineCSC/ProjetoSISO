using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoSISO {
    class conexao {
        private SqlConnection cn = new SqlConnection();
        private SqlCommand cd = new SqlCommand();

        private string campos;

        public string Campos { get => campos; set => campos = value; }

        private void Conectar() {
            string s = "";
            s = "Server=DESKTOP-44I6E3P\\SQLEXPRESS;Database=ProjetoSISO;UID=sa;PWD=123;";
            cn.ConnectionString = s;
            cn.Open();
        }

        public void Executar(string sql) {
            Conectar();
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            cn.Close();
        }

       


        public void Consultar(string sql) {
            Conectar();
            cd.Connection = cn;
            cd.CommandText = sql;
            SqlDataReader dr = cd.ExecuteReader();


            if (dr.Read()) {
                Campos += dr["nomePessoa"].ToString() + ";";
                Campos += dr["ruaPessoa"].ToString() + ";";
                Campos += dr["bairroPessoa"].ToString() + ";";
                Campos += dr["numeroRuaPessoa"].ToString() + ";";
                Campos += dr["cidadePessoa"].ToString() + ";";
                Campos += dr["cepPessoa"].ToString() + ";";
                Campos += dr["dataNascPessoa"].ToString() + ";";
                Campos += dr["celularPessoa"].ToString() + "; ";
                Campos += dr["paisPessoa"].ToString() + ";";
                Campos += dr["sexoPessoa"].ToString() + ";";
                Campos += dr["CRO"].ToString() + ";";
                Campos += dr["especializacao"].ToString();
                cn.Close();
            }
        }

        public DataSet Listar(string sql) {
            Conectar();
            cd.Connection = cn;
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cn.Close();
            return ds;
        }
    }
}
