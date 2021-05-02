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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button4 = new System.Windows.Forms.Button();
            this.btnExibirPartida = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 213);
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
            this.btnExibirPartida.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExibirPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirPartida.ForeColor = System.Drawing.Color.White;
            this.btnExibirPartida.Location = new System.Drawing.Point(12, 146);
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
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(453, 347);
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
            this.btnCriar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.Color.White;
            this.btnCriar.Location = new System.Drawing.Point(12, 79);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(127, 61);
            this.btnCriar.TabIndex = 16;
            this.btnCriar.Text = "Criar nova partida";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(5, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Saguão";
            // 
            // txtListJog
            // 
            this.txtListJog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtListJog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListJog.Location = new System.Drawing.Point(618, 79);
            this.txtListJog.Multiline = true;
            this.txtListJog.Name = "txtListJog";
            this.txtListJog.ReadOnly = true;
            this.txtListJog.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtListJog.Size = new System.Drawing.Size(176, 128);
            this.txtListJog.TabIndex = 22;
            // 
            // dgvPartidas
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.ForestGreen;
            this.dgvPartidas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPartidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPartidas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPartidas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPartidas.Location = new System.Drawing.Point(155, 79);
            this.dgvPartidas.MultiSelect = false;
            this.dgvPartidas.Name = "dgvPartidas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPartidas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPartidas.Size = new System.Drawing.Size(457, 262);
            this.dgvPartidas.TabIndex = 23;
            this.dgvPartidas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPartidas_CellFormatting);
            // 
            // txtNomeJog
            // 
            this.txtNomeJog.Location = new System.Drawing.Point(311, 350);
            this.txtNomeJog.Name = "txtNomeJog";
            this.txtNomeJog.Size = new System.Drawing.Size(136, 20);
            this.txtNomeJog.TabIndex = 24;
            // 
            // txtSenhaPt
            // 
            this.txtSenhaPt.Location = new System.Drawing.Point(311, 406);
            this.txtSenhaPt.Name = "txtSenhaPt";
            this.txtSenhaPt.Size = new System.Drawing.Size(136, 20);
            this.txtSenhaPt.TabIndex = 25;
            // 
            // lblNomeJog
            // 
            this.lblNomeJog.AutoSize = true;
            this.lblNomeJog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJog.Location = new System.Drawing.Point(185, 349);
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
            this.lblSenhaPt.Location = new System.Drawing.Point(250, 408);
            this.lblSenhaPt.Name = "lblSenhaPt";
            this.lblSenhaPt.Size = new System.Drawing.Size(55, 18);
            this.lblSenhaPt.TabIndex = 27;
            this.lblSenhaPt.Text = "Senha";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(311, 380);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 20);
            this.txtId.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 380);
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
            this.btnIniciar.Location = new System.Drawing.Point(12, 280);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(127, 61);
            this.btnIniciar.TabIndex = 30;
            this.btnIniciar.Text = "Iniciar Partida";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtCorJog
            // 
            this.txtCorJog.Location = new System.Drawing.Point(710, 213);
            this.txtCorJog.Name = "txtCorJog";
            this.txtCorJog.Size = new System.Drawing.Size(78, 20);
            this.txtCorJog.TabIndex = 31;
            // 
            // txtIdJog
            // 
            this.txtIdJog.Location = new System.Drawing.Point(710, 265);
            this.txtIdJog.Name = "txtIdJog";
            this.txtIdJog.Size = new System.Drawing.Size(78, 20);
            this.txtIdJog.TabIndex = 32;
            // 
            // txtSenhaJog
            // 
            this.txtSenhaJog.Location = new System.Drawing.Point(710, 239);
            this.txtSenhaJog.Name = "txtSenhaJog";
            this.txtSenhaJog.Size = new System.Drawing.Size(78, 20);
            this.txtSenhaJog.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Id Jog.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(650, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 35;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(631, 213);
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
            this.lblVersao.Location = new System.Drawing.Point(737, 428);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(40, 13);
            this.lblVersao.TabIndex = 38;
            this.lblVersao.Text = "Versão";
            // 
            // btnTab
            // 
            this.btnTab.BackColor = System.Drawing.Color.Green;
            this.btnTab.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTab.ForeColor = System.Drawing.Color.White;
            this.btnTab.Location = new System.Drawing.Point(12, 349);
            this.btnTab.Name = "btnTab";
            this.btnTab.Size = new System.Drawing.Size(127, 61);
            this.btnTab.TabIndex = 40;
            this.btnTab.Text = "Tabuleiro";
            this.btnTab.UseVisualStyleBackColor = false;
            this.btnTab.Click += new System.EventHandler(this.btnTab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTab);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lblRetornoJogador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaJog);
            this.Controls.Add(this.txtIdJog);
            this.Controls.Add(this.txtCorJog);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblSenhaPt);
            this.Controls.Add(this.lblNomeJog);
            this.Controls.Add(this.txtSenhaPt);
            this.Controls.Add(this.txtNomeJog);
            this.Controls.Add(this.dgvPartidas);
            this.Controls.Add(this.txtListJog);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnExibirPartida);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExibirPartida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Label label1;
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
    }
}

