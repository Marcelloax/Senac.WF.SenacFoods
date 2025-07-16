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
    public partial class FrmMesaCad : Form
    {
        private Mesa _mesa;
        public FrmMesaCad()
        {
            InitializeComponent();
        }
        public FrmMesaCad(Mesa mesa)
        {
            _mesa = mesa;
            InitializeComponent();
            CarregarDados();
        }
        private void CarregarDados()
        {
            if (_mesa != null)
            {
                txtNumeroMesa.Text = _mesa.NumeroMesa.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            {
                if (_mesa == null)
                {
                    SalvarMesa();
                }
                else
                {
                    AtualizarMesa();
                }
            }
        }
        private void SalvarMesa()
        {
            // Conectar
            using (var banco = new ComandaDBContext())
            {
                // Captar os dados da tela
                int numeroMesa;
                int.TryParse(txtNumeroMesa.Text, out numeroMesa);

                // Criar nova mesa
                var mesa = new Mesa()
                {
                    NumeroMesa = numeroMesa

                };
                // Adicionar a mesa 
                banco.Mesas.Add(mesa);

                // Salvar as alterações no banco de dados
                banco.SaveChanges();
            }
            MessageBox.Show("Mesa salva com sucesso!");
            this.Close();
        }
        private void AtualizarMesa()
        {
            using (var banco = new ComandaDBContext())
            {
                // Captar os dados da tela
                int numeroMesa;
                int.TryParse(txtNumeroMesa.Text, out numeroMesa);
                // Atualizar a mesa
                _mesa.NumeroMesa = numeroMesa;
                // Salvar as alterações no banco de dados
                banco.Mesas.Update(_mesa);
                banco.SaveChanges();
            }
            MessageBox.Show("Mesa atualizada com sucesso!");
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
