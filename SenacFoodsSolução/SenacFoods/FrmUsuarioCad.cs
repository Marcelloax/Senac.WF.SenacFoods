using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SenacFoods
{
    public partial class FrmUsuarioCad : Form
    {
        private Usuario? _Usuario;
        public FrmUsuarioCad()
        {
            InitializeComponent();
        }
        public FrmUsuarioCad(Usuario usuario)
        {
            InitializeComponent();
            _Usuario = usuario;
            CarregarDados();
        }
        private void CarregarDados()
        {
            if (_Usuario != null)
            {
                txtNome.Text = _Usuario.Nome;
                txtEmail.Text = _Usuario.Email;
                txtSenha.Text = _Usuario.Senha;
                txtConfirmarSenha.Text = _Usuario.Senha;
                chkAtivo.Items.Add("Administrador");
                chkAtivo.Items.Add("Operador");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void InserirUsuario()
        {
            using (var bd = new ComandaDBContext())
            {
                var usuario = new Usuario
                {
                    Nome = txtNome.Text,
                    Email = txtEmail.Text,
                    Senha = txtSenha.Text,
                    Ativo = chkAtivo.Text == "Administrador" ? true : false

                };
                bd.Usuarios.Add(usuario);
                bd.SaveChanges();
            }
            MessageBox.Show("Usuário inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        private void AtualizarUsuario()
        {
            using (var bd = new ComandaDBContext())
            {
                _Usuario.Nome = txtNome.Text;
                _Usuario.Email = txtEmail.Text;
                _Usuario.Senha = txtSenha.Text;
                _Usuario.Ativo = chkAtivo.Text == "Administrador" ? true : false;
                bd.Usuarios.Update(_Usuario);
                bd.SaveChanges();
            }
            MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_Usuario == null)
            {
                InserirUsuario();
            }
            else
            {
                AtualizarUsuario();
            }
        }

        private void chkAtivo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
