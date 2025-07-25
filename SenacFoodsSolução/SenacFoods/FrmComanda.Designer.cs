namespace SenacFoods
{
    partial class FrmComanda
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtPesquisa = new TextBox();
            btnFechar = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            btnadicionar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(243, 68);
            txtPesquisa.Margin = new Padding(4);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(747, 31);
            txtPesquisa.TabIndex = 2;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = SystemColors.ActiveCaptionText;
            btnFechar.Location = new Point(1117, 48);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(30, 48);
            btnFechar.TabIndex = 8;
            btnFechar.Text = "x";
            btnFechar.TextAlign = ContentAlignment.TopCenter;
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 71);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(16, 123);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1150, 475);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Comanda";
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.Location = new Point(591, 423);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(146, 44);
            button3.TabIndex = 3;
            button3.Text = "Encerrar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.Location = new Point(413, 423);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(146, 44);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(775, 423);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(146, 44);
            button1.TabIndex = 1;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 32);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1108, 374);
            dataGridView1.TabIndex = 0;
            // 
            // btnadicionar
            // 
            btnadicionar.BackColor = Color.DodgerBlue;
            btnadicionar.Font = new Font("Segoe UI", 12F);
            btnadicionar.Location = new Point(47, 4);
            btnadicionar.Margin = new Padding(4);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(294, 48);
            btnadicionar.TabIndex = 6;
            btnadicionar.Text = "Nova Comanda";
            btnadicionar.UseVisualStyleBackColor = false;
            btnadicionar.Click += btnadicionar_Click;
            // 
            // FrmComanda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 611);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Controls.Add(btnadicionar);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComanda";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPesquisa;
        private Button btnFechar;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnadicionar;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button3;
    }
}
