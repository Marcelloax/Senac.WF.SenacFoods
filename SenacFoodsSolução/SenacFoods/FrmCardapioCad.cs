using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SenacFoods
{
    public partial class FrmCardapioCad : Form
    {
        private Cardapioitem _cardapioItem;
        public FrmCardapioCad()
        {
            InitializeComponent();
        }
        public FrmCardapioCad(Cardapioitem cardapioItem)
        {
            _cardapioItem = cardapioItem;
            InitializeComponent();
            CarregarDados();
        }
        private void CarregarDados()
        {
            if (_cardapioItem != null)
            {
                txtTitulo.Text = _cardapioItem.Titulo;
                txtDescricao.Text = _cardapioItem.Descricao;
                txtPreco.Text = _cardapioItem.Preco.ToString("F2");
                chkPossuiPreparo.Checked = _cardapioItem.PossuiPreparo;

            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_cardapioItem == null)
            {
                InserirCardapio();
            }
            else
            {
                AtualizarCardapio();
            }
        }
        private void InserirCardapio()
        {
            using (var banco = new ComandaDBContext())
            {
                string nome = txtTitulo.Text;
                string descricao = txtDescricao.Text;
                decimal.TryParse(txtPreco.Text, out var preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;
                var cardapio = new Cardapioitem()
                {
                    Descricao = descricao,
                    Titulo = nome,
                    Preco = preco,
                    PossuiPreparo = possuiPreparo
                };
                banco.CardapioItems.Add(cardapio);
                banco.SaveChanges();
            }
            MessageBox.Show("Cardapio salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void AtualizarCardapio()
        {
            using (var banco = new ComandaDBContext())
            {
                string Titulo = txtTitulo.Text;
                string Descricao = txtDescricao.Text;
                decimal.TryParse(txtPreco.Text, out var preco);
                bool possuiPreparo = chkPossuiPreparo.Checked;

                var cardapioItem = banco.CardapioItems.First(x => x.Id == _cardapioItem.Id);
                cardapioItem.Titulo = Titulo;
                cardapioItem.Descricao = Descricao;
                cardapioItem.Preco = preco;
                cardapioItem.PossuiPreparo = possuiPreparo;
                banco.CardapioItems.Update(cardapioItem);
                banco.SaveChanges();
            }
            MessageBox.Show("Cardapio salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
