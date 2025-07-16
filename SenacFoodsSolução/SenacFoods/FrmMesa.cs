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
        Mesa? mselect;
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
            var frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (mselect != null)
                {
                    using (var bd = new ComandaDBContext())
                    {
                        bd.Mesas.Remove(mselect);
                        bd.SaveChanges();
                    }
                    MessageBox.Show("Mesa excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BuscarMesa();
                    mselect = null;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                if (mselect != null)
                {
                    var MesaCad = new FrmMesaCad(mselect);
                    MesaCad.Show();
                    BuscarMesa();
                    mselect = null;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                mselect = dataGridView1.Rows[e.RowIndex].DataBoundItem as Mesa;
                button2.Enabled = true;
            }
        }
    }
}    
