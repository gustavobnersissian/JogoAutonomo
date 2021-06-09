namespace TesteDoPI3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button4 = new System.Windows.Forms.Button();
            this.btnExibirPartida = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.txtListJog = new System.Windows.Forms.TextBox();
            this.dgvPartidas = new System.Windows.Forms.DataGridView();
            this.txtNomeJog = new System.Windows.Forms.TextBox();
            this.txtSenhaPt = new System.Windows.Forms.TextBox();
            this.lblNomeJog = new System.Windows.Forms.Label();
            this.lblSenhaPt = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtCorJog = new System.Windows.Forms.TextBox();
            this.txtIdJog = new System.Windows.Forms.TextBox();
            this.txtSenhaJog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRetornoJogador = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.btnTab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(9, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 61);
            this.button4.TabIndex = 20;
            this.button4.Text = "Mostrar jogadores";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExibirPartida
            // 
            this.btnExibirPartida.BackColor = System.Drawing.Color.Green;
            this.btnExibirPartida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExibirPartida.BackgroundImage")));
            this.btnExibirPartida.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExibirPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirPartida.ForeColor = System.Drawing.Color.White;
            this.btnExibirPartida.Location = new System.Drawing.Point(9, 156);
            this.btnExibirPartida.Name = "btnExibirPartida";
            this.btnExibirPartida.Size = new System.Drawing.Size(127, 61);
            this.btnExibirPartida.TabIndex = 19;
            this.btnExibirPartida.Text = "Exibir partidas";
            this.btnExibirPartida.UseVisualStyleBackColor = false;
            this.btnExibirPartida.Click += new System.EventHandler(this.btnExibirPartida_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(287, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 79);
            this.button1.TabIndex = 17;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.Green;
            this.btnCriar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCriar.BackgroundImage")));
            this.btnCriar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.Color.White;
            this.btnCriar.Location = new System.Drawing.Point(9, 88);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(127, 61);
            this.btnCriar.TabIndex = 16;
            this.btnCriar.Text = "Criar nova partida";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txtListJog
            // 
            this.txtListJog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtListJog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListJog.Location = new System.Drawing.Point(3, 46);
            this.txtListJog.Multiline = true;
            this.txtListJog.Name = "txtListJog";
            this.txtListJog.ReadOnly = true;
            this.txtListJog.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtListJog.Size = new System.Drawing.Size(173, 169);
            this.txtListJog.TabIndex = 22;
            // 
            // dgvPartidas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPartidas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPartidas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPartidas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPartidas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPartidas.Location = new System.Drawing.Point(5, 46);
            this.dgvPartidas.MultiSelect = false;
            this.dgvPartidas.Name = "dgvPartidas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPartidas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartidas.Size = new System.Drawing.Size(446, 281);
            this.dgvPartidas.TabIndex = 23;
            this.dgvPartidas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPartidas_CellFormatting);
            // 
            // txtNomeJog
            // 
            this.txtNomeJog.Location = new System.Drawing.Point(142, 341);
            this.txtNomeJog.Name = "txtNomeJog";
            this.txtNomeJog.Size = new System.Drawing.Size(136, 20);
            this.txtNomeJog.TabIndex = 24;
            // 
            // txtSenhaPt
            // 
            this.txtSenhaPt.Location = new System.Drawing.Point(142, 397);
            this.txtSenhaPt.Name = "txtSenhaPt";
            this.txtSenhaPt.Size = new System.Drawing.Size(136, 20);
            this.txtSenhaPt.TabIndex = 25;
            // 
            // lblNomeJog
            // 
            this.lblNomeJog.AutoSize = true;
            this.lblNomeJog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJog.Location = new System.Drawing.Point(16, 340);
            this.lblNomeJog.Name = "lblNomeJog";
            this.lblNomeJog.Size = new System.Drawing.Size(120, 18);
            this.lblNomeJog.TabIndex = 26;
            this.lblNomeJog.Text = "Nome Jogador";
            // 
            // lblSenhaPt
            // 
            this.lblSenhaPt.AutoSize = true;
            this.lblSenhaPt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSenhaPt.Location = new System.Drawing.Point(81, 399);
            this.lblSenhaPt.Name = "lblSenhaPt";
            this.lblSenhaPt.Size = new System.Drawing.Size(55, 18);
            this.lblSenhaPt.TabIndex = 27;
            this.lblSenhaPt.Text = "Senha";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(142, 371);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 20);
            this.txtId.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "ID";
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Red;
            this.btnIniciar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(9, 381);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(127, 61);
            this.btnIniciar.TabIndex = 30;
            this.btnIniciar.Text = "Iniciar Partida";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtCorJog
            // 
            this.txtCorJog.Location = new System.Drawing.Point(92, 222);
            this.txtCorJog.Name = "txtCorJog";
            this.txtCorJog.Size = new System.Drawing.Size(78, 20);
            this.txtCorJog.TabIndex = 31;
            // 
            // txtIdJog
            // 
            this.txtIdJog.Location = new System.Drawing.Point(92, 274);
            this.txtIdJog.Name = "txtIdJog";
            this.txtIdJog.Size = new System.Drawing.Size(78, 20);
            this.txtIdJog.TabIndex = 32;
            // 
            // txtSenhaJog
            // 
            this.txtSenhaJog.Location = new System.Drawing.Point(92, 248);
            this.txtSenhaJog.Name = "txtSenhaJog";
            this.txtSenhaJog.Size = new System.Drawing.Size(78, 20);
            this.txtSenhaJog.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Id Jog.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Cor Jog.";
            // 
            // lblRetornoJogador
            // 
            this.lblRetornoJogador.AutoSize = true;
            this.lblRetornoJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetornoJogador.ForeColor = System.Drawing.Color.Red;
            this.lblRetornoJogador.Location = new System.Drawing.Point(152, 49);
            this.lblRetornoJogador.Name = "lblRetornoJogador";
            this.lblRetornoJogador.Size = new System.Drawing.Size(0, 24);
            this.lblRetornoJogador.TabIndex = 37;
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(104, 416);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(40, 13);
            this.lblVersao.TabIndex = 38;
            this.lblVersao.Text = "Versão";
            // 
            // btnTab
            // 
            this.btnTab.BackColor = System.Drawing.Color.Green;
            this.btnTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTab.BackgroundImage")));
            this.btnTab.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTab.ForeColor = System.Drawing.Color.White;
            this.btnTab.Location = new System.Drawing.Point(9, 292);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(127, 61);
            this.btnTab.TabIndex = 40;
            this.btnTab.Text = "Tabuleiro";
            this.btnTab.UseVisualStyleBackColor = false;
            this.btnTab.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 43);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lobby";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::TesteDoPI3.Properties.Resources.teste2;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnTab);
            this.groupBox1.Controls.Add(this.btnCriar);
            this.groupBox1.Controls.Add(this.btnExibirPartida);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 466);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::TesteDoPI3.Properties.Resources.teste2;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.lblRetorno);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtNomeJog);
            this.groupBox2.Controls.Add(this.txtSenhaPt);
            this.groupBox2.Controls.Add(this.lblNomeJog);
            this.groupBox2.Controls.Add(this.dgvPartidas);
            this.groupBox2.Controls.Add(this.lblSenhaPt);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(160, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 439);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            // 
            // lblRetorno
            // 
            this.lblRetorno.AutoSize = true;
            this.lblRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetorno.ForeColor = System.Drawing.Color.Red;
            this.lblRetorno.Location = new System.Drawing.Point(9, 16);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(0, 24);
            this.lblRetorno.TabIndex = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::TesteDoPI3.Properties.Resources.teste2;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.txtListJog);
            this.groupBox3.Controls.Add(this.txtCorJog);
            this.groupBox3.Controls.Add(this.txtIdJog);
            this.groupBox3.Controls.Add(this.lblVersao);
            this.groupBox3.Controls.Add(this.txtSenhaJog);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(619, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 439);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TesteDoPI3.Properties.Resources.teste;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRetornoJogador);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExibirPartida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox txtListJog;
        private System.Windows.Forms.DataGridView dgvPartidas;
        private System.Windows.Forms.TextBox txtNomeJog;
        private System.Windows.Forms.TextBox txtSenhaPt;
        private System.Windows.Forms.Label lblNomeJog;
        private System.Windows.Forms.Label lblSenhaPt;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtCorJog;
        private System.Windows.Forms.TextBox txtIdJog;
        private System.Windows.Forms.TextBox txtSenhaJog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRetornoJogador;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblRetorno;
    }
}

