using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPA_Exercicios
{
    public partial class frmEx11 : Form
    {
        public frmEx11()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtTabu.Clear();
            txtNum.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            double cont, num, tabuada;
            cont = 1;
            txtTabu.Clear();
            if (double.TryParse(txtNum.Text, out num))
            {
                while (cont != 11)
                {

                    tabuada = num * cont;
                    txtTabu.Text += $"{num} x {cont} = {tabuada} \r\n";
                    cont += 1;
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
                txtNum.Clear();
                txtTabu.Clear();
                txtNum.Focus();
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            double cont, num, tabuada;
            if (double.TryParse(txtNum.Text, out num))
            {
                txtTabu.Clear();
                for (cont = 1; cont <= 10; cont++)
                {
                    tabuada = num * cont;
                    txtTabu.Text += $"{num} x {cont} = {tabuada}\r\n";
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
                txtNum.Clear();
                txtTabu.Clear();
                txtNum.Focus();
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            double cont, num, tabuada;
            cont = 1;
            if (Double.TryParse(txtNum.Text, out num))
            {
                txtTabu.Clear();
                do
                {

                    tabuada = num * cont;
                    txtTabu.Text += $"{num} x {cont} = {tabuada}\r\n";
                    cont += 1;
                }
                while (cont != 11);

            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
                txtNum.Clear();
                txtTabu.Clear();
                txtNum.Focus();
            }
        }
    }
}
