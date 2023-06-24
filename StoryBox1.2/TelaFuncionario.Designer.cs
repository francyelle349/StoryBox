namespace StoryBox
{
    partial class Funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcionario));
            this.btnGeneros = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnAcessoLivros = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeneros
            // 
            this.btnGeneros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneros.Location = new System.Drawing.Point(693, 79);
            this.btnGeneros.Name = "btnGeneros";
            this.btnGeneros.Size = new System.Drawing.Size(551, 235);
            this.btnGeneros.TabIndex = 4;
            this.btnGeneros.Text = "Gêneros \r\nLiterários";
            this.btnGeneros.UseVisualStyleBackColor = true;
            this.btnGeneros.Click += new System.EventHandler(this.btnGeneros_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.MistyRose;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(693, 373);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(551, 235);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Location = new System.Drawing.Point(81, 373);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(551, 235);
            this.btnRelatorio.TabIndex = 6;
            this.btnRelatorio.Text = "Relatórios ";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnAcessoLivros
            // 
            this.btnAcessoLivros.BackColor = System.Drawing.Color.MistyRose;
            this.btnAcessoLivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessoLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessoLivros.Location = new System.Drawing.Point(94, 79);
            this.btnAcessoLivros.Name = "btnAcessoLivros";
            this.btnAcessoLivros.Size = new System.Drawing.Size(551, 235);
            this.btnAcessoLivros.TabIndex = 7;
            this.btnAcessoLivros.Text = "Livros";
            this.btnAcessoLivros.UseVisualStyleBackColor = false;
            this.btnAcessoLivros.Click += new System.EventHandler(this.btnAcessoLivros_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(23, 24);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 38);
            this.btnVoltar.TabIndex = 46;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAcessoLivros);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnGeneros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Funcionario";
            this.Text = "Perfil Funcionário";
            this.Load += new System.EventHandler(this.TelaFuncionario_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGeneros;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnAcessoLivros;
        private System.Windows.Forms.Button btnVoltar;
    }
}