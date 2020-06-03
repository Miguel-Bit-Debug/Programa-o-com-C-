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
    public partial class F_checkBox : Form
    {

        List <CheckBox> transp = new List<CheckBox>();

        public F_checkBox()
        {
            InitializeComponent();

            transp.Add(cb_carro);
            transp.Add(cb_aviao);
            transp.Add(cb_navio);
            transp.Add(cb_onibus);
        }

        private void btn_transportes_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach(CheckBox cb in transp)
            {
                if(cb.Checked)
                {
                    txt += cb.Text + ", ";
                }
            }

            MessageBox.Show(txt);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            F_filhoCheckBox f_filhoCheckBox = new F_filhoCheckBox();

            f_filhoCheckBox.ShowDialog();
        }
    }
}
