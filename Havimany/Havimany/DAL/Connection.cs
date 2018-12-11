using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Havimany.DAL
{
    class Connection
    {
        protected String stringConexao = "Data Source=25.3.189.156;Initial Catalog=Havimany;Persist Security Info=True;User ID=sa;Password=1234qwer;";
        protected SqlConnection conexao;
        protected SqlCommand cmd;
        protected SqlDataReader resultSet;
        //transaction

        public Connection()
        {
            this.conexao = new SqlConnection();
            this.conexao.ConnectionString = this.stringConexao;
        }

        public SqlDataReader Pesquisa(String query)
        {
            try
            {
                this.cmd = new SqlCommand(query, this.conexao);
                this.resultSet = cmd.ExecuteReader();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            return resultSet;
        }

        public int VerificaSenha(String login, String senha)
        {
            int i = 0;
            String query = "declare @nome varchar(30)," +
                          "@senha varchar(20)," +
                          "@aux varbinary(100)" +
                          " set @nome ='" + login + "'" +
                          " set @senha ='" + senha + "'" +
                          " select @aux=SENHA from US_USUARIO where USUARIO=@nome" +
                          " select pwdCompare(@senha,@aux,0) as ResultadoQuery";
            SqlDataReader reader = Pesquisa(query);
            String nomeTipo = "";
            reader.Read();
            nomeTipo = reader["ResultadoQuery"].ToString();
            i = Convert.ToInt32(nomeTipo);
            return i;
        }
        public void AdicionarNovoUsuario(String login, String senha)
        {
            String query = "declare @nome varchar(30),@senha varchar(20)," +
                 "@aux varbinary(100) set @nome ='" + login + "' set @senha ='" + senha + "' set @aux=Convert(varbinary(100),pwdEncrypt(@senha))" +
                 "INSERT INTO US_USUARIO(USUARIO,SENHA) VALUES(@nome,@aux)";
            try
            {
                Pesquisa(query);
                MessageBox.Show("Funcionou!");
            }
            catch
            {
                MessageBox.Show("abc");
            }
        }

        public SqlDataReader Tabela(int numeroHandle, String tabela)
        {
            String query = "select * from " + tabela + " where handle = " + numeroHandle;
            return this.Pesquisa(query);
        }

        public void Inserir(String query)
        {
            this.cmd = new SqlCommand(query, this.conexao);
            cmd.ExecuteNonQuery();
        }

        //DATATABLE
        public DataTable DataTable(String query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            try
            {
                this.cmd = new SqlCommand(query, this.conexao);
                adapter.SelectCommand = cmd;
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(table);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }


            return table;
        }


        //open
        public void Conectar()
        {
            try
            {
                this.conexao.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        public void Desconectar()
        {
            try
            {
                this.conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

    }
}
