using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.DAL;

namespace Sistema
{
    public partial class frmVenda : Form
    {

        
        public frmVenda()
        {
            InitializeComponent();
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            //this.Size = new Size(601, 103);
            this.pessoasBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;
            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Venda;
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produto;
            this.contasReceberBindingSource.DataSource = DataContextFactory.DataContext.ContasReceber;
            this.statusPagamentoBindingSource.DataSource = DataContextFactory.DataContext.StatusPagamento;

            this.vendaBindingSource.AddNew();
        }
        //vericação de conteúdo dentro da tabela venda e itensVenda
        public Venda VendaCorrente
        {
            get
            {
                return (Venda)this.vendaBindingSource.Current;
            }
        }

        public ItensVenda ItemCorrente
        {
            get
            {
                return (ItensVenda)this.itensVendaBindingSource.Current;
            }
        }

        public ContasReceber ContaCorrente
        {
            get
            {
                return (ContasReceber)this.contasReceberBindingSource.Current;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(601, 614);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            groupBox1.Visible = true;
            button1.Enabled = false;

            this.itensVendaBindingSource.DataSource = DataContextFactory.DataContext.ItensVenda.Where (x => x.CodigoProduto == VendaCorrente.CodigoVenda);
            NovoItem();
            cbCliente.Enabled = false;
        }

        private void NovoItem()
        {
            this.itensVendaBindingSource.AddNew();
            this.ItemCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ItemCorrente.Quantidade = 1;
            
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            this.itensVendaBindingSource.EndEdit();
            dgVendas.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostraSomaValores();
            NovoItem();

        }
        //ação para pegar a descrição do produto
        private void dgVendas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((Produto)e.Value).Descricao;
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbProduto.SelectedItem != null)
            {
                var pro = (Produto)cbProduto.SelectedItem;
                this.ItemCorrente.CodigoProduto = (int) pro.Codigo;
                this.ItemCorrente.Valor = (decimal) pro.Valor;
            }
        }

        private void MostraSomaValores()
        {
            decimal total = 0;
            foreach(DataGridViewRow dg in dgVendas.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                decimal subtotal = v1 * v2;
                dg.Cells[4].Value = subtotal;
                total = total + subtotal;
            }

            this.VendaCorrente.Valor = total;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar o pedido", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itensVendaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.VendaCorrente.Desconto = 0;
                btnNovoItem.Enabled = false;
                cbProduto.Enabled = false;
                txtQuantidade.Enabled = false;
                txtDesconto.ReadOnly = false;
                txtDesconto.Focus();
                btnFinalizar.Enabled = false;
                btnFinalizarVenda.Enabled = true;
                codigoVendaTextBox.Enabled = false;
            }
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            this.VendaCorrente.Desconto = Convert.ToDecimal(txtDesconto.Text);
            this.VendaCorrente.ValorPago = (decimal)(this.VendaCorrente.Valor - this.VendaCorrente.Desconto);
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            txtDesconto.Enabled = false;
            btnFinalizarVenda.Enabled = false;
            

            cbPgto.Enabled = true;
            this.contasReceberBindingSource.AddNew();
            this.ContaCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ContaCorrente.DataCompra = DateTime.Now;
            this.ContaCorrente.DataVencimento = DateTime.Now;
            
        }

        private void cbPgto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbPgto.SelectedItem != null)
            {
                var status = (StatusPagamento)cbPgto.SelectedItem;
                if (status.CodigoStatus == 1)
                {
                    this.ContaCorrente.CodigoStatus = (int)status.CodigoStatus;
                    this.ContaCorrente.DataPagamento = DateTime.Now;
                    btnFinalizarTudo.Enabled = true;
                    txtDataVencimento.Enabled = false;
                }
                else if (status.CodigoStatus == 2)
                {
                    this.ContaCorrente.CodigoStatus = (int)status.CodigoStatus;
                    this.ContaCorrente.DataVencimento = DateTime.Now;
                    txtDataVencimento.Enabled = true;
                    btnFinalizarTudo.Enabled = true;
                }
            }
        }

        private void btnFinalizarTudo_Click(object sender, EventArgs e)
        {
            this.contasReceberBindingSource.EndEdit();
            txtDataVencimento.Enabled = false;
            btnFinalizarTudo.Enabled = false;
            cbPgto.Enabled = false;
            btnImprimir.Enabled = true;
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Venda finalizada com sucesso");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = dgVendas.Height;
            dgVendas.Height = dgVendas.RowCount * dgVendas.RowTemplate.Height * 3;
            bmp = new Bitmap(dgVendas.Width, dgVendas.Height);
            dgVendas.DrawToBitmap(bmp, new Rectangle(0, 0, dgVendas.Width, dgVendas.Height));
            dgVendas.Height = height;

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;




            e.Graphics.DrawImage(bmp, 50, 120);
            e.Graphics.DrawString("venda", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(400, 50), stringFormat);
            e.Graphics.DrawString("Cliente: ", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(100, 840), stringFormat);
            e.Graphics.DrawString(cbCliente.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(220, 840), stringFormat);
            e.Graphics.DrawString("valor: ", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(100, 950), stringFormat);
            e.Graphics.DrawString(txtValor.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(220, 950), stringFormat);
            e.Graphics.DrawString("Desconto: ", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(350, 950), stringFormat);
            e.Graphics.DrawString(txtDesconto.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(460, 950), stringFormat);
            e.Graphics.DrawString("valor total: ", new Font("Arial", 25, FontStyle.Regular), Brushes.Black, new Point(550, 950), stringFormat);
            e.Graphics.DrawString(txtValorPago.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(670, 950), stringFormat);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_menu();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        
    }
}
