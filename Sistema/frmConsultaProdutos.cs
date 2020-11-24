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
    public partial class frmConsultaProdutos : Form
    {
        public frmConsultaProdutos()
        {
            InitializeComponent();
        }

        private void frmConsultaProdutos_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categoria;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Pesquisar((int)cbCategoria.SelectedValue);
        }
        //verificar se tem informação para trazer na consulta 
        public void Pesquisar (int codigoCategoria)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto.Where(x => x.CodigoCategoria == codigoCategoria);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_menu();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_menu();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
