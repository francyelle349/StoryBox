namespace StoryBox
{
    partial class TelaFuncionarioAdicionarGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFuncionarioAdicionarGenero));
            this.txtRegistroGenero = new System.Windows.Forms.TextBox();
            this.btnSim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRegistroGenero
            // 
            this.txtRegistroGenero.Location = new System.Drawing.Point(102, 111);
            this.txtRegistroGenero.Name = "txtRegistroGenero";
            this.txtRegistroGenero.Size = new System.Drawing.Size(257, 20);
            this.txtRegistroGenero.TabIndex = 0;
            // 
            // btnSim
            // 
            this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSim.Location = new System.Drawing.Point(202, 157);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(69, 27);
            this.btnSim.TabIndex = 35;
            this.btnSim.Text = "Confirmar";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Novo Gênero";
            // 
            // TelaFuncionarioAdicionarGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegistroGenero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaFuncionarioAdicionarGenero";
            this.Text = "Adicionar Gênero";
            this.Load += new System.EventHandler(this.TelaFuncionarioAdicionarGenero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegistroGenero;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Label label1;
    }
}