using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizFinanceiro
{
    public partial class Exercicios1 : Form
    {
        public double total = 0;

        public string nome = "";
        public Exercicios1()
        {
            InitializeComponent();
        }
        public Exercicios1(String nome)
        {
            InitializeComponent();
            this.nome = nome;
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (!cckBox1.Checked)
            {
                total += 0.33;
            }
            if (cckBox2.Checked)
            {
                total += 0.33;
            }
            if (cckBox3.Checked)
            {
                total += 0.34;
            }
            if (rdBtn3.Checked)
            {
                total += 1;
            }
            if (rdBtn5.Checked)
            {
                total += 1;
            }
            if (rdBtn11.Checked)
            {
                total += 1;
            }
            if (rdBtn14.Checked)
            {
                total += 1;
            }

            this.Hide();
            Exercicios2 a = new Exercicios2(total, nome);
            a.ShowDialog();
        }

        private void Exercicios1_Load(object sender, EventArgs e)
        {

        }
    }
}
