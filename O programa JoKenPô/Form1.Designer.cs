
namespace O_programa_JoKenPô
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RbtPedra = new System.Windows.Forms.RadioButton();
            this.RbtPapel = new System.Windows.Forms.RadioButton();
            this.RbtTesoura = new System.Windows.Forms.RadioButton();
            this.BtnJogar = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PtbMaquina = new System.Windows.Forms.PictureBox();
            this.PtbJogador = new System.Windows.Forms.PictureBox();
            this.BtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PtbMaquina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbJogador)).BeginInit();
            this.SuspendLayout();
            // 
            // RbtPedra
            // 
            this.RbtPedra.AutoSize = true;
            this.RbtPedra.Location = new System.Drawing.Point(62, 81);
            this.RbtPedra.Name = "RbtPedra";
            this.RbtPedra.Size = new System.Drawing.Size(53, 17);
            this.RbtPedra.TabIndex = 0;
            this.RbtPedra.TabStop = true;
            this.RbtPedra.Text = "Pedra";
            this.RbtPedra.UseVisualStyleBackColor = true;
            this.RbtPedra.CheckedChanged += new System.EventHandler(this.RbtPedra_CheckedChanged);
            // 
            // RbtPapel
            // 
            this.RbtPapel.AutoSize = true;
            this.RbtPapel.Location = new System.Drawing.Point(62, 117);
            this.RbtPapel.Name = "RbtPapel";
            this.RbtPapel.Size = new System.Drawing.Size(52, 17);
            this.RbtPapel.TabIndex = 1;
            this.RbtPapel.TabStop = true;
            this.RbtPapel.Text = "Papel";
            this.RbtPapel.UseVisualStyleBackColor = true;
            this.RbtPapel.CheckedChanged += new System.EventHandler(this.RbtPapel_CheckedChanged);
            // 
            // RbtTesoura
            // 
            this.RbtTesoura.AutoSize = true;
            this.RbtTesoura.Location = new System.Drawing.Point(62, 156);
            this.RbtTesoura.Name = "RbtTesoura";
            this.RbtTesoura.Size = new System.Drawing.Size(64, 17);
            this.RbtTesoura.TabIndex = 2;
            this.RbtTesoura.TabStop = true;
            this.RbtTesoura.Text = "Tesoura";
            this.RbtTesoura.UseVisualStyleBackColor = true;
            this.RbtTesoura.CheckedChanged += new System.EventHandler(this.RbtTesoura_CheckedChanged);
            // 
            // BtnJogar
            // 
            this.BtnJogar.Location = new System.Drawing.Point(381, 347);
            this.BtnJogar.Name = "BtnJogar";
            this.BtnJogar.Size = new System.Drawing.Size(75, 23);
            this.BtnJogar.TabIndex = 4;
            this.BtnJogar.Text = "JOGAR!";
            this.BtnJogar.UseVisualStyleBackColor = true;
            this.BtnJogar.Click += new System.EventHandler(this.BtnJogar_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.Location = new System.Drawing.Point(12, 401);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(277, 36);
            this.Nome.TabIndex = 5;
            this.Nome.Text = "Gabriel Victor Cepeda RM 21799";
            this.Nome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Jonathan Pereira dos Santos  RM:22325";
            // 
            // PtbMaquina
            // 
            this.PtbMaquina.Location = new System.Drawing.Point(436, 98);
            this.PtbMaquina.Name = "PtbMaquina";
            this.PtbMaquina.Size = new System.Drawing.Size(232, 206);
            this.PtbMaquina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbMaquina.TabIndex = 6;
            this.PtbMaquina.TabStop = false;
            this.PtbMaquina.Click += new System.EventHandler(this.PtbMaquina_Click);
            // 
            // PtbJogador
            // 
            this.PtbJogador.Image = global::O_programa_JoKenPô.Properties.Resources.pedraquadrada;
            this.PtbJogador.Location = new System.Drawing.Point(173, 98);
            this.PtbJogador.Name = "PtbJogador";
            this.PtbJogador.Size = new System.Drawing.Size(230, 206);
            this.PtbJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtbJogador.TabIndex = 3;
            this.PtbJogador.TabStop = false;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(483, 347);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 8;
            this.BtnReset.Text = "RESETAR";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 446);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PtbMaquina);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.BtnJogar);
            this.Controls.Add(this.PtbJogador);
            this.Controls.Add(this.RbtTesoura);
            this.Controls.Add(this.RbtPapel);
            this.Controls.Add(this.RbtPedra);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PtbMaquina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PtbJogador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RbtPedra;
        private System.Windows.Forms.RadioButton RbtPapel;
        private System.Windows.Forms.RadioButton RbtTesoura;
        private System.Windows.Forms.PictureBox PtbJogador;
        private System.Windows.Forms.Button BtnJogar;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.PictureBox PtbMaquina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReset;
    }
}

