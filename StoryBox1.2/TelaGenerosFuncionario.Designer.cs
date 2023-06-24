namespace StoryBox
{
    partial class Generos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generos));
            this.dgvGeneros = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnGenero = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGeneros
            // 
            this.dgvGeneros.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvGeneros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGeneros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGeneros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGeneros.Enabled = false;
            this.dgvGeneros.GridColor = System.Drawing.Color.MistyRose;
            this.dgvGeneros.Location = new System.Drawing.Point(340, 75);
            this.dgvGeneros.Name = "dgvGeneros";
            this.dgvGeneros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGeneros.Size = new System.Drawing.Size(551, 328);
            this.dgvGeneros.TabIndex = 0;
            this.dgvGeneros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGeneros_CellContentClick);
            this.dgvGeneros.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGeneros_CellEndEdit);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(50, 39);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 29);
            this.btnVoltar.TabIndex = 48;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnGenero
            // 
            this.btnGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenero.Location = new System.Drawing.Point(449, 443);
            this.btnGenero.Name = "btnGenero";
            this.btnGenero.Size = new System.Drawing.Size(114, 38);
            this.btnGenero.TabIndex = 51;
            this.btnGenero.Text = "Cadastrar ";
            this.btnGenero.UseVisualStyleBackColor = true;
            this.btnGenero.Click += new System.EventHandler(this.btnGenero_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Location = new System.Drawing.Point(650, 443);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(114, 38);
            this.btnRemover.TabIndex = 54;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1116, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 111);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // Generos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1254, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnGenero);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvGeneros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Generos";
            this.Text = "Gêneros Literarios";
            this.Load += new System.EventHandler(this.TelaGenerosFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGeneros;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnGenero;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}