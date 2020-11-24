using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema
{
    public partial class frm_prod : Form
    {
        private MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        
        String strSQL;
      
        public frm_prod()
        {
            InitializeComponent();

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=lojavirtual;Uid=root;Pwd=;");

                strSQL = " select produto.id_produto as codigo,produto.produto, fabricante.fabricante, produto.preco, produto.ativo_produto, categoria.categoria from produto inner join fabricante on produto.id_fabricante = fabricante.id_fabricante inner join categoria on produto.id_categoria = categoria.id_categoria; ";

                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvProduto.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgvProduto.Height;
            dgvProduto.Height = dgvProduto.RowCount * dgvProduto.RowTemplate.Height * 3;
            bmp = new Bitmap(dgvProduto.Width, dgvProduto.Height);
            dgvProduto.DrawToBitmap(bmp, new Rectangle(0, 0, dgvProduto.Width, dgvProduto.Height));
            dgvProduto.Height = height;

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;




            e.Graphics.DrawImage(bmp, 50, 120);
            e.Graphics.DrawString("Produtos", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(400, 50), stringFormat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_adimin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
