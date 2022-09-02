using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Pronote_Admin
{
    class Admin
    {
        public static string id;
        public static Image image;
        public static string nome;
        public static bool logado = false;

        public static void Recuperar(string tipo, string id)
        {
            try
            {
                using (var cmd = Banco.conectar().CreateCommand())
                {
                    switch (tipo)
                    {
                        case "escola":
                            cmd.CommandText = "UPDATE escolas SET status = 'C' WHERE code_escola = '" + id + "'";
                            break;
                        case "turma":
                            cmd.CommandText = "UPDATE turmas SET status = 'C' WHERE code_turma = '" + id + "'";
                            break;
                        case "aluno":
                            cmd.CommandText = "UPDATE alunos SET status = 'C' WHERE matricula = '" + id + "'";
                            break;
                        case "prof":
                            cmd.CommandText = "UPDATE profs SET status = 'C' WHERE code_prof = '" + id + "'";
                            break;
                        case "materia":
                            cmd.CommandText = "UPDATE cargos_prof SET status = 'C' WHERE code_disciplina = '" + id + "'";
                            break;
                        case "nota":
                            cmd.CommandText = "UPDATE notas_alunos SET status = 'C' WHERE code_nota = '" + id + "'";
                            break;
                        case "media":
                            cmd.CommandText = "UPDATE info_alunos SET status = 'C' WHERE code_media = '" + id + "'";
                            break;
                    }
                    cmd.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Banco.conectar().Close();
            }
        }

        public static void Add_Escola(string code, string nome, string adm, string periodo, int qtd_p, byte[] foto)
        {
            var cmd = Banco.conectar().CreateCommand();
            try
            {
                cmd.CommandText = "INSERT INTO escolas (code_escola, nome_escola, foto_perfil_escola, code_adm_escola, tipo_periodo, qtd_periodo) VALUES (@code, @nome, @foto, @adm, @tipo_p, @qtd_p)";
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@adm", adm);
                cmd.Parameters.AddWithValue("@foto", foto);
                cmd.Parameters.AddWithValue("@tipo_p", periodo);
                cmd.Parameters.AddWithValue("@qtd_p", qtd_p);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Escola Adicionada Com Sucesso!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (ex.Message == "Data too long for column 'foto_perfil_escola' at row 1")
                {
                    MessageBox.Show("Imagem muito grande, escolhe uma otra!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                Banco.conectar().Close();
            }

        }

        public static void Arquivar_Escola(string code)
        {
            try
            {
                var cmd = Banco.conectar().CreateCommand();
                cmd.CommandText = "UPDATE escolas SET status = 'A' WHERE code_escola = '" + code + "'";
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Banco.conectar().Close();
            }
        }

        public static void Remove_Escola(string code)
        {
            try
            {
                var cmd = Banco.conectar().CreateCommand();
                cmd.CommandText = "DELETE FROM escolas WHERE code_escola = '" + code + "'";
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Escola Removida com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Banco.conectar().Close();
            }
        }

        public static void Add_Turma(string escola, string code, string nome, byte[] foto)
        {
            try
            {
                var cmd = Banco.conectar().CreateCommand();
                cmd.CommandText = "INSERT INTO turmas (code_escola, code_turma, nome_turma, foto_perfil_turma) VALUES (@escola, @code, @nome, @foto)";
                cmd.Parameters.AddWithValue("@escola", escola);
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@foto", foto);
                cmd.ExecuteNonQuery();
                Banco.conectar().Close();
                MessageBox.Show("Turma Adicionada Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Banco.conectar().Close();
                if(ex.Message == "Data too long for column 'foto_perfil_turma' at row 1")
                {
                    MessageBox.Show("Imagem muito grande, escolhe uma otra!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void Arquivar_Turma(string code)
        {
            try
            {
                var cmd = Banco.conectar().CreateCommand();
                cmd.CommandText = "UPDATE turmas SET status = 'A' WHERE code_turma = '" + code + "'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Banco.conectar().Close();
            }
        }

        public static void Remove_Turma(string code)
        {
            try
            {
                var cmd = Banco.conectar().CreateCommand();
                cmd.CommandText = "DELETE FROM turmas WHERE code_turma = '" + code + "'";
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Banco.conectar().Close();
            }
        }
        public static void Add_Aluno(string matricula, string escola, string nome, string turma, byte[] foto)
        {
            try
            {
                var cmd = Banco.conectar().CreateCommand();
                cmd.CommandText = "INSERT INTO alunos (code_escola, code_turma, matricula, nome_completo, foto_perfil_aluno,senha) VALUES (@escola, @turma, @mat, @nome, @foto,@senha)";
                cmd.Parameters.AddWithValue("@escola", escola);
                cmd.Parameters.AddWithValue("@turma", turma);
                cmd.Parameters.AddWithValue("@mat", matricula);
                cmd.Parameters.AddWithValue("@senha", matricula);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@foto", foto);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Aluno Adicionado Com Sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Banco.conectar().Close();
                if (ex.Message == "Data too long for column 'foto_perfil_aluno' at row 1")
                {
                    MessageBox.Show("Imagem muito grande, escolhe uma otra!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                Banco.conectar().Close();
            }
        }

        public static void Arquivar_Aluno(string matricula)
        {
            try
            {
                using (var cmd = Banco.conectar().CreateCommand())
                {
                    cmd.CommandText = "UPDATE alunos SET status = 'A' WHERE matricula = '" + matricula + "'";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Banco.conectar().Close();
            }
        }

        public static void Transferir_Aluno(string matricula, string turma)
        {
            try
            {
                using (var cmd = Banco.conectar().CreateCommand())
                {
                    cmd.CommandText = "UPDATE alunos SET code_turma = '" + turma + "' WHERE matricula = '" + matricula + "'";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Banco.conectar().Close();
            }
        }

        public static void Remove_Aluno(string matricula)
        {
            try
            {
                using (var cmd = Banco.conectar().CreateCommand())
                {
                    cmd.CommandText = "DELETE alunos WHERE matricula = '" + matricula + "'";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Banco.conectar().Close();
            }
        }
    }
}
