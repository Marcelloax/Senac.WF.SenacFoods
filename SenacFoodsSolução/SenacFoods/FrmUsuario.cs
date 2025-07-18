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
    public partial class FrmUsuario : Form

    {
        Usuario? userselect;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            BuscarUsuario();
        }
        private void BuscarUsuario()
        {
            //conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                //consultar a tabela usuario
                var usuarios = bd.Usuarios.AsQueryable();
                if (!string.IsNullOrEmpty(txtPesquisa.Text))
                {
                    //se o campo de pesquisa não estiver vazio, filtrar os resultados
                    usuarios = usuarios.Where(u => u.Nome.Contains(txtPesquisa.Text));
                }
                //popular o grid com a tabela consultada
                dataGridView1.DataSource = usuarios.ToList();
            }
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            new FrmUsuarioCad().ShowDialog();
            BuscarUsuario();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (userselect != null)
            {
                var usercad = new FrmUsuarioCad(userselect);
                usercad.Show();
                BuscarUsuario();
                userselect = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userselect != null)
            {
                using (var bd = new ComandaDBContext())
                {
                    bd.Usuarios.Remove(userselect);
                    bd.SaveChanges();
                }
                MessageBox.Show("Usuario excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarUsuario();
                userselect = null;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var bd = new ComandaDBContext())
            {
                //verifica se a linha clicada é válida
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    //pega o id do usuario selecionado
                    var id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    //busca o usuario no banco de dados
                    userselect = bd.Usuarios.Find(id);
                }
            }
        }
    }
}
