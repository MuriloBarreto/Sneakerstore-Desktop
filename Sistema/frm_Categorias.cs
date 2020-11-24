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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
            btnCancelar.Enabled = false;
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.AddNew();
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (this.valida()) 
            { 

                this.categoriaBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria Inserida com sucesso!");
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }
        private bool valida()
        {
            if (txtCategoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo de categoria é obrigatório");
                txtCategoria.Focus();
                return false;
            }
            return true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza","Confirmação",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //validação de exclusão
                if (this.CategoriaPossuiProduto(this.categoriaAtual))
                    MessageBox.Show("Você não pode excluir essa categoria, porque existem produtos nela");
                else
                {

                

                    this.categoriaBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria Excluída com sucesso!");
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
        }
        //verificando se categoria tem item
        public Categoria categoriaAtual
        {
            get
            {
                return (Categoria)this.categoriaBindingSource.Current;
            }
        }

        private bool CategoriaPossuiProduto(Categoria categoria)
        {
            var produtos = DataContextFactory.DataContext.Produto.Where(x => x.CodigoCategoria == categoria.Codigo);
            if (produtos.Count() > 0)
                return true;
            else
                return false;
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
