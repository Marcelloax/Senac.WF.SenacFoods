using System;

namespace SenacFoods
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Hide();
            //criar uma instancia de FrmPrincipal
            var frmPrincipal = new FrmPrincipal();
            //Exibe a tela principal
            frmPrincipal.Show();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // Fechar a tela principal
            Close();
            Application.Exit();

        }


        private void btnM_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
    }
}
