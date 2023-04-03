namespace Calculadora_IMC
{
    partial class calcIMC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_nome = new System.Windows.Forms.TextBox();
            this.TXT_altura = new System.Windows.Forms.TextBox();
            this.TXT_peso = new System.Windows.Forms.TextBox();
            this.LBL_Situação = new System.Windows.Forms.Label();
            this.BTN_calcule = new System.Windows.Forms.Button();
            this.BTN_limpar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBL_dateTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXT_data = new System.Windows.Forms.TextBox();
            this.BTN_Inserir = new System.Windows.Forms.Button();
            this.BTN_Pesquisar = new System.Windows.Forms.Button();
            this.BTN_Atualizar = new System.Windows.Forms.Button();
            this.BTN_Excluir = new System.Windows.Forms.Button();
            this.DGV_dados = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBL_IMC = new System.Windows.Forms.Label();
            this.LBL_idx = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(237)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(549, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora IMC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(37, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(38, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Altura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(384, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(350, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Situação:";
            // 
            // TXT_nome
            // 
            this.TXT_nome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_nome.Location = new System.Drawing.Point(113, 151);
            this.TXT_nome.Name = "TXT_nome";
            this.TXT_nome.Size = new System.Drawing.Size(251, 32);
            this.TXT_nome.TabIndex = 1;
            // 
            // TXT_altura
            // 
            this.TXT_altura.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_altura.Location = new System.Drawing.Point(113, 208);
            this.TXT_altura.Name = "TXT_altura";
            this.TXT_altura.Size = new System.Drawing.Size(245, 32);
            this.TXT_altura.TabIndex = 3;
            // 
            // TXT_peso
            // 
            this.TXT_peso.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_peso.Location = new System.Drawing.Point(455, 208);
            this.TXT_peso.Name = "TXT_peso";
            this.TXT_peso.Size = new System.Drawing.Size(251, 32);
            this.TXT_peso.TabIndex = 4;
            // 
            // LBL_Situação
            // 
            this.LBL_Situação.AutoSize = true;
            this.LBL_Situação.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LBL_Situação.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_Situação.ForeColor = System.Drawing.Color.White;
            this.LBL_Situação.Location = new System.Drawing.Point(455, 348);
            this.LBL_Situação.Name = "LBL_Situação";
            this.LBL_Situação.Size = new System.Drawing.Size(137, 24);
            this.LBL_Situação.TabIndex = 9;
            this.LBL_Situação.Text = "resposta aqui";
            this.LBL_Situação.Visible = false;
            // 
            // BTN_calcule
            // 
            this.BTN_calcule.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_calcule.Location = new System.Drawing.Point(242, 279);
            this.BTN_calcule.Name = "BTN_calcule";
            this.BTN_calcule.Size = new System.Drawing.Size(116, 30);
            this.BTN_calcule.TabIndex = 5;
            this.BTN_calcule.Text = "Calcular";
            this.BTN_calcule.UseVisualStyleBackColor = true;
            this.BTN_calcule.Click += new System.EventHandler(this.BTN_calcule_Click);
            // 
            // BTN_limpar
            // 
            this.BTN_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_limpar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_limpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTN_limpar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_limpar.Location = new System.Drawing.Point(385, 279);
            this.BTN_limpar.Name = "BTN_limpar";
            this.BTN_limpar.Size = new System.Drawing.Size(116, 30);
            this.BTN_limpar.TabIndex = 6;
            this.BTN_limpar.Text = "Limpar";
            this.BTN_limpar.UseVisualStyleBackColor = true;
            this.BTN_limpar.Click += new System.EventHandler(this.BTN_limpar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LBL_dateTime
            // 
            this.LBL_dateTime.AutoSize = true;
            this.LBL_dateTime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_dateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_dateTime.Location = new System.Drawing.Point(211, 82);
            this.LBL_dateTime.Name = "LBL_dateTime";
            this.LBL_dateTime.Size = new System.Drawing.Size(162, 24);
            this.LBL_dateTime.TabIndex = 12;
            this.LBL_dateTime.Text = "data e hora aqui";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(388, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Data:";
            // 
            // TXT_data
            // 
            this.TXT_data.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_data.Location = new System.Drawing.Point(455, 151);
            this.TXT_data.Name = "TXT_data";
            this.TXT_data.Size = new System.Drawing.Size(251, 32);
            this.TXT_data.TabIndex = 2;
            // 
            // BTN_Inserir
            // 
            this.BTN_Inserir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Inserir.Location = new System.Drawing.Point(834, 151);
            this.BTN_Inserir.Name = "BTN_Inserir";
            this.BTN_Inserir.Size = new System.Drawing.Size(116, 30);
            this.BTN_Inserir.TabIndex = 7;
            this.BTN_Inserir.Text = "Inserir";
            this.BTN_Inserir.UseVisualStyleBackColor = true;
            this.BTN_Inserir.Click += new System.EventHandler(this.BTN_Inserir_Click);
            // 
            // BTN_Pesquisar
            // 
            this.BTN_Pesquisar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Pesquisar.Location = new System.Drawing.Point(956, 151);
            this.BTN_Pesquisar.Name = "BTN_Pesquisar";
            this.BTN_Pesquisar.Size = new System.Drawing.Size(116, 30);
            this.BTN_Pesquisar.TabIndex = 8;
            this.BTN_Pesquisar.Text = "Pesquisar";
            this.BTN_Pesquisar.UseVisualStyleBackColor = true;
            this.BTN_Pesquisar.Click += new System.EventHandler(this.BTN_Pesquisar_Click);
            // 
            // BTN_Atualizar
            // 
            this.BTN_Atualizar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Atualizar.Location = new System.Drawing.Point(834, 208);
            this.BTN_Atualizar.Name = "BTN_Atualizar";
            this.BTN_Atualizar.Size = new System.Drawing.Size(116, 30);
            this.BTN_Atualizar.TabIndex = 9;
            this.BTN_Atualizar.Text = "Atualizar";
            this.BTN_Atualizar.UseVisualStyleBackColor = true;
            this.BTN_Atualizar.Click += new System.EventHandler(this.BTN_Atualizar_Click);
            // 
            // BTN_Excluir
            // 
            this.BTN_Excluir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Excluir.Location = new System.Drawing.Point(956, 208);
            this.BTN_Excluir.Name = "BTN_Excluir";
            this.BTN_Excluir.Size = new System.Drawing.Size(116, 30);
            this.BTN_Excluir.TabIndex = 10;
            this.BTN_Excluir.Text = "Excluir";
            this.BTN_Excluir.UseVisualStyleBackColor = true;
            this.BTN_Excluir.Click += new System.EventHandler(this.BTN_Excluir_Click);
            // 
            // DGV_dados
            // 
            this.DGV_dados.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(237)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_dados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_dados.BackgroundColor = System.Drawing.Color.Gray;
            this.DGV_dados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_dados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(237)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_dados.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_dados.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV_dados.Location = new System.Drawing.Point(12, 402);
            this.DGV_dados.Name = "DGV_dados";
            this.DGV_dados.RowTemplate.Height = 25;
            this.DGV_dados.Size = new System.Drawing.Size(1134, 338);
            this.DGV_dados.TabIndex = 13;
            this.DGV_dados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_dados_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data e Hora Atuais:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(683, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Seu IMC é:";
            // 
            // LBL_IMC
            // 
            this.LBL_IMC.AutoSize = true;
            this.LBL_IMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LBL_IMC.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_IMC.ForeColor = System.Drawing.Color.White;
            this.LBL_IMC.Location = new System.Drawing.Point(804, 348);
            this.LBL_IMC.Name = "LBL_IMC";
            this.LBL_IMC.Size = new System.Drawing.Size(87, 24);
            this.LBL_IMC.TabIndex = 16;
            this.LBL_IMC.Text = "imc aqui";
            this.LBL_IMC.Visible = false;
            // 
            // LBL_idx
            // 
            this.LBL_idx.AutoSize = true;
            this.LBL_idx.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_idx.Location = new System.Drawing.Point(895, 13);
            this.LBL_idx.Name = "LBL_idx";
            this.LBL_idx.Size = new System.Drawing.Size(36, 24);
            this.LBL_idx.TabIndex = 17;
            this.LBL_idx.Text = "idx";
            this.LBL_idx.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::Calculadora_IMC.Properties.Resources.favicon_transparent_32x32;
            this.pictureBox1.Location = new System.Drawing.Point(757, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 30);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // calcIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1158, 752);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBL_idx);
            this.Controls.Add(this.LBL_IMC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DGV_dados);
            this.Controls.Add(this.LBL_dateTime);
            this.Controls.Add(this.BTN_limpar);
            this.Controls.Add(this.BTN_Excluir);
            this.Controls.Add(this.BTN_Atualizar);
            this.Controls.Add(this.BTN_Pesquisar);
            this.Controls.Add(this.BTN_Inserir);
            this.Controls.Add(this.BTN_calcule);
            this.Controls.Add(this.LBL_Situação);
            this.Controls.Add(this.TXT_peso);
            this.Controls.Add(this.TXT_altura);
            this.Controls.Add(this.TXT_data);
            this.Controls.Add(this.TXT_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "calcIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora IMC";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TXT_nome;
        private TextBox TXT_altura;
        private TextBox TXT_peso;
        private Label LBL_Situação;
        private Button BTN_calcule;
        private Button BTN_limpar;
        private System.Windows.Forms.Timer timer1;
        private Label LBL_dateTime;
        private Label label6;
        private TextBox TXT_data;
        private Button BTN_Inserir;
        private Button BTN_Pesquisar;
        private Button BTN_Atualizar;
        private Button BTN_Excluir;
        private DataGridView DGV_dados;
        private Label label7;
        private Label label8;
        private Label LBL_IMC;
        private Label LBL_idx;
        private PictureBox pictureBox1;
    }
}