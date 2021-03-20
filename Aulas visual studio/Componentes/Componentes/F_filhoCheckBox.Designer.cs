namespace Componentes
{
    partial class F_filhoCheckBox
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
            this.cb_onibus = new System.Windows.Forms.CheckBox();
            this.cb_navio = new System.Windows.Forms.CheckBox();
            this.cb_aviao = new System.Windows.Forms.CheckBox();
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.btn_marcarTodos = new System.Windows.Forms.Button();
            this.btn_desmarcarTodos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_onibus
            // 
            this.cb_onibus.AutoSize = true;
            this.cb_onibus.Location = new System.Drawing.Point(12, 81);
            this.cb_onibus.Name = "cb_onibus";
            this.cb_onibus.Size = new System.Drawing.Size(59, 17);
            this.cb_onibus.TabIndex = 9;
            this.cb_onibus.Text = "Ônibus";
            this.cb_onibus.UseVisualStyleBackColor = true;
            this.cb_onibus.CheckedChanged += new System.EventHandler(this.cb_onibus_CheckedChanged);
            // 
            // cb_navio
            // 
            this.cb_navio.AutoSize = true;
            this.cb_navio.Location = new System.Drawing.Point(12, 58);
            this.cb_navio.Name = "cb_navio";
            this.cb_navio.Size = new System.Drawing.Size(54, 17);
            this.cb_navio.TabIndex = 8;
            this.cb_navio.Text = "Navio";
            this.cb_navio.UseVisualStyleBackColor = true;
            this.cb_navio.CheckedChanged += new System.EventHandler(this.cb_navio_CheckedChanged);
            // 
            // cb_aviao
            // 
            this.cb_aviao.AutoSize = true;
            this.cb_aviao.Location = new System.Drawing.Point(12, 35);
            this.cb_aviao.Name = "cb_aviao";
            this.cb_aviao.Size = new System.Drawing.Size(53, 17);
            this.cb_aviao.TabIndex = 7;
            this.cb_aviao.Text = "Avião";
            this.cb_aviao.UseVisualStyleBackColor = true;
            this.cb_aviao.CheckedChanged += new System.EventHandler(this.cb_aviao_CheckedChanged);
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(12, 12);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(51, 17);
            this.cb_carro.TabIndex = 6;
            this.cb_carro.Text = "Carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            this.cb_carro.CheckedChanged += new System.EventHandler(this.cb_carro_CheckedChanged);
            // 
            // btn_marcarTodos
            // 
            this.btn_marcarTodos.Location = new System.Drawing.Point(148, 12);
            this.btn_marcarTodos.Name = "btn_marcarTodos";
            this.btn_marcarTodos.Size = new System.Drawing.Size(162, 23);
            this.btn_marcarTodos.TabIndex = 11;
            this.btn_marcarTodos.Text = "Marcar todos";
            this.btn_marcarTodos.UseVisualStyleBackColor = true;
            this.btn_marcarTodos.Click += new System.EventHandler(this.btn_marcarTodos_Click);
            // 
            // btn_desmarcarTodos
            // 
            this.btn_desmarcarTodos.Location = new System.Drawing.Point(148, 52);
            this.btn_desmarcarTodos.Name = "btn_desmarcarTodos";
            this.btn_desmarcarTodos.Size = new System.Drawing.Size(162, 23);
            this.btn_desmarcarTodos.TabIndex = 12;
            this.btn_desmarcarTodos.Text = "desmarcar todos";
            this.btn_desmarcarTodos.UseVisualStyleBackColor = true;
            this.btn_desmarcarTodos.Click += new System.EventHandler(this.btn_desmarcarTodos_Click);
            // 
            // F_filhoCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 428);
            this.Controls.Add(this.btn_desmarcarTodos);
            this.Controls.Add(this.btn_marcarTodos);
            this.Controls.Add(this.cb_onibus);
            this.Controls.Add(this.cb_navio);
            this.Controls.Add(this.cb_aviao);
            this.Controls.Add(this.cb_carro);
            this.Name = "F_filhoCheckBox";
            this.Text = "F_filhoCheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cb_onibus;
        private System.Windows.Forms.CheckBox cb_navio;
        private System.Windows.Forms.CheckBox cb_aviao;
        private System.Windows.Forms.CheckBox cb_carro;
        private System.Windows.Forms.Button btn_marcarTodos;
        private System.Windows.Forms.Button btn_desmarcarTodos;
    }
}