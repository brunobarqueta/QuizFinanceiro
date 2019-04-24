namespace QuizFinanceiro
{
    partial class Splash
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.pctBox1 = new System.Windows.Forms.PictureBox();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBox1
            // 
            this.pctBox1.Image = ((System.Drawing.Image)(resources.GetObject("pctBox1.Image")));
            this.pctBox1.InitialImage = null;
            this.pctBox1.Location = new System.Drawing.Point(-5, 0);
            this.pctBox1.Name = "pctBox1";
            this.pctBox1.Size = new System.Drawing.Size(266, 158);
            this.pctBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBox1.TabIndex = 0;
            this.pctBox1.TabStop = false;
            // 
            // tmr1
            // 
            this.tmr1.Enabled = true;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 156);
            this.Controls.Add(this.pctBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Financeiro";
            ((System.ComponentModel.ISupportInitialize)(this.pctBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBox1;
        private System.Windows.Forms.Timer tmr1;
    }
}

