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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            bool ativo = true;           
            if (ativo)
            {
                this.Opacity -= 0.07;
            }
            if(this.Opacity == 0)
            {
                ativo = false;
                tmr1.Enabled = false;
                this.Hide();
                Login a = new Login();
                a.ShowDialog();
               
            }           
        }
    }
}
