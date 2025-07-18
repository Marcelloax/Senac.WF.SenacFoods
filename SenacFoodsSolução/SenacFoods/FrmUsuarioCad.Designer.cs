namespace SenacFoods
{
    partial class FrmUsuarioCad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnFechar = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            chkAtivo = new ComboBox();
            label6 = new Label();
            txtConfirmarSenha = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            btnSalvar = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumOrchid;
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 99);
            panel1.TabIndex = 10;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = SystemColors.ActiveCaptionText;
            btnFechar.Location = new Point(946, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(46, 55);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "x";
            btnFechar.TextAlign = ContentAlignment.TopCenter;
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(27, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(266, 38);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Usuario";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkAtivo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtConfirmarSenha);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Location = new Point(12, 107);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(989, 475);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // chkAtivo
            // 
            chkAtivo.FormattingEnabled = true;
            chkAtivo.Items.AddRange(new object[] { "admin" });
            chkAtivo.Location = new Point(35, 415);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(248, 33);
            chkAtivo.TabIndex = 19;
            chkAtivo.SelectedIndexChanged += chkAtivo_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 387);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 18;
            label6.Text = "Perfil:";
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(35, 343);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(248, 31);
            txtConfirmarSenha.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 306);
            label5.Name = "label5";
            label5.Size = new Size(148, 25);
            label5.TabIndex = 16;
            label5.Text = "Confirmar Senha:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 31);
            txtEmail.TabIndex = 15;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(35, 249);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(248, 31);
            txtSenha.TabIndex = 13;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(35, 70);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(248, 31);
            txtNome.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 42);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 8;
            label2.Text = " Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 212);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 10;
            label4.Text = "Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 119);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 9;
            label3.Text = "Email:";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(474, 406);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(161, 49);
            button1.TabIndex = 1;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.PaleGreen;
            btnSalvar.Location = new Point(669, 406);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(161, 49);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmUsuarioCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 595);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarioCad";
            Text = "FrmUsuarioCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnFechar;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtSenha;
        private TextBox txtNome;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button button1;
        private Button btnSalvar;
        private TextBox txtEmail;
        private ComboBox chkAtivo;
        private Label label6;
        private TextBox txtConfirmarSenha;
        private Label label5;
    }
}