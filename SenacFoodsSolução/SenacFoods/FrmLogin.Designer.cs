namespace SenacFoods
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            painel1 = new Panel();
            btnMiximizer = new Button();
            btnFechar = new Button();
            btnEnter = new Button();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            painel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 450);
            panel1.TabIndex = 0;
            // 
            // painel1
            // 
            painel1.Controls.Add(btnMiximizer);
            painel1.Controls.Add(btnFechar);
            painel1.Controls.Add(btnEnter);
            painel1.Controls.Add(txtSenha);
            painel1.Controls.Add(txtLogin);
            painel1.Controls.Add(label2);
            painel1.Controls.Add(label1);
            painel1.Dock = DockStyle.Right;
            painel1.Location = new Point(263, 0);
            painel1.Name = "painel1";
            painel1.Size = new Size(537, 450);
            painel1.TabIndex = 1;
            // 
            // btnMiximizer
            // 
            btnMiximizer.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMiximizer.ForeColor = SystemColors.ActiveCaptionText;
            btnMiximizer.Location = new Point(427, 12);
            btnMiximizer.Name = "btnMiximizer";
            btnMiximizer.Size = new Size(46, 55);
            btnMiximizer.TabIndex = 4;
            btnMiximizer.Text = "-";
            btnMiximizer.TextAlign = ContentAlignment.TopCenter;
            btnMiximizer.UseVisualStyleBackColor = true;
            btnMiximizer.Click += btnM_Click;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = SystemColors.ActiveCaptionText;
            btnFechar.Location = new Point(479, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(46, 55);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "x";
            btnFechar.TextAlign = ContentAlignment.TopCenter;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnEnter
            // 
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Microsoft Sans Serif", 16F);
            btnEnter.ForeColor = SystemColors.ButtonHighlight;
            btnEnter.Location = new Point(157, 285);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(191, 54);
            btnEnter.TabIndex = 2;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.InactiveCaptionText;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Cursor = Cursors.SizeAll;
            txtSenha.Font = new Font("Segoe UI", 16F);
            txtSenha.ForeColor = SystemColors.InactiveBorder;
            txtSenha.Location = new Point(94, 184);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(341, 43);
            txtSenha.TabIndex = 0;
            txtSenha.Text = "Senha";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = SystemColors.InactiveCaptionText;
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Cursor = Cursors.SizeAll;
            txtLogin.Font = new Font("Microsoft Sans Serif", 16F);
            txtLogin.ForeColor = SystemColors.InactiveBorder;
            txtLogin.Location = new Point(94, 104);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(341, 37);
            txtLogin.TabIndex = 0;
            txtLogin.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 16F);
            label2.Location = new Point(94, 196);
            label2.Name = "label2";
            label2.Size = new Size(323, 37);
            label2.TabIndex = 1;
            label2.Text = "_________________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F);
            label1.Location = new Point(94, 119);
            label1.Name = "label1";
            label1.Size = new Size(323, 37);
            label1.TabIndex = 1;
            label1.Text = "_________________";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(painel1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            painel1.ResumeLayout(false);
            painel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel painel1;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private Button btnEnter;
        private Button btnFechar;
        private Button btnMiximizer;
    }
}
