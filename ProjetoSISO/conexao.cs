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
            s= @"Server=.\SQLEXPRESS;Database=ProjetoSISO;UID=sa;PWD=123;";
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

       


        public void ConsultarPacientes(string sql) {
            Conectar();
            cd.Connection = cn;
            cd.CommandText = sql;
            SqlDataReader dr = cd.ExecuteReader();

            Campos = "";
            if (dr.Read()) {
                Campos += dr["nomePaciente"].ToString() + ";";
                Campos += dr["CPFPaciente"].ToString() + ";";
                Campos += dr["enderecoPaciente"].ToString() + ";";
                Campos += dr["estadoPaciente"].ToString() + ";";
                Campos += dr["CEPPaciente"].ToString() + ";";
                Campos += dr["cidadePaciente"].ToString() + ";";
                Campos += dr["dataNascPaciente"].ToString() + ";";
                Campos += dr["sexoPaciente"].ToString() + "; ";
                Campos += dr["telefonePaciente"].ToString() + ";";
                Campos += dr["celularPaciente"].ToString() + ";";
                cn.Close();
            }
        }

        public void ConsultarDentistas(string sql) {
            Conectar();
            cd.Connection = cn;
            cd.CommandText = sql;
            SqlDataReader dr = cd.ExecuteReader();

            Campos = "";
            if (dr.Read()) {
                Campos += dr["CPFDentista"].ToString() + ";";
                Campos += dr["CRODentista"].ToString() + ";";
                Campos += dr["nomeDentista"].ToString() + ";";
                Campos += dr["enderecoDentista"].ToString() + ";";
                Campos += dr["estadoDentista"].ToString() + ";";
                Campos += dr["cepDentista"].ToString() + ";";
                Campos += dr["cidadeDentista"].ToString() + ";";
                Campos += dr["dataNascDentista"].ToString() + "; ";
                Campos += dr["sexoDentista"].ToString() + ";";
                Campos += dr["telefoneDentista"].ToString() + ";";
                Campos += dr["celularDentista"].ToString() + ";";
                Campos += dr["especializacaoDentista"].ToString();
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
