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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //Fechar a tela principal
            Close();
            //Criar uma instanmcia da tela de login
            var frmLogin = new FrmLogin();
            //exibe a tela de login
            frmLogin.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criar uma instancia de FrmCardapio
            var frmcardapio = new FrmCardapio();
            //exibe a tela de cardapio em estilo modal()
            frmcardapio.ShowDialog();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //altera o estado da tela
            //para o estado minimizado
            WindowState = FormWindowState.Minimized;
        }

        private void btnComanda(object sender, EventArgs e)
        {
            //criar uma instancia de FrmCardapio
            var frmusuario = new FrmUsuario();
            //exibe a tela de cardapio em estilo modal()
            frmusuario.ShowDialog();
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            //criar uma instancia de FrmCardapio
            var frmpedidocozinha = new FrmPedidoCozinha();
            //exibe a tela de cardapio em estilo modal()
            frmpedidocozinha.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            //criar uma instancia de FrmCardapio
            var frmusuario = new FrmUsuario();
            //exibe a tela de cardapio em estilo modal()
            frmusuario.ShowDialog();
        }

        private void btnMiximizer_Click(object sender, EventArgs e)
        { 
                WindowState = FormWindowState.Minimized;
            }
        }
    }

