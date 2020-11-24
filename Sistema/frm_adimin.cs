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
    public partial class frm_adimin : Form
    {
        public frm_adimin()
        {
            InitializeComponent();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmProdutos();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmCategorias();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_rel_produtos frm = new frm_rel_produtos();
            frm.Show();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_usuario();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_rel_venda();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frm_pedidos();
            f.Show();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_prod();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmCategorias();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_login();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmProdutos();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_usuario();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_rel_venda();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_prod();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f = new frm_pedidos();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lHora.Text = DateTime.Now.ToShortTimeString();
            ldata.Text = DateTime.Now.ToShortDateString();
        }

        private void frm_adimin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
