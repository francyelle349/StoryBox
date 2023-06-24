namespace StoryBox
{
    partial class TelaClienteCarrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaClienteCarrinho));
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivros
            // 
            this.dgvLivros.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Location = new System.Drawing.Point(76, 92);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.Size = new System.Drawing.Size(1103, 496);
            this.dgvLivros.TabIndex = 6;
            this.dgvLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivros_CellContentClick);
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.BackColor = System.Drawing.Color.MistyRose;
            this.btnCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrinho.Location = new System.Drawing.Point(1056, 615);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(114, 38);
            this.btnCarrinho.TabIndex = 8;
            this.btnCarrinho.Text = "Comprar";
            this.btnCarrinho.UseVisualStyleBackColor = false;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Location = new System.Drawing.Point(912, 615);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(114, 38);
            this.btnPerfil.TabIndex = 7;
            this.btnPerfil.Text = "Excluir";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 628);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Valor Total";
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(21, 27);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(86, 32);
            this.btnVoltar.TabIndex = 41;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(147, 625);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(76, 20);
            this.txtValorTotal.TabIndex = 42;
            this.txtValorTotal.TextChanged += new System.EventHandler(this.txtValorTotal_TextChanged);
            // 
            // TelaClienteCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1254, 681);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCarrinho);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.dgvLivros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaClienteCarrinho";
            this.Text = "Carrinho";
            this.Load += new System.EventHandler(this.TelaClienteCarrinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCarrinho;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtValorTotal;
        public System.Windows.Forms.DataGridView dgvLivros;
    }
}