using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SistemaLogin
{
    public partial class frmLogin : Form
    {
        //dados do utilizador
        string utilizador = "josh";
        string password = "1982";


        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            //fechar a aplicação
            Application.Exit();
        }

        private void cmd_entrar_Click(object sender, EventArgs e)
        {
            //verificar se o login é correto
            if (text_utilizador.Text == "" || text_password.Text == "")
                return;

            bool entrar = true;
            string codigo = CriarMD5(text_password.Text);

            //verifica se houve falha de introdução dos dados
            if (text_utilizador.Text != utilizador || 
                codigo != CriarMD5(password))
            {
                MessageBox.Show("Dados de login inválidos.");
                entrar = false;
            }

            //se o login é correto, abre o menu principal
            if (entrar)
            {
                this.Hide();
                frmMenu f = new frmMenu();
                f.ShowDialog();
            }
        }

        private void check_visualizar_password_CheckedChanged(object sender, EventArgs e)
        {
            //visualiza ou esconde o texto da password
            if (check_visualizar_password.Checked)
            {
                //mostrar a password
                text_password.PasswordChar = '\0';
            }
            else
            {
                //esconder a password
                text_password.PasswordChar = '*';
            }
        }

        private string CriarMD5(string texto)
        {
            //encriptar com o algoritmo MD5 o texto fornecido.
            MD5 criador = MD5.Create();
            byte[] inputs = Encoding.ASCII.GetBytes(texto);
            byte[] hash = criador.ComputeHash(inputs);

            StringBuilder final = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                final.Append(hash[i].ToString("X2"));
            }
            return final.ToString();
        }
    }
}

/*
 * na base de dados - ASGDJASDHGSDHGASDHGSYTUYWTR
 * na aplicação o utilizador indica: utilizador e password
 * pega na password e transforma em MD5
 * depois vê se password (MD5) == password guardada na base de dados
 * 
 * 
 */
