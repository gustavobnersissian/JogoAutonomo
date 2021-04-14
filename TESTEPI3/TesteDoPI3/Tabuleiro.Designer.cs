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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabuleiro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRolarDados = new System.Windows.Forms.Button();
            this.lblRetornoErro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picD1 = new System.Windows.Forms.PictureBox();
            this.picD2 = new System.Windows.Forms.PictureBox();
            this.picD3 = new System.Windows.Forms.PictureBox();
            this.picD4 = new System.Windows.Forms.PictureBox();
            this.txtId2 = new System.Windows.Forms.TextBox();
            this.txtId1 = new System.Windows.Forms.TextBox();
            this.txtId3 = new System.Windows.Forms.TextBox();
            this.txtId4 = new System.Windows.Forms.TextBox();
            this.txtValor4 = new System.Windows.Forms.TextBox();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD4)).BeginInit();
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
            this.btnRolarDados.Location = new System.Drawing.Point(153, 402);
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
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(349, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 494);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // picD1
            // 
            this.picD1.ErrorImage = null;
            this.picD1.Location = new System.Drawing.Point(12, 401);
            this.picD1.Name = "picD1";
            this.picD1.Size = new System.Drawing.Size(63, 61);
            this.picD1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picD1.TabIndex = 19;
            this.picD1.TabStop = false;
            // 
            // picD2
            // 
            this.picD2.ErrorImage = null;
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
            // txtId2
            // 
            this.txtId2.Location = new System.Drawing.Point(150, 324);
            this.txtId2.Name = "txtId2";
            this.txtId2.Size = new System.Drawing.Size(21, 20);
            this.txtId2.TabIndex = 26;
            // 
            // txtId1
            // 
            this.txtId1.Location = new System.Drawing.Point(150, 298);
            this.txtId1.Name = "txtId1";
            this.txtId1.Size = new System.Drawing.Size(21, 20);
            this.txtId1.TabIndex = 27;
            // 
            // txtId3
            // 
            this.txtId3.Location = new System.Drawing.Point(150, 350);
            this.txtId3.Name = "txtId3";
            this.txtId3.Size = new System.Drawing.Size(21, 20);
            this.txtId3.TabIndex = 28;
            // 
            // txtId4
            // 
            this.txtId4.Location = new System.Drawing.Point(150, 376);
            this.txtId4.Name = "txtId4";
            this.txtId4.Size = new System.Drawing.Size(21, 20);
            this.txtId4.TabIndex = 29;
            // 
            // txtValor4
            // 
            this.txtValor4.Location = new System.Drawing.Point(182, 376);
            this.txtValor4.Name = "txtValor4";
            this.txtValor4.Size = new System.Drawing.Size(21, 20);
            this.txtValor4.TabIndex = 33;
            // 
            // txtValor3
            // 
            this.txtValor3.Location = new System.Drawing.Point(182, 350);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(21, 20);
            this.txtValor3.TabIndex = 32;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(182, 298);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(21, 20);
            this.txtValor1.TabIndex = 31;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(182, 324);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(21, 20);
            this.txtValor2.TabIndex = 30;
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(919, 620);
            this.Controls.Add(this.txtValor4);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtId4);
            this.Controls.Add(this.txtId3);
            this.Controls.Add(this.txtId1);
            this.Controls.Add(this.txtId2);
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
        private System.Windows.Forms.TextBox txtId2;
        private System.Windows.Forms.TextBox txtId1;
        private System.Windows.Forms.TextBox txtId3;
        private System.Windows.Forms.TextBox txtId4;
        private System.Windows.Forms.TextBox txtValor4;
        private System.Windows.Forms.TextBox txtValor3;
        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
    }
}