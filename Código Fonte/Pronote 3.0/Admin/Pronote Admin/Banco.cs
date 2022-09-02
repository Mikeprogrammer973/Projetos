using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Pronote_Admin
{
    class Banco
    {
        public static MySqlConnection connection;

        public static MySqlConnection conectar()
        {
            //Colocar a ConnectionString correta...
            connection = new MySqlConnection("server=localhost;User Id=root;database=pronote;password=");
            connection.Open();
            return connection;
        }


        public static DataTable Select(string sql)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conectar().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new MySqlDataAdapter(cmd.CommandText, conectar());
                    da.Fill(dt);
                    conectar().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally 
            {
                conectar().Close();
            }
        }

        public static void New_Admin(string sql, string nome, string code, string email, byte[] foto)
        {
            var cmd = conectar().CreateCommand();
            try
            {
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@foto", foto);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
                conectar().Close();
                MessageBox.Show("Cadastro Realizado Com Sucesso!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Data too long for column 'foto_perfil_adm' at row 1")
                {
                    MessageBox.Show("Imagem muito grande, escolhe uma otra!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //throw ex;
            }
            finally
            {
                conectar().Close();
            }
        }

        public static void Update(string sql)
        {
            try
            {
                var cmd = conectar().CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            finally
            {
                conectar().Close();
            }
        }

        public static void Tempo()
        {
            Thread.Sleep(7000);
        }
    }
}
