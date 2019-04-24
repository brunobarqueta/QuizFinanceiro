using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuizFinanceiro
{
    public partial class Exercicios2 : Form
    {
        public double total = 0;

        public string nome = "";
        public Exercicios2()
        {
            InitializeComponent();

        
        }

        public Exercicios2(double total, string nome)
        {
            InitializeComponent();
            this.total = total;
            this.nome = nome;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (rdBtn17.Checked)
            {
                total += 1;
            }
            
            if (rdBtn23.Checked)
            {
                total += 1;
            }

            if (rdBtn28.Checked)
            {
                total += 1;
            }

            if (rdBtn32.Checked)
            {
                total += 1;
            }

            if (rdBtn35.Checked)
            {
                total += 1;
            }


            string path = @"C:\Users\Bruno\Desktop\pontuação.txt";



            if (File.Exists(path)){
                string[] linesFile = File.ReadAllLines(path, Encoding.UTF8);

                string[] lines = new string[linesFile.Length];


                string[] linesOrdered = new string[linesFile.Length+1];
                linesOrdered[0] = "Pontuação Nome";
                

                for (int i = 1; i < linesFile.Length; i++) {
                    lines[i-1] = linesFile[i];
                }
                lines[lines.Length - 1] = total + " " + nome;

                object[,] dadoJogada = new object[lines.Length, 2];
                object[,] ordenado = new object[lines.Length, 2];
                double pontosCompare = -1;
                int index = -1;

                for (int i = 0; i<lines.Length; i++)
                {
                    string[] words = lines[i].Split(' ');
                    dadoJogada[i,0] = (object)Convert.ChangeType(words[0], typeof(object));
                    dadoJogada[i,1] = (object)Convert.ChangeType(words[1], typeof(object));
                }

                for (int j = 0; j < lines.Length; j++)
                {
                    
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (dadoJogada[i, 0] == null) continue;
                        if(i == 0)
                        {
                            pontosCompare = Convert.ToDouble(dadoJogada[i, 0]);
                            index = 0;
                        }
                        else if (pontosCompare < Convert.ToDouble(dadoJogada[i, 0]))
                        {
                            pontosCompare = Convert.ToDouble(dadoJogada[i, 0]);
                            index = i;
                        }
                    }
                    ordenado[j, 0] = dadoJogada[index, 0];
                    ordenado[j, 1] = dadoJogada[index, 1];
                    linesOrdered[j+1] = dadoJogada[index, 0] + " " + dadoJogada[index, 1];
                    dadoJogada[index, 0] = null;
                    index = -1;
                    pontosCompare = -1;

                }

             
                    File.Delete(path);
                    File.WriteAllLines(path, linesOrdered, Encoding.UTF8);



            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Pontuação Nome");  
                    sw.WriteLine(total+" "+nome);                
                }
            }
            this.Hide();
            Resultado res = new Resultado();
            res.ShowDialog();






        }

        private void Exercicios2_Load(object sender, EventArgs e)
        {

        }
    }
}
