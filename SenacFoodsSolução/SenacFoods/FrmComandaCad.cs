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
    public partial class FrmComandaCad : Form
    {
        List<Cardapioitem> itens = new List<Cardapioitem>();
        public FrmComandaCad()
        {
            InitializeComponent();
            BuscarMesa();
            BuscarItem();
        }
        private void BuscarItem()
        {
            using (var BancoDados = new ComandaDBContext())
            {
                var item = BancoDados.CardapioItems.AsQueryable();
                cbxCardapio.DataSource = item.ToList();
                cbxCardapio.DisplayMember = "Titulo";
                cbxCardapio.ValueMember = "Id";
            }

        }

        private void BuscarMesa()
        {
            //conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                //consultar a tabela mesa
                var mesas = bd.Mesas.AsQueryable();

                //popular o grid com a tabela consultada
                comboBox2.DataSource = mesas.ToList();
                comboBox2.DisplayMember = "NumeroMesa";
                // Exibir o número da mesa
                comboBox2.SelectedIndex = -1;
                comboBox2.ValueMember = "NumeroMesa";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            
            var cardapio = cbxCardapio.SelectedItem as Cardapioitem;
            if (cardapio == null)
            {
                MessageBox.Show("Selecione um item do cardápio.");
                return;
            }

            itens.Add(cardapio);

            dataGridView1.DataSource = itens;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkAtivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
