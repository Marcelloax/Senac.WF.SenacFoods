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
                chkAtivo.DataSource = item.ToList();
                chkAtivo.DisplayMember = "Titulo";
                chkAtivo.ValueMember = "Id";
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

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkAtivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
