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
            this.picImg1 = new System.Windows.Forms.PictureBox();
            this.picImg2 = new System.Windows.Forms.PictureBox();
            this.picImg3 = new System.Windows.Forms.PictureBox();
            this.picImg4 = new System.Windows.Forms.PictureBox();
            this.picImg5 = new System.Windows.Forms.PictureBox();
            this.picImg6 = new System.Windows.Forms.PictureBox();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.txtOrdem = new System.Windows.Forms.TextBox();
            this.txtTrilha = new System.Windows.Forms.TextBox();
            this.lblOrdem = new System.Windows.Forms.Label();
            this.lblTrilha = new System.Windows.Forms.Label();
            this.btnExbTab = new System.Windows.Forms.Button();
            this.lblExbTab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg6)).BeginInit();
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
            this.txtId2.Visible = false;
            // 
            // txtId1
            // 
            this.txtId1.Location = new System.Drawing.Point(150, 298);
            this.txtId1.Name = "txtId1";
            this.txtId1.Size = new System.Drawing.Size(21, 20);
            this.txtId1.TabIndex = 27;
            this.txtId1.Visible = false;
            // 
            // txtId3
            // 
            this.txtId3.Location = new System.Drawing.Point(150, 350);
            this.txtId3.Name = "txtId3";
            this.txtId3.Size = new System.Drawing.Size(21, 20);
            this.txtId3.TabIndex = 28;
            this.txtId3.Visible = false;
            // 
            // txtId4
            // 
            this.txtId4.Location = new System.Drawing.Point(150, 376);
            this.txtId4.Name = "txtId4";
            this.txtId4.Size = new System.Drawing.Size(21, 20);
            this.txtId4.TabIndex = 29;
            this.txtId4.Visible = false;
            // 
            // txtValor4
            // 
            this.txtValor4.Location = new System.Drawing.Point(182, 376);
            this.txtValor4.Name = "txtValor4";
            this.txtValor4.Size = new System.Drawing.Size(21, 20);
            this.txtValor4.TabIndex = 33;
            this.txtValor4.Visible = false;
            // 
            // txtValor3
            // 
            this.txtValor3.Location = new System.Drawing.Point(182, 350);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(21, 20);
            this.txtValor3.TabIndex = 32;
            this.txtValor3.Visible = false;
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(182, 298);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(21, 20);
            this.txtValor1.TabIndex = 31;
            this.txtValor1.Visible = false;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(182, 324);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(21, 20);
            this.txtValor2.TabIndex = 30;
            this.txtValor2.Visible = false;
            // 
            // picImg1
            // 
            this.picImg1.Image = global::TesteDoPI3.Properties.Resources.d1;
            this.picImg1.Location = new System.Drawing.Point(224, 3);
            this.picImg1.Name = "picImg1";
            this.picImg1.Size = new System.Drawing.Size(45, 43);
            this.picImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg1.TabIndex = 34;
            this.picImg1.TabStop = false;
            this.picImg1.Visible = false;
            // 
            // picImg2
            // 
            this.picImg2.Image = global::TesteDoPI3.Properties.Resources.d2;
            this.picImg2.Location = new System.Drawing.Point(275, 3);
            this.picImg2.Name = "picImg2";
            this.picImg2.Size = new System.Drawing.Size(45, 43);
            this.picImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg2.TabIndex = 35;
            this.picImg2.TabStop = false;
            this.picImg2.Visible = false;
            // 
            // picImg3
            // 
            this.picImg3.Image = global::TesteDoPI3.Properties.Resources.d3;
            this.picImg3.Location = new System.Drawing.Point(326, 3);
            this.picImg3.Name = "picImg3";
            this.picImg3.Size = new System.Drawing.Size(45, 43);
            this.picImg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg3.TabIndex = 36;
            this.picImg3.TabStop = false;
            this.picImg3.Visible = false;
            // 
            // picImg4
            // 
            this.picImg4.Image = global::TesteDoPI3.Properties.Resources.d4;
            this.picImg4.Location = new System.Drawing.Point(377, 3);
            this.picImg4.Name = "picImg4";
            this.picImg4.Size = new System.Drawing.Size(45, 43);
            this.picImg4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg4.TabIndex = 37;
            this.picImg4.TabStop = false;
            this.picImg4.Visible = false;
            // 
            // picImg5
            // 
            this.picImg5.Image = global::TesteDoPI3.Properties.Resources.d5;
            this.picImg5.Location = new System.Drawing.Point(428, 3);
            this.picImg5.Name = "picImg5";
            this.picImg5.Size = new System.Drawing.Size(45, 43);
            this.picImg5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg5.TabIndex = 38;
            this.picImg5.TabStop = false;
            this.picImg5.Visible = false;
            // 
            // picImg6
            // 
            this.picImg6.Image = global::TesteDoPI3.Properties.Resources.d6;
            this.picImg6.Location = new System.Drawing.Point(479, 3);
            this.picImg6.Name = "picImg6";
            this.picImg6.Size = new System.Drawing.Size(45, 43);
            this.picImg6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImg6.TabIndex = 39;
            this.picImg6.TabStop = false;
            this.picImg6.Visible = false;
            // 
            // btnMover
            // 
            this.btnMover.BackColor = System.Drawing.Color.Green;
            this.btnMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMover.ForeColor = System.Drawing.Color.White;
            this.btnMover.Location = new System.Drawing.Point(12, 65);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(89, 68);
            this.btnMover.TabIndex = 41;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = false;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.Green;
            this.btnParar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.ForeColor = System.Drawing.Color.White;
            this.btnParar.Location = new System.Drawing.Point(114, 65);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(89, 68);
            this.btnParar.TabIndex = 42;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // txtOrdem
            // 
            this.txtOrdem.Location = new System.Drawing.Point(12, 161);
            this.txtOrdem.Name = "txtOrdem";
            this.txtOrdem.Size = new System.Drawing.Size(87, 20);
            this.txtOrdem.TabIndex = 43;
            // 
            // txtTrilha
            // 
            this.txtTrilha.Location = new System.Drawing.Point(116, 161);
            this.txtTrilha.Name = "txtTrilha";
            this.txtTrilha.Size = new System.Drawing.Size(87, 20);
            this.txtTrilha.TabIndex = 44;
            // 
            // lblOrdem
            // 
            this.lblOrdem.AutoSize = true;
            this.lblOrdem.Location = new System.Drawing.Point(37, 145);
            this.lblOrdem.Name = "lblOrdem";
            this.lblOrdem.Size = new System.Drawing.Size(38, 13);
            this.lblOrdem.TabIndex = 45;
            this.lblOrdem.Text = "Ordem";
            // 
            // lblTrilha
            // 
            this.lblTrilha.AutoSize = true;
            this.lblTrilha.Location = new System.Drawing.Point(138, 145);
            this.lblTrilha.Name = "lblTrilha";
            this.lblTrilha.Size = new System.Drawing.Size(33, 13);
            this.lblTrilha.TabIndex = 46;
            this.lblTrilha.Text = "Trilha";
            // 
            // btnExbTab
            // 
            this.btnExbTab.BackColor = System.Drawing.Color.Green;
            this.btnExbTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExbTab.ForeColor = System.Drawing.Color.White;
            this.btnExbTab.Location = new System.Drawing.Point(224, 65);
            this.btnExbTab.Name = "btnExbTab";
            this.btnExbTab.Size = new System.Drawing.Size(96, 68);
            this.btnExbTab.TabIndex = 47;
            this.btnExbTab.Text = "Exibir Tabuleiro";
            this.btnExbTab.UseVisualStyleBackColor = false;
            this.btnExbTab.Click += new System.EventHandler(this.btnExbTab_Click);
            // 
            // lblExbTab
            // 
            this.lblExbTab.AutoSize = true;
            this.lblExbTab.Location = new System.Drawing.Point(16, 201);
            this.lblExbTab.Name = "lblExbTab";
            this.lblExbTab.Size = new System.Drawing.Size(0, 13);
            this.lblExbTab.TabIndex = 48;
            // 
            // Tabuleiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(919, 620);
            this.Controls.Add(this.lblExbTab);
            this.Controls.Add(this.btnExbTab);
            this.Controls.Add(this.lblTrilha);
            this.Controls.Add(this.lblOrdem);
            this.Controls.Add(this.txtTrilha);
            this.Controls.Add(this.txtOrdem);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.picImg6);
            this.Controls.Add(this.picImg5);
            this.Controls.Add(this.picImg4);
            this.Controls.Add(this.picImg3);
            this.Controls.Add(this.picImg2);
            this.Controls.Add(this.picImg1);
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
            this.Text = "Mover";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImg6)).EndInit();
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
        private System.Windows.Forms.PictureBox picImg1;
        private System.Windows.Forms.PictureBox picImg2;
        private System.Windows.Forms.PictureBox picImg3;
        private System.Windows.Forms.PictureBox picImg4;
        private System.Windows.Forms.PictureBox picImg5;
        private System.Windows.Forms.PictureBox picImg6;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.TextBox txtOrdem;
        private System.Windows.Forms.TextBox txtTrilha;
        private System.Windows.Forms.Label lblOrdem;
        private System.Windows.Forms.Label lblTrilha;
        private System.Windows.Forms.Button btnExbTab;
        private System.Windows.Forms.Label lblExbTab;
    }
}