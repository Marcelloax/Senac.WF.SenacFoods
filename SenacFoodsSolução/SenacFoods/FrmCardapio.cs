using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmCardapio : Form
    {
        Cardapioitem? cdpselec;
        public FrmCardapio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cdpselec != null)
            {
                using (var bd = new ComandaDBContext())
                {
                    bd.CardapioItems.Remove(cdpselec);
                    bd.SaveChanges();
                }
                MessageBox.Show("Cardápio excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarCardapio();
                cdpselec = null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmCardapio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            //conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                //consultar a tabela cardapio item
                var cardapios = bd.CardapioItems.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    //se o campo de pesquisa não estiver vazio, filtrar os resultados
                    cardapios = cardapios.Where(c => c.Titulo.Contains(txtPesquisa.Text) || c.Descricao.Contains(txtPesquisa.Text));
                }
                //popular o grid com a tabela consultada
                dataGridView1.DataSource = cardapios.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cdpselec != null)
            {
                var cdpcad = new FrmCardapioCad(cdpselec);
                cdpcad.Show();
                BuscarCardapio();
                cdpselec = null;
            }
        }

        private void btnadicionar_Click_1(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
            BuscarCardapio();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            // chamar metodo buscar cardapio
            BuscarCardapio();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cdpselec = dataGridView1.Rows[e.RowIndex].DataBoundItem as Cardapioitem;
                button2.Enabled = true;
            }


        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (cdpselec != null)
            {
                using (var bd = new ComandaDBContext())
                {
                    bd.CardapioItems.Remove(cdpselec);
                    bd.SaveChanges();
                }
                MessageBox.Show("Cardápio excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarCardapio();
                cdpselec = null;
            }
        }
    }
}