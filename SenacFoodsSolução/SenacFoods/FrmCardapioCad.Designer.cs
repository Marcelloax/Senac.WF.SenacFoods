namespace SenacFoods
{
    partial class FrmCardapioCad
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
            btnSalvar = new Button();
            button1 = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            chkPossuiPreparo = new CheckBox();
            txtPreco = new TextBox();
            txtTitulo = new TextBox();
            txtDescricao = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 2);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 99);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = SystemColors.ActiveCaptionText;
            btnFechar.Location = new Point(818, 10);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(46, 55);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "x";
            btnFechar.TextAlign = ContentAlignment.TopCenter;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 28);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de Cardapio";
            label1.Click += label1_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.PaleGreen;
            btnSalvar.Location = new Point(663, 310);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(161, 49);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(494, 310);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(161, 49);
            button1.TabIndex = 1;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 43);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 8;
            label2.Text = "Titulo:";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkPossuiPreparo);
            groupBox1.Controls.Add(txtPreco);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Location = new Point(13, 122);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(852, 385);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cardapio";
            // 
            // chkPossuiPreparo
            // 
            chkPossuiPreparo.AutoSize = true;
            chkPossuiPreparo.Location = new Point(64, 332);
            chkPossuiPreparo.Name = "chkPossuiPreparo";
            chkPossuiPreparo.Size = new Size(176, 32);
            chkPossuiPreparo.TabIndex = 14;
            chkPossuiPreparo.Text = "Possui preparo?";
            chkPossuiPreparo.UseVisualStyleBackColor = true;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(82, 292);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(336, 34);
            txtPreco.TabIndex = 13;
            txtPreco.TextChanged += txtPreco_TextChanged;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(82, 85);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(336, 34);
            txtTitulo.TabIndex = 12;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(77, 174);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(341, 64);
            txtDescricao.TabIndex = 11;
            txtDescricao.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 253);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 10;
            label4.Text = "Preço:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 142);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 9;
            label3.Text = "Descrição:";
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 520);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCardapioCad";
            Text = "FrmCardapioCad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnSalvar;
        private Button button1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private TextBox txtPreco;
        private TextBox txtTitulo;
        private RichTextBox txtDescricao;
        private Button btnFechar;
        private CheckBox chkPossuiPreparo;
    }
}