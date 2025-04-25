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
            txtSenha = new Panel();
            txtLogin = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEnter = new Button();
            txtSenha.SuspendLayout();
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
            // txtSenha
            // 
            txtSenha.Controls.Add(btnEnter);
            txtSenha.Controls.Add(textBox1);
            txtSenha.Controls.Add(txtLogin);
            txtSenha.Controls.Add(label2);
            txtSenha.Controls.Add(label1);
            txtSenha.Dock = DockStyle.Right;
            txtSenha.Location = new Point(263, 0);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(537, 450);
            txtSenha.TabIndex = 1;
           
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
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaptionText;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.SizeAll;
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.ForeColor = SystemColors.InactiveBorder;
            textBox1.Location = new Point(94, 184);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 43);
            textBox1.TabIndex = 0;
            textBox1.Text = "Senha";
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
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSenha);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            txtSenha.ResumeLayout(false);
            txtSenha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel txtSenha;
        private TextBox txtLogin;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button btnEnter;
    }
}
