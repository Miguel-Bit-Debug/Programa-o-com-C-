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
    public partial class F_listBox : Form
    {
        List<string> carros = new List<string>();
        public F_listBox()
        {
            InitializeComponent();
            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");

            lb_carros.DataSource = carros;
        }

        private void atualizaLB(ListBox lb, List <string> l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_carro.Text == "")
            {
                MessageBox.Show("Digite um carro!");
                tb_carro.Focus();
            } else
            {
                if(lb_carros.FindString(tb_carro.Text) < 0)
                {
                    carros.Add(tb_carro.Text);
                    atualizaLB(lb_carros, carros);
                    tb_carro.Clear();
                    tb_carro.Focus();
                }
                
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                carros.RemoveAt(lb_carros.SelectedIndex);
                atualizaLB(lb_carros, carros);
            }
            catch
            {
                MessageBox.Show("Não existe mais itens para excluir");
            }
            
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            try {
                tb_carro.Text = carros[lb_carros.SelectedIndex];
            } catch
            {
                MessageBox.Show("Não tem nada na lista");
            }
        }

        private void btn_limparTudo_Click(object sender, EventArgs e)
        {
            carros.Clear();
            tb_carro.Clear();
            atualizaLB(lb_carros, carros);
        }
    }
}
