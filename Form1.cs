using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            

            bool TermosPrivacidade = false;

            if (TermosPrivacidade != true)
            {
                MessageBox.Show("Termos de Responsabilidade:\n Informamos que se jogar este jogo, não me responsabilizo de qualquer tipo de perda de neurónios.");
                MessageBox.Show("Disclaimer:\n Se não tens 18, podes jogar na mesma pois não se acarretam perdas de património.");
                MessageBox.Show("\tEstás perparado?");
                MessageBox.Show("\tDe certeza?");
                MessageBox.Show("\tFostes avisado...");
            }
            else
            {
                Application.Exit();
            }
        }

        private void lblSLOT_1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSPIN_Click(object sender, EventArgs e)
        {
            //a sintaxe clear não se aplica a labels apenas a listBoxs e comboBoxs
            lblSLOT_1.Text = string.Empty;
            lblSLOT_2.Text = string.Empty;
            lblSLOT_3.Text = string.Empty;

            int slot1 = random.Next(7);
            int slot2 = random.Next(7);
            int slot3 = random.Next(7);

            lblSLOT_1.Text = slot1.ToString();
            lblSLOT_2.Text = slot2.ToString();
            lblSLOT_3.Text = slot3.ToString();

            if (lblSLOT_1.Text == "7" && lblSLOT_2.Text == "7" && lblSLOT_3.Text == "7")
            {
                MessageBox.Show("Parabéns! Você ganhou!");
            }
            else
            {
                MessageBox.Show("Tente novamente. Não foi desta vez.");
            }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}