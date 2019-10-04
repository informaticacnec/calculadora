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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          double num1 = Convert.ToDouble(tb_num1.Text);
          double num2 = Convert.ToDouble(tb_num2.Text);

            string resultado = Convert.ToString(num1 + num2) ;
            
            MessageBox.Show(resultado);
        }
    }
}
