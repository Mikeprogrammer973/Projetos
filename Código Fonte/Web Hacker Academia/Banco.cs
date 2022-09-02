using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Web_Hacker_Academia
{
    class Banco
    {
        static MySqlConnection connection;

        public static MySqlConnection Conexao()
        {
            connection = new MySqlConnection("server=localhost;User Id=root;database=wh_academia;password=");
            connection.Open();
            return connection;
        }
       
        public static DataTable GetAllUsers()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Conexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM users";
                    da = new MySqlDataAdapter(cmd.CommandText, Conexao());
                    da.Fill(dt);
                    Conexao().Close();
                    return dt;
                }
            }catch(Exception ex)
            {
                Conexao().Close();
                throw ex;
            }            
        }

        public static DataTable Select(string sql)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Conexao().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new MySqlDataAdapter(cmd.CommandText, Conexao());
                    da.Fill(dt);
                    Conexao().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Conexao().Close();
                throw ex;
            }
        }


        /// Funções do FORM F_GestaoUsers

        public static DataTable GetAllUsersIdName()
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Conexao().CreateCommand())
                {
                    cmd.CommandText = "SELECT id as 'ID Usuario',nome as 'Nome Usuario' FROM users";
                    da = new MySqlDataAdapter(cmd.CommandText, Conexao());
                    da.Fill(dt);
                    Conexao().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Conexao().Close();
                throw ex;
            }
        }

        public static DataTable GetDadosUser(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = Select("SELECT * FROM users WHERE id = '" + id + "'");
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateUser(Usuario  u)
        {
            try
            {
                using(var cmd = Conexao().CreateCommand())
                {
                    cmd.CommandText = "UPDATE users SET nome = '" + u.nome + "',username = '" + u.username + "', senha = '" + u.senha + "', status = '" + u.status + "', level = '" + u.level + "' WHERE id = '" + u.id + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados Atualizados com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexao().Close();
            }
        }

        public static void RemoveUser(string id)
        {
            try
            {
                using (var cmd = Conexao().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM users WHERE id = '" + id + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário(a) Excluido(a) com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexao().Close();
            }
        }

        /// FIM - Funções do FORM F_GestaoUsers

        //////Funções do FORM F_Cadastro

        public static void NovoUsuario(Usuario user)
        {
            if (Banco.Existing_User(user.username))
            {
                MessageBox.Show("Username existente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var cmd = Banco.Conexao().CreateCommand();
                    cmd.CommandText = "INSERT INTO users (nome, username, senha, level, status) VALUES (@nome, @username, @senha, @level, @status)";
                    cmd.Parameters.AddWithValue("@nome", user.nome);
                    cmd.Parameters.AddWithValue("@username", user.username);
                    cmd.Parameters.AddWithValue("@senha", user.senha);
                    cmd.Parameters.AddWithValue("@level", user.level);
                    cmd.Parameters.AddWithValue("@status", user.status);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Banco.Conexao().Close();
                }
            }
        }

        ///FIM - Funções do FORM F_Cadastro
        
        ///////ROTINAS GERAIS
        
        public static bool Existing_User(string username)
        {
            DataTable user = null;
            bool e_u = false;
            try
            {
                user = Banco.Select("SELECT * FROM users WHERE username = '" + username + "'");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Banco.Conexao().Close();
            }
            if (user.Rows.Count > 0)
            {
                if(username == user.Rows[0].Field<string>("username"))
                {
                    e_u = true;
                }
                else
                {
                    e_u = false;
                }
            }
            return e_u;
        }

        
    }
}
