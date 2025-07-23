namespace SenacFoods
{
    partial class FrmUsuario
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
            txtPesquisa = new TextBox();
            btnFechar = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnadicionar = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkViolet;
            panel1.Controls.Add(txtPesquisa);
            panel1.Controls.Add(btnFechar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(7, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1027, 91);
            panel1.TabIndex = 9;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(175, 29);
            txtPesquisa.Margin = new Padding(4);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(747, 31);
            txtPesquisa.TabIndex = 2;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = SystemColors.ActiveCaptionText;
            btnFechar.Location = new Point(982, 15);
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
            label1.Location = new Point(49, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 1;
            label1.Text = "Pesquisar:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnadicionar);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(13, 110);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1015, 518);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // btnadicionar
            // 
            btnadicionar.BackColor = Color.DarkOrchid;
            btnadicionar.Location = new Point(126, 9);
            btnadicionar.Margin = new Padding(4);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(146, 44);
            btnadicionar.TabIndex = 6;
            btnadicionar.Text = "New User";
            btnadicionar.UseVisualStyleBackColor = false;
            btnadicionar.Click += btnadicionar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGreen;
            button2.Location = new Point(770, 447);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(146, 44);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(593, 447);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(146, 44);
            button1.TabIndex = 1;
            button1.Text = "Excluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 61);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(934, 378);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 641);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtPesquisa;
        private Button btnFechar;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnadicionar;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}