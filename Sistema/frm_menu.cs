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
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void produtosCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmConsultaProdutos();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmVenda();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_login();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_cliente();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_pedidos();
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
            Form f = new frm_cliente();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmConsultaProdutos();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmVenda();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Form f = new frm_pedidos();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lHora.Text = DateTime.Now.ToShortTimeString();
            ldata.Text = DateTime.Now.ToShortDateString();
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
