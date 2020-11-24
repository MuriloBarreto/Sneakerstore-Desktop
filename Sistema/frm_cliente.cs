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
    public partial class frm_cliente : Form
    {
        public frm_cliente()
        {
            InitializeComponent();
            btnCancelar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pessoasBindingSource.AddNew();
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void frm_cliente_Load(object sender, EventArgs e)
        {
            this.pessoasBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (valida())
            {
                this.pessoasBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Cliente Inserida com sucesso!");
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

        private bool valida()
        {
            if (nomeTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo nome é obrigatório");
                nomeTextBox.Focus();
                return false;
            }else if(emailTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo Email é obrigatório");
                emailTextBox.Focus();
                return false;
            }else if (cPFMaskedTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo CPF é obrigatório");
                cPFMaskedTextBox.Focus();
                return false;
            }
            return true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                



                    this.pessoasBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Cliente Excluído com sucesso!");
                

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.pessoasBindingSource.CancelEdit();
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_menu();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_menu();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

