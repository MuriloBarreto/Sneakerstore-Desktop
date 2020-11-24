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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
            btnCancelar.Enabled = false;
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {

                this.produtoBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Produto Inserido com sucesso!");
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

        private bool valida()
        {
            if (txtDescricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo de Descrição é obrigatório");
                txtDescricao.Focus();
                return false;
            }
            return true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                



                    this.produtoBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Produto Excluído com sucesso!");
                

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.CancelEdit();
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((Categoria)e.Value).Descricao;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_adimin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_adimin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
