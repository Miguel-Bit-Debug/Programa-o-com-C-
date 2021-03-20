using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text);
        }

        private void btn_LimparElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
        }

        private void btn_resetarElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Add("Carro");
            cb_transportes.Items.Add("Avião");
            cb_transportes.Items.Add("Navio");
            cb_transportes.Items.Add("Ônibus");
            cb_transportes.Items.Add("Trem");
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_trasnporte.Text = cb_transportes.Text;
        }

        private void btn_AdicionarNovoTransporte_Click(object sender, EventArgs e)
        {
            if(tb_trasnporte.Text != "")
            {
                if (cb_transportes.FindString(tb_trasnporte.Text) < 0)
                {
                    cb_transportes.Items.Add(tb_trasnporte.Text);
                }
                
            }
        }
    }
}
