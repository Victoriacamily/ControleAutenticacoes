using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAutenticacoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string login;
            string senha;

            login = txtlogin.Text;
            try
            {
                MailAddress loginValid = new MailAddress(login);
            }
            catch
            {
                MessageBox.Show("Emsil válido");
            }
            senha = txtsenha.Text;
            if (senha.Length >= 8)
            {
                MessageBox.Show("Senha Válida");
            }
            else
            {
                MessageBox.Show("Senha Invalida");
            }
            //console.writeline(login);

        }
    }
}
