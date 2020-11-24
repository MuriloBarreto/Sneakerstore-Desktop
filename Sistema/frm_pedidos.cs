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
    public partial class frm_pedidos : Form
    {
        private MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        
        String strSQL;
        
        public frm_pedidos()
        {
            InitializeComponent();

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=lojavirtual;Uid=root;Pwd=;");

                strSQL = "select venda.id_venda as codigo, produto.produto, itens.valor_item as Valor,itens.qtde_item as Quantidade,itens.subtotal,venda.data_venda as Data_da_Venda,venda.pago,cliente.cliente,cliente.endereco as Endereço,cliente.bairro as Bairro,cliente.cidade,cliente.fone as Telefone from itens inner join produto on itens.id_produto = produto.id_produto inner join venda on itens.id_venda = venda.id_venda inner join cliente on venda.id_cliente = cliente.id_cliente; ";

                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPedido.DataSource = dt;
                
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



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
