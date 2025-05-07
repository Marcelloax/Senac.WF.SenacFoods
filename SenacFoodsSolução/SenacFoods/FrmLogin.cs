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
            bool loginValido = ValidateLogin(txtLogin.Text, txtSenha.Text);

            if(loginValido){
                this.Hide();
                //criar uma instancia de FrmPrincipal
                var frmPrincipal = new FrmPrincipal(txtLogin.Text, txtSenha.Text);
                //Exibe a tela principal
                frmPrincipal.Show();
            } }

        private bool ValidateLogin(string nome, string senha)
        {
           if (nome == "admin" && senha == "123")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos");
                return false;
            }
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

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
