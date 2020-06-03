namespace Componentes
{
    partial class F_listBox
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
            this.lb_carros = new System.Windows.Forms.ListBox();
            this.tb_carro = new System.Windows.Forms.TextBox();
            this.Carro = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_obter = new System.Windows.Forms.Button();
            this.btn_limparTudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_carros
            // 
            this.lb_carros.FormattingEnabled = true;
            this.lb_carros.Location = new System.Drawing.Point(12, 12);
            this.lb_carros.Name = "lb_carros";
            this.lb_carros.Size = new System.Drawing.Size(120, 173);
            this.lb_carros.TabIndex = 0;
            // 
            // tb_carro
            // 
            this.tb_carro.Location = new System.Drawing.Point(138, 28);
            this.tb_carro.Name = "tb_carro";
            this.tb_carro.Size = new System.Drawing.Size(100, 20);
            this.tb_carro.TabIndex = 1;
            // 
            // Carro
            // 
            this.Carro.AutoSize = true;
            this.Carro.Location = new System.Drawing.Point(139, 12);
            this.Carro.Name = "Carro";
            this.Carro.Size = new System.Drawing.Size(35, 13);
            this.Carro.TabIndex = 2;
            this.Carro.Text = "label1";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(140, 64);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(140, 94);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(100, 23);
            this.btn_remover.TabIndex = 4;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_obter
            // 
            this.btn_obter.Location = new System.Drawing.Point(140, 129);
            this.btn_obter.Name = "btn_obter";
            this.btn_obter.Size = new System.Drawing.Size(102, 23);
            this.btn_obter.TabIndex = 5;
            this.btn_obter.Text = "Obter";
            this.btn_obter.UseVisualStyleBackColor = true;
            this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
            // 
            // btn_limparTudo
            // 
            this.btn_limparTudo.Location = new System.Drawing.Point(140, 158);
            this.btn_limparTudo.Name = "btn_limparTudo";
            this.btn_limparTudo.Size = new System.Drawing.Size(102, 23);
            this.btn_limparTudo.TabIndex = 6;
            this.btn_limparTudo.Text = "Limpar Tudo";
            this.btn_limparTudo.UseVisualStyleBackColor = true;
            this.btn_limparTudo.Click += new System.EventHandler(this.btn_limparTudo_Click);
            // 
            // F_listBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 399);
            this.Controls.Add(this.btn_limparTudo);
            this.Controls.Add(this.btn_obter);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.Carro);
            this.Controls.Add(this.tb_carro);
            this.Controls.Add(this.lb_carros);
            this.Name = "F_listBox";
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_carros;
        private System.Windows.Forms.TextBox tb_carro;
        private System.Windows.Forms.Label Carro;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_obter;
        private System.Windows.Forms.Button btn_limparTudo;
    }
}