using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaPrincipal
{
    public partial class Subtração : Form
    {
        public Subtração()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(textBox1.Text);
            int valor2 = Convert.ToInt32(textBox2.Text);

            int resultado = valor1 - valor2;

            textBox3.Text = resultado.ToString();
        }
    }
}
