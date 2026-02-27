using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnParImpar_Click(object sender, EventArgs e)
        {
       
            if (!int.TryParse(txtNumero.Text, out int n))
            {
                MessageBox.Show("Digite un número válido");
                return;
            }

            if (n % 2 == 0)
                MessageBox.Show("Es PAR");
            else
                MessageBox.Show("Es IMPAR");
        }
    }
}

