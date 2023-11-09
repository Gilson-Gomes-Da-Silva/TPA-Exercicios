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
    public partial class frmEx12 : Form
    {
        public frmEx12()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCelc.Clear();
            txtFah.Clear();
            txtSomandoFah.Clear();
            txtCelc.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            double C, F, somandoF, cont;
            if (double.TryParse(txtCelc.Text, out C))
            {
                cont = 0;
                F = (C * 1.8) + 32;
                txtSomandoFah.Text = ($"{F}F°\r\n");
                txtFah.Text = ($"{F}F°");
                while (cont != 10)
                {
                    F += 10;
                    somandoF = F;
                    txtSomandoFah.Text += ($"{somandoF}F°\r\n");
                    cont += 1;

                }
            }
            else
            {
                MessageBox.Show("Digite um número válido!");
                txtCelc.Clear();
                txtFah.Clear();
                txtSomandoFah.Clear();
                txtCelc.Focus();
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            double C, F, somandoF, cont;
            if (double.TryParse(txtCelc.Text, out C))
            {

                F = (C * 1.8) + 32;
                txtFah.Text = ($"{F}F°");
                txtSomandoFah.Text = ($"{F}F°\r\n");
                for (cont = 1; cont != 11; cont++)
                {
                    F += 10;
                    somandoF = F;
                    txtSomandoFah.Text += ($"{somandoF}F°\r\n");
                }
            }
            else
            {
                MessageBox.Show("Digite um número válido!");
                txtCelc.Clear();
                txtFah.Clear();
                txtSomandoFah.Clear();
                txtCelc.Focus();

            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            double C, F, somandoF, cont;
            if (double.TryParse(txtCelc.Text, out C))
            {
                F = (C * 1.8) + 32;
                txtFah.Text = ($"{F}F°");
                txtSomandoFah.Text = ($"{F}F°\r\n");
                cont = 0;
                do
                {

                    F += 10;
                    somandoF = F;
                    txtSomandoFah.Text += ($"{somandoF}F°\r\n");
                    cont++;
                }
                while (cont != 10);
            }
            else
            {
                MessageBox.Show("Digite um número válido!");
                txtCelc.Clear();
                txtFah.Clear();
                txtSomandoFah.Clear();
                txtCelc.Focus();
            }
        }
    }
}
