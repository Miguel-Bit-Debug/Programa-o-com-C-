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
    public partial class F_listView : Form
    {
        public F_listView()
        {
            InitializeComponent();
        }

        private void limpar()
        {
            tb_id.Clear();
            tb_produto.Clear();
            tb_qtde.Clear();
            tb_preco.Clear();
            tb_id.Focus();
        }

        private void obter()
        {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_qtde.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(tb_id.Text == "" || tb_preco.Text == "" || tb_produto.Text == "" || tb_qtde.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                
                return;
            } else
            {
                string[] pr = new string[4];
                pr[0] = tb_id.Text;
                pr[1] = tb_produto.Text;
                pr[2] = tb_qtde.Text;
                pr[3] = tb_preco.Text;

                ListViewItem l = new ListViewItem(pr);
                lv_produtos.Items.Add(l);
                limpar();
            }
            
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            try {
                lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
            } catch
            {
                MessageBox.Show("Não existe mais itens na lista");
            }
        }

        private void btn_obter_Click(object sender, EventArgs e)
        {
            obter();


        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lv_produtos.SelectedItems.Count > 0)
                {
                    obter();
                } else
                {
                    MessageBox.Show("Selecione um item válido!");
                }
            } catch
            {
                MessageBox.Show("Erro interno");
            }
        }
    }
}
