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
    public partial class frm_rel_venda : Form
    {
        public frm_rel_venda()
        {
            InitializeComponent();
        }

        private void frm_rel_venda_Load(object sender, EventArgs e)
        {
            this.VendaBindingSource.DataSource = DataContextFactory.DataContext.Venda;
        }

        private void vendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vendaDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 5)
                e.Value = ((Pessoas)e.Value).Nome;
        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int height = vendaDataGridView.Height;
            vendaDataGridView.Height = vendaDataGridView.RowCount * vendaDataGridView.RowTemplate.Height * 3;
            bmp = new Bitmap(vendaDataGridView.Width, vendaDataGridView.Height);
            vendaDataGridView.DrawToBitmap(bmp, new Rectangle(0, 0, vendaDataGridView.Width, vendaDataGridView.Height));
            vendaDataGridView.Height = height;

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;




            e.Graphics.DrawImage(bmp, 50, 120);
            e.Graphics.DrawString("vendas", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(400, 50), stringFormat);

        }

        private void btnImprimir_Click(object sender, EventArgs e)
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
