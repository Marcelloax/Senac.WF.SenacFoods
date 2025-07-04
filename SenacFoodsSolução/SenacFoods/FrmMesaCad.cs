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
        public FrmMesaCad()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarMesa();
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
    }
}
