namespace BlackJack_Black_Edition_0._0._6
{
    partial class MenuInicial
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
            this.BlackJackLogo = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.Button();
            this.UmJogador = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BlackJackLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BlackJackLogo
            // 
            this.BlackJackLogo.Image = global::BlackJack_Black_Edition_0._0._6.Properties.Resources.BlackJack_Image;
            this.BlackJackLogo.Location = new System.Drawing.Point(553, 149);
            this.BlackJackLogo.Name = "BlackJackLogo";
            this.BlackJackLogo.Size = new System.Drawing.Size(349, 283);
            this.BlackJackLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BlackJackLogo.TabIndex = 0;
            this.BlackJackLogo.TabStop = false;
            this.BlackJackLogo.Click += new System.EventHandler(this.BlackJackLogo_Click);
            // 
            // Fechar
            // 
            this.Fechar.FlatAppearance.BorderSize = 0;
            this.Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fechar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechar.ForeColor = System.Drawing.Color.White;
            this.Fechar.Location = new System.Drawing.Point(0, 0);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(42, 23);
            this.Fechar.TabIndex = 1;
            this.Fechar.Text = "X";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // UmJogador
            // 
            this.UmJogador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.UmJogador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.UmJogador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.UmJogador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UmJogador.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UmJogador.ForeColor = System.Drawing.Color.White;
            this.UmJogador.Location = new System.Drawing.Point(649, 568);
            this.UmJogador.Name = "UmJogador";
            this.UmJogador.Size = new System.Drawing.Size(157, 52);
            this.UmJogador.TabIndex = 2;
            this.UmJogador.Text = "Conectar";
            this.UmJogador.UseVisualStyleBackColor = true;
            this.UmJogador.Click += new System.EventHandler(this.UmJogador_Click);
            this.UmJogador.MouseEnter += new System.EventHandler(this.UmJogador_MouseEnter);
            this.UmJogador.MouseLeave += new System.EventHandler(this.UmJogador_MouseLeave);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.DimGray;
            this.textBox5.Location = new System.Drawing.Point(591, 494);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(278, 28);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Digite seu nome";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.Click += new System.EventHandler(this.textBox5_Click);
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyDown);
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1277, 788);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.UmJogador);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.BlackJackLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuInicial";
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BlackJackLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BlackJackLogo;
        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Button UmJogador;
        private System.Windows.Forms.TextBox textBox5;
    }
}

