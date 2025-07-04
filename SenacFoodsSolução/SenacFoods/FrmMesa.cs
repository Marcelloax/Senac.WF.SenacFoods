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
    public partial class FrmMesa : Form
    {
        public FrmMesa()
        {
            InitializeComponent();
        }

        private void FrmMesa_Load(object sender, EventArgs e)
        {
            BuscarMesa();
        }
        private void BuscarMesa()
        {
            //conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                //consultar a tabela mesa
                var mesas = bd.Mesas.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    //se o campo de pesquisa não estiver vazio, filtrar os resultados
                    mesas = mesas.Where(m => m.NumeroMesa == int.Parse(txtPesquisa.Text));
                }
                //popular o grid com a tabela consultada
                dataGridView1.DataSource = mesas.ToList();
            }
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            new FrmMesaCad().ShowDialog();
            BuscarMesa();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}    
