namespace StoryBox
{
    partial class TelaFuncionarioRelatorios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFuncionarioRelatorios));
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnMaiorEstoqueLivros = new System.Windows.Forms.Button();
            this.btnMaiorEstoqueGeneros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRelatorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRelatorio.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRelatorio.GridColor = System.Drawing.Color.MistyRose;
            this.dgvRelatorio.Location = new System.Drawing.Point(311, 146);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.Size = new System.Drawing.Size(616, 323);
            this.dgvRelatorio.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(46, 49);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 29);
            this.btnVoltar.TabIndex = 49;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnMaiorEstoqueLivros
            // 
            this.btnMaiorEstoqueLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaiorEstoqueLivros.Location = new System.Drawing.Point(444, 569);
            this.btnMaiorEstoqueLivros.Name = "btnMaiorEstoqueLivros";
            this.btnMaiorEstoqueLivros.Size = new System.Drawing.Size(390, 49);
            this.btnMaiorEstoqueLivros.TabIndex = 50;
            this.btnMaiorEstoqueLivros.Text = "Livros: Maiores Estoques";
            this.btnMaiorEstoqueLivros.UseVisualStyleBackColor = true;
            this.btnMaiorEstoqueLivros.Click += new System.EventHandler(this.btnMaiorEstoqueLivros_Click);
            // 
            // btnMaiorEstoqueGeneros
            // 
            this.btnMaiorEstoqueGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaiorEstoqueGeneros.Location = new System.Drawing.Point(444, 497);
            this.btnMaiorEstoqueGeneros.Name = "btnMaiorEstoqueGeneros";
            this.btnMaiorEstoqueGeneros.Size = new System.Drawing.Size(390, 49);
            this.btnMaiorEstoqueGeneros.TabIndex = 51;
            this.btnMaiorEstoqueGeneros.Text = "Gêneros: Maiores Estoques";
            this.btnMaiorEstoqueGeneros.UseVisualStyleBackColor = true;
            this.btnMaiorEstoqueGeneros.Click += new System.EventHandler(this.btnMaiorEstoqueGeneros_Click);
            // 
            // TelaFuncionarioRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1254, 681);
            this.Controls.Add(this.btnMaiorEstoqueGeneros);
            this.Controls.Add(this.btnMaiorEstoqueLivros);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvRelatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaFuncionarioRelatorios";
            this.Text = "Relatórios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnMaiorEstoqueLivros;
        private System.Windows.Forms.Button btnMaiorEstoqueGeneros;
    }
}