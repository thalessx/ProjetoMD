using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Projeto_MD5
{
    public partial class TelaLogin : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection();
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Escolaweb\source\repos\Projeto_MD5\Projeto_MD5\TelaBD.mdf;Integrated Security=True";

        public TelaLogin()
        {
            //projeto
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #region Botão de Acesso
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            Codificando codificando = new Codificando();
            string textocodificado = codificando.Criptografando(txtSenha.Text);

            string sql = "(SELECT * FROM TELA_LOGIN WHERE NOMELOGIN = '" + txtUsuario.Text + "' and SENHA = '" + textocodificado + "')";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            reader = cmd.ExecuteReader();
            try
            {
                if (!reader.Read())
                {
                    MessageBox.Show("Login errado...");
                }
                else
                {
                    MessageBox.Show("Login efetuado com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops! " + ex.ToString());
            }
            finally
            {
                con.Close();
            }


        }
        #endregion

        #region Botão de Registro
        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            if (txtSenha.Text == "" || txtUsuario.Text == "")
            {
                MessageBox.Show("Verifique se existem valores adicionados!");
            }
            else
            {

                Codificando codificando = new Codificando();
                string textocodificado = codificando.Criptografando(txtSenha.Text);

                string sql = "INSERT INTO TELA_LOGIN (NOMELOGIN, SENHA)"
                        + "VALUES ('" + txtUsuario.Text + "' , '" + textocodificado + "')";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int t = cmd.ExecuteNonQuery();
                    if (t > 0)
                        MessageBox.Show("Cadastro Realizado!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ops! ", ex.ToString());
                }
                finally
                {
                    con.Close();
                }
                txtSenha.Clear();
                txtUsuario.Clear();
            }
        }
        #endregion

        #region Mostrar senha
        private void mostrarsenhaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (mostrarsenhaCB.Checked == true)
            {
                txtSenha.PasswordChar = char.Parse("\0");
            }
            else
            {
                txtSenha.PasswordChar = char.Parse("*");
            }
        }
        #endregion


    }
}
