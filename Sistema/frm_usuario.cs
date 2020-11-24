using Sistema.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frm_usuario : Form
    {
        public frm_usuario()
        {
            InitializeComponent();
            btnCancelar.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.tb_usuarioBindingSource.AddNew();
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            this.tb_usuarioBindingSource.DataSource = DataContextFactory.DataContext.tb_usuario;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (valida())
            {
                this.tb_usuarioBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Cliente Inserida com sucesso!");
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }
        private bool valida()
        {
            if (senhaTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo senha é obrigatório");
                senhaTextBox.Focus();
                return false;
            }
            else if (usuarioTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo usuário é obrigatório");
                usuarioTextBox.Focus();
                return false;
            }
            return true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {




                this.tb_usuarioBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Usuário Excluído com sucesso!");


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.tb_usuarioBindingSource.CancelEdit();
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_adimin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_adimin();
            f.Closed += (s, args) => this.Close();
            f.Show();
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
