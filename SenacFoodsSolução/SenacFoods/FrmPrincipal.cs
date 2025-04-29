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
    }
}
