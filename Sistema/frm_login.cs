using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.DAL;

namespace Sistema
{
    public partial class frm_login : Form
    {
        public bool logado = false;
        public bool logado2 = false;
        public frm_login()
        {
            InitializeComponent();
        }

        private void EfetuarLogin()
        {
            var user = DataContextFactory.DataContext.tb_usuario.Count(x => x.usuario == usuarioTextBox.Text && x.senha == senhaTextBox.Text);
            var adm = DataContextFactory.DataContext.tb_adm.Count(x => x.usuario == usuarioTextBox.Text && x.senha == senhaTextBox.Text);

            if(user > 0 && func.Checked)
            {
                this.Hide();
                Form f = new frm_menu();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
            else if(adm > 0 && adminis.Checked)
            {
                this.Hide();
                Form f = new frm_adimin();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EfetuarLogin();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Administrador_Click(object sender, EventArgs e)
        {
            
            
        }

        private void usuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void versenha_Click(object sender, EventArgs e)
        {
            senhaTextBox.PasswordChar = '\u0000';
            naoversenha.Visible = true;
            naoversenha.Enabled = true;

            versenha.Visible = false;
            versenha.Enabled = false;
        }

        private void naoversenha_Click(object sender, EventArgs e)
        {
            senhaTextBox.PasswordChar = '*';
            versenha.Visible = true;
            versenha.Enabled = true;

            naoversenha.Enabled = false;
            naoversenha.Visible = false;
        }
    }
}
