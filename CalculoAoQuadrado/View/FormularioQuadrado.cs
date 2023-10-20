using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoAoQuadrado.View
{
    public partial class FormularioQuadrado : Form
    {
        public FormularioQuadrado()
        {
            InitializeComponent();
        }

        private int quadrado(int num)
        {
            
            int resultado = num * num;
            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            

           

            label3.Text = " O valor quadrado de " + num + " é " + quadrado(num);
            textBox1.Focus();
            textBox1.SelectAll();
        }
    }
}
