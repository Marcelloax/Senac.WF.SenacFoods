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
    public partial class FrmCardapioCad : Form
    {
        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalvarCardapio();
        }
        private void SalvarCardapio()
        {
            // Conectar
            using (var banco = new ComandaDBContext())
            {


                // Captar os dados da tela
                string Titulo = txtTitulo.Text;
                string Descricao = txtDescricao.Text;
                decimal.TryParse(txtPreco.Text, out var preco);
                bool PossuiPreparo = chkPossuiPreparo.Checked;
                // Criar novo cardápio
                var cardapio = new Cardapioitem()
                {
                    Titulo = Titulo,
                    Descricao = Descricao,
                    Preco = preco,
                    PossuiPreparo = PossuiPreparo
                };
                // Adicionar o cardápio 

                // Salvar as alterações no banco de dados
                banco.CardapioItems.Add(cardapio);
                banco.SaveChanges();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
