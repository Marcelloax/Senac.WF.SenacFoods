namespace SenacFoods
{
    partial class FrmPrincipal
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
            groupBox1 = new GroupBox();
            button3 = new Button();
            btnUsuario = new Button();
            btnPedidoCozinha = new Button();
            btnCardapio = new Button();
            btnFechar = new Button();
            btnMinimizar = new Button();
            button1 = new Button();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(btnUsuario);
            groupBox1.Controls.Add(btnPedidoCozinha);
            groupBox1.Controls.Add(btnCardapio);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(21, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(757, 273);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "SenacFoods";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 15F);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(198, 73);
            button3.Name = "button3";
            button3.Size = new Size(162, 155);
            button3.TabIndex = 0;
            button3.Text = "Comanda";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnComanda;
            // 
            // btnUsuario
            // 
            btnUsuario.BackColor = Color.Salmon;
            btnUsuario.FlatStyle = FlatStyle.Flat;
            btnUsuario.Font = new Font("Segoe UI", 16F);
            btnUsuario.ForeColor = SystemColors.ActiveCaptionText;
            btnUsuario.Location = new Point(534, 73);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(162, 155);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "Usuários";
            btnUsuario.UseVisualStyleBackColor = false;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnPedidoCozinha
            // 
            btnPedidoCozinha.BackColor = Color.LightSeaGreen;
            btnPedidoCozinha.FlatStyle = FlatStyle.Flat;
            btnPedidoCozinha.Font = new Font("Segoe UI", 16F);
            btnPedidoCozinha.ForeColor = SystemColors.ActiveCaptionText;
            btnPedidoCozinha.Location = new Point(366, 73);
            btnPedidoCozinha.Name = "btnPedidoCozinha";
            btnPedidoCozinha.Size = new Size(162, 155);
            btnPedidoCozinha.TabIndex = 0;
            btnPedidoCozinha.Text = "Pedido Cozinha";
            btnPedidoCozinha.UseVisualStyleBackColor = false;
            btnPedidoCozinha.Click += btnPedidoCozinha_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.BackColor = Color.Gold;
            btnCardapio.FlatStyle = FlatStyle.Flat;
            btnCardapio.Font = new Font("Segoe UI", 16F);
            btnCardapio.ForeColor = SystemColors.ActiveCaptionText;
            btnCardapio.Location = new Point(30, 73);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.Size = new Size(162, 155);
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.UseVisualStyleBackColor = false;
            btnCardapio.Click += button1_Click;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(742, 1);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(46, 55);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "x";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimizar.Location = new Point(633, 1);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(46, 55);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(686, 1);
            button1.Name = "button1";
            button1.Size = new Size(46, 55);
            button1.TabIndex = 3;
            button1.Text = "[]";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnMiximizer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(100, 21);
            label1.Name = "label1";
            label1.Size = new Size(213, 45);
            label1.TabIndex = 4;
            label1.Text = "lblMensagem";
            label1.Click += label1_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnMinimizar);
            Controls.Add(button1);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnCardapio;
        private Button button3;
        private Button btnUsuario;
        private Button btnPedidoCozinha;
        private Button btnFechar;
        private Button btnMinimizar;
        private Button button1;
        private Label label1;
    }
}