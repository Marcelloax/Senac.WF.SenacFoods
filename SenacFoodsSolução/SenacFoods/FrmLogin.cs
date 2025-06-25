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
            // Verifica se o login e senha são válidos
            bool loginValido = ValidateLogin(txtLogin.Text, txtSenha.Text);

            if (loginValido)
            {
                this.Hide();
                //criar uma instancia de FrmPrincipal
                var frmPrincipal = new FrmPrincipal(txtLogin.Text, txtSenha.Text);
                //Exibe a tela principal
                frmPrincipal.Show();
            }
        }

        private bool ValidateLogin(string nome, string senha)
        {
            bool usuarioValido = false;
            using (var banco = new ComandaDBContext())
            {
                // Verifica se o usuário existe no banco de dados
                var usuario = banco
                    .Usuarios
                    .FirstOrDefault(u => u.Email.ToLower() == nome.ToLower() && u.Senha == senha);
                if (usuario is not null)
                {
                    usuarioValido = true;
                }
                if (usuarioValido)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Login ou senha inválidos");
                    return false;
                }
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
