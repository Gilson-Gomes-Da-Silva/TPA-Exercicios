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
    public partial class frmEx13 : Form
    {
        public frmEx13()
        {
            InitializeComponent();
        }
        double areaTot;

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAreaCom.Clear();
            txtCompCom.Clear();
            txtLargCom.Clear();
            txtNomeCom.Clear();
            txtAreaTot.Clear();
            txtNomeCom.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double comp, larg, areaCom;
            string nome;
            larg = Convert.ToDouble(txtLargCom.Text);
            comp = Convert.ToDouble(txtCompCom.Text);
            if (double.TryParse(txtLargCom.Text, out larg) && double.TryParse(txtCompCom.Text, out comp))
            {

                nome = txtNomeCom.Text;
                areaCom = larg * comp;
                areaTot += areaCom;
                areaCom.ToString();
                txtAreaCom.Text = ($"A área do cômodo '{nome}' é de: {areaCom}m²");

                var result = MessageBox.Show("Deseja continuar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    txtAreaCom.Clear();
                    txtCompCom.Clear();
                    txtLargCom.Clear();
                    txtNomeCom.Clear();
                }
                else
                {
                    areaTot.ToString();
                    txtAreaTot.Text = ($"A área total do ímovel é de: {areaTot}m²");
                }
            }
        }
    }
}
