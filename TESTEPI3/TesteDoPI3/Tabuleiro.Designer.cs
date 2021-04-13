namespace TesteDoPI3
{
    partial class Tabuleiro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRolarDados = new System.Windows.Forms.Button();
            this.lblRetornoErro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picD1 = new System.Windows.Forms.PictureBox();
            this.picD2 = new System.Windows.Forms.PictureBox();
            this.picD3 = new System.Windows.Forms.PictureBox();
            this.picD4 = new System.Windows.Forms.PictureBox();
            this.picD5 = new System.Windows.Forms.PictureBox();
            this.picD6 = new System.Windows.Forms.PictureBox();
            this.lblResultados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Can´t Stop!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(5, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dados!";
            // 
            // btnRolarDados
            // 
            this.btnRolarDados.BackColor = System.Drawing.Color.Green;
            this.btnRolarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolarDados.ForeColor = System.Drawing.Color.White;
            this.btnRolarDados.Location = new System.Drawing.Point(150, 403);
            this.btnRolarDados.Name = "btnRolarDados";
            this.btnRolarDados.Size = new System.Drawing.Size(134, 126);
            this.btnRolarDados.TabIndex = 17;
            this.btnRolarDados.Text = "Rolar dados";
            this.btnRolarDados.UseVisualStyleBackColor = false;
            this.btnRolarDados.Click += new System.EventHandler(this.btnRolarDados_Click);
            // 
            // lblRetornoErro
            // 
            this.lblRetornoErro.AutoSize = true;
            this.lblRetornoErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetornoErro.ForeColor = System.Drawing.Color.Red;
            this.lblRetornoErro.Location = new System.Drawing.Point(345, 33);
            this.lblRetornoErro.Name = "lblRetornoErro";
            this.lblRetornoErro.Size = new System.Drawing.Size(0, 20);
            this.lblRetornoErro.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TesteDoPI3.Properties.Resources.tabuleiro;
            this.pictureBox1.Location = new System.Drawing.Point(349, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 494);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // picD1
            // 
            this.picD1.Location = new System.Drawing.Point(12, 401);
            this.picD1.Name = "picD1";
            this.picD1.Size = new System.Drawing.Size(63, 61);
            this.picD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picD1.TabIndex = 19;
            this.picD1.TabStop = false;
            // 
            // picD2
            // 
            this.picD2.Location = new System.Drawing.Point(81, 401);
            this.picD2.Name = "picD2";
            this.picD2.Size = new System.Drawing.Size(63, 61);
            this.picD2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picD2.TabIndex = 20;
            this.picD2.TabStop = false;
            // 
            // picD3
            // 
            this.picD3.Location = new System.Drawing.Point(12, 468);
            this.picD3.Name = "picD3";
            this.picD3.Size = new System.Drawing.Size(63, 61);
            this.picD3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picD3.TabIndex = 21;
            this.picD3.TabStop = false;
            // 
            // picD4
            // 
            this.picD4.Location = new System.Drawing.Point(81, 468);
            this.picD4.Name = "picD4";
            this.picD4.Size = new System.Drawing.Size(63, 61);
            this.picD4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picD4.TabIndex = 22;
            this.picD4.TabStop = false;
            // 
            // picD5
            // 
            this.picD5.Location = new System.Drawing.Point(12, 535);
            this.picD5.Name = "picD5";
            this.picD5.Size = new System.Drawing.Size(63, 61);
            this.picD5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picD5.TabIndex = 23;
            this.picD5.TabStop = false;
            // 
            // picD6
            // 
            this.picD6.Location = new System.Drawing.Point(81, 535);
            this.picD6.Name = "picD6";
            this.picD6.Size = new System.Drawing.Size(63, 61);
            this.picD6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picD6.TabIndex = 24;
            this.picD6.TabStop = false;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(150, 537);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(35, 13);
            this.lblResultados.TabIndex = 25;
            this.lblResultados.Text = "label3";
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(919, 620);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.picD6);
            this.Controls.Add(this.picD5);
            this.Controls.Add(this.picD4);
            this.Controls.Add(this.picD3);
            this.Controls.Add(this.picD2);
            this.Controls.Add(this.picD1);
            this.Controls.Add(this.lblRetornoErro);
            this.Controls.Add(this.btnRolarDados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Tabuleiro";
            this.Text = "Tabuleiro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRolarDados;
        private System.Windows.Forms.Label lblRetornoErro;
        private System.Windows.Forms.PictureBox picD1;
        private System.Windows.Forms.PictureBox picD2;
        private System.Windows.Forms.PictureBox picD3;
        private System.Windows.Forms.PictureBox picD4;
        private System.Windows.Forms.PictureBox picD5;
        private System.Windows.Forms.PictureBox picD6;
        private System.Windows.Forms.Label lblResultados;
    }
}