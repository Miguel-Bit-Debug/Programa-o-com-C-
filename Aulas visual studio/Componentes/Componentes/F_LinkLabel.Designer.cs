namespace Componentes
{
    partial class F_LinkLabel
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
            this.ll_canal = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.ll_calculadora = new System.Windows.Forms.LinkLabel();
            this.ll_multiplos = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ll_canal
            // 
            this.ll_canal.AutoSize = true;
            this.ll_canal.Location = new System.Drawing.Point(13, 111);
            this.ll_canal.Name = "ll_canal";
            this.ll_canal.Size = new System.Drawing.Size(34, 13);
            this.ll_canal.TabIndex = 0;
            this.ll_canal.TabStop = true;
            this.ll_canal.Text = "Canal";
            this.ll_canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_canal_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite seu nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 29);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(100, 20);
            this.tb_nome.TabIndex = 2;
            // 
            // ll_calculadora
            // 
            this.ll_calculadora.AutoSize = true;
            this.ll_calculadora.Location = new System.Drawing.Point(68, 111);
            this.ll_calculadora.Name = "ll_calculadora";
            this.ll_calculadora.Size = new System.Drawing.Size(63, 13);
            this.ll_calculadora.TabIndex = 3;
            this.ll_calculadora.TabStop = true;
            this.ll_calculadora.Text = "Calculadora";
            this.ll_calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_calculadora_LinkClicked);
            // 
            // ll_multiplos
            // 
            this.ll_multiplos.AutoSize = true;
            this.ll_multiplos.Location = new System.Drawing.Point(9, 165);
            this.ll_multiplos.Name = "ll_multiplos";
            this.ll_multiplos.Size = new System.Drawing.Size(126, 13);
            this.ll_multiplos.TabIndex = 4;
            this.ll_multiplos.TabStop = true;
            this.ll_multiplos.Text = "Google - Canal - Youtube";
            this.ll_multiplos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_multiplos_LinkClicked);
            // 
            // F_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 400);
            this.Controls.Add(this.ll_multiplos);
            this.Controls.Add(this.ll_calculadora);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ll_canal);
            this.Name = "F_LinkLabel";
            this.Text = "F_LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ll_canal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.LinkLabel ll_calculadora;
        private System.Windows.Forms.LinkLabel ll_multiplos;
    }
}