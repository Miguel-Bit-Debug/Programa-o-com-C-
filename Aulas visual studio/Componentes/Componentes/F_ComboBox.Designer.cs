namespace Componentes
{
    partial class F_ComboBox
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
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_mostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_LimparElementos = new System.Windows.Forms.Button();
            this.btn_resetarElementos = new System.Windows.Forms.Button();
            this.tb_trasnporte = new System.Windows.Forms.TextBox();
            this.btn_AdicionarNovoTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(12, 12);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(208, 21);
            this.cb_transportes.TabIndex = 0;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // btn_mostrarSelecionados
            // 
            this.btn_mostrarSelecionados.Location = new System.Drawing.Point(239, 12);
            this.btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            this.btn_mostrarSelecionados.Size = new System.Drawing.Size(204, 23);
            this.btn_mostrarSelecionados.TabIndex = 1;
            this.btn_mostrarSelecionados.Text = "Mostrar Selecionado";
            this.btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_mostrarSelecionados.Click += new System.EventHandler(this.btn_mostrarSelecionados_Click);
            // 
            // btn_LimparElementos
            // 
            this.btn_LimparElementos.Location = new System.Drawing.Point(239, 42);
            this.btn_LimparElementos.Name = "btn_LimparElementos";
            this.btn_LimparElementos.Size = new System.Drawing.Size(204, 23);
            this.btn_LimparElementos.TabIndex = 2;
            this.btn_LimparElementos.Text = "Limpar Elementos";
            this.btn_LimparElementos.UseVisualStyleBackColor = true;
            this.btn_LimparElementos.Click += new System.EventHandler(this.btn_LimparElementos_Click);
            // 
            // btn_resetarElementos
            // 
            this.btn_resetarElementos.Location = new System.Drawing.Point(239, 71);
            this.btn_resetarElementos.Name = "btn_resetarElementos";
            this.btn_resetarElementos.Size = new System.Drawing.Size(204, 23);
            this.btn_resetarElementos.TabIndex = 3;
            this.btn_resetarElementos.Text = "Resetar Elementos";
            this.btn_resetarElementos.UseVisualStyleBackColor = true;
            this.btn_resetarElementos.Click += new System.EventHandler(this.btn_resetarElementos_Click);
            // 
            // tb_trasnporte
            // 
            this.tb_trasnporte.Location = new System.Drawing.Point(239, 145);
            this.tb_trasnporte.Name = "tb_trasnporte";
            this.tb_trasnporte.Size = new System.Drawing.Size(204, 20);
            this.tb_trasnporte.TabIndex = 4;
            // 
            // btn_AdicionarNovoTransporte
            // 
            this.btn_AdicionarNovoTransporte.Location = new System.Drawing.Point(239, 171);
            this.btn_AdicionarNovoTransporte.Name = "btn_AdicionarNovoTransporte";
            this.btn_AdicionarNovoTransporte.Size = new System.Drawing.Size(204, 23);
            this.btn_AdicionarNovoTransporte.TabIndex = 5;
            this.btn_AdicionarNovoTransporte.Text = "Adicionar Novo Transporte";
            this.btn_AdicionarNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_AdicionarNovoTransporte.Click += new System.EventHandler(this.btn_AdicionarNovoTransporte_Click);
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 380);
            this.Controls.Add(this.btn_AdicionarNovoTransporte);
            this.Controls.Add(this.tb_trasnporte);
            this.Controls.Add(this.btn_resetarElementos);
            this.Controls.Add(this.btn_LimparElementos);
            this.Controls.Add(this.btn_mostrarSelecionados);
            this.Controls.Add(this.cb_transportes);
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transportes;
        private System.Windows.Forms.Button btn_mostrarSelecionados;
        private System.Windows.Forms.Button btn_LimparElementos;
        private System.Windows.Forms.Button btn_resetarElementos;
        private System.Windows.Forms.TextBox tb_trasnporte;
        private System.Windows.Forms.Button btn_AdicionarNovoTransporte;
    }
}