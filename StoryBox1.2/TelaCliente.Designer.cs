namespace StoryBox
{
    partial class TelaCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCliente));
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtGenero = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTodosOsLivros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPerfil
            // 
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Location = new System.Drawing.Point(975, 28);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(114, 38);
            this.btnPerfil.TabIndex = 3;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.BackColor = System.Drawing.Color.MistyRose;
            this.btnCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrinho.Location = new System.Drawing.Point(1119, 28);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(114, 38);
            this.btnCarrinho.TabIndex = 4;
            this.btnCarrinho.Text = "Carrinho";
            this.btnCarrinho.UseVisualStyleBackColor = false;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // dgvLivros
            // 
            this.dgvLivros.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Location = new System.Drawing.Point(202, 174);
            this.dgvLivros.Name = "dgvLivros";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivros.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLivros.Size = new System.Drawing.Size(923, 393);
            this.dgvLivros.TabIndex = 5;
            this.dgvLivros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivros_CellClick);
            this.dgvLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivros_CellContentClick);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(329, 129);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(598, 20);
            this.txtPesquisar.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(944, 129);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(92, 23);
            this.btnPesquisar.TabIndex = 7;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(25, 28);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(86, 32);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.MistyRose;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(973, 606);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(152, 38);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar No Carrinho";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.FormattingEnabled = true;
            this.txtGenero.ItemHeight = 18;
            this.txtGenero.Location = new System.Drawing.Point(89, 202);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(70, 184);
            this.txtGenero.TabIndex = 39;
            this.txtGenero.SelectedIndexChanged += new System.EventHandler(this.txtGenero_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 40);
            this.label1.TabIndex = 40;
            this.label1.Text = "Gêneros\r\nLiterários\r\n";
            // 
            // btnTodosOsLivros
            // 
            this.btnTodosOsLivros.BackColor = System.Drawing.Color.MistyRose;
            this.btnTodosOsLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodosOsLivros.Location = new System.Drawing.Point(89, 425);
            this.btnTodosOsLivros.Name = "btnTodosOsLivros";
            this.btnTodosOsLivros.Size = new System.Drawing.Size(70, 29);
            this.btnTodosOsLivros.TabIndex = 41;
            this.btnTodosOsLivros.Text = "Tudo";
            this.btnTodosOsLivros.UseVisualStyleBackColor = false;
            this.btnTodosOsLivros.Click += new System.EventHandler(this.btnTodosOsLivros_Click);
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1254, 681);
            this.Controls.Add(this.btnTodosOsLivros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dgvLivros);
            this.Controls.Add(this.btnCarrinho);
            this.Controls.Add(this.btnPerfil);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCliente";
            this.Text = "Perfil Cliente";
            this.Load += new System.EventHandler(this.TelaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnCarrinho;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox txtGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTodosOsLivros;
    }
}