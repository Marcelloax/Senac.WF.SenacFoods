namespace SenacFoods
{
    partial class FrmComandaCad
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
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            chkAtivo = new ComboBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label4 = new Label();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            btnSalvar = new Button();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(76, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 183);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 31);
            textBox1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 110);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 23;
            label2.Text = "Mesa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 33);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 22;
            label1.Text = "Nome do Cliente:";
            // 
            // chkAtivo
            // 
            chkAtivo.FormattingEnabled = true;
            chkAtivo.Items.AddRange(new object[] { "1", "2", "3" });
            chkAtivo.Location = new Point(98, 30);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(261, 33);
            chkAtivo.TabIndex = 20;
            chkAtivo.SelectedIndexChanged += chkAtivo_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(chkAtivo);
            groupBox2.Location = new Point(76, 237);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(480, 82);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Item";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(408, 17);
            button1.Name = "button1";
            button1.Size = new Size(54, 53);
            button1.TabIndex = 23;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 33);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 22;
            label4.Text = "Item:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "admin", "operador" });
            comboBox2.Location = new Point(185, 110);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(261, 33);
            comboBox2.TabIndex = 21;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(76, 346);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(480, 228);
            dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Location = new Point(641, 510);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(161, 49);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.PaleGreen;
            btnSalvar.Location = new Point(854, 510);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(161, 49);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Confirmar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = SystemColors.ActiveCaptionText;
            btnFechar.Location = new Point(1006, 22);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(30, 48);
            btnFechar.TabIndex = 9;
            btnFechar.Text = "x";
            btnFechar.TextAlign = ContentAlignment.TopCenter;
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // FrmComandaCad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 594);
            Controls.Add(btnFechar);
            Controls.Add(button2);
            Controls.Add(btnSalvar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComandaCad";
            Text = "FrmComandaCad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox chkAtivo;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button button1;
        private Label label4;
        private ComboBox comboBox2;
        private DataGridView dataGridView1;
        private Button button2;
        private Button btnSalvar;
        private Button btnFechar;
        private TextBox textBox1;
    }
}