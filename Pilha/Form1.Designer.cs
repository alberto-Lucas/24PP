namespace Pilha
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPilha = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCapacidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTopo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lstDesPilha = new System.Windows.Forms.ListBox();
            this.btnDespilhar = new System.Windows.Forms.Button();
            this.btnAutomatizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(12, 68);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnInserir
            // 
            this.btnInserir.Enabled = false;
            this.btnInserir.Location = new System.Drawing.Point(118, 66);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(12, 117);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(202, 212);
            this.lstLog.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log:";
            // 
            // lstPilha
            // 
            this.lstPilha.FormattingEnabled = true;
            this.lstPilha.Location = new System.Drawing.Point(220, 117);
            this.lstPilha.Name = "lstPilha";
            this.lstPilha.Size = new System.Drawing.Size(63, 212);
            this.lstPilha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pilha:";
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Location = new System.Drawing.Point(12, 25);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidade.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Capacidade:";
            // 
            // txtTopo
            // 
            this.txtTopo.Location = new System.Drawing.Point(118, 25);
            this.txtTopo.Name = "txtTopo";
            this.txtTopo.ReadOnly = true;
            this.txtTopo.Size = new System.Drawing.Size(71, 20);
            this.txtTopo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Topo:";
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(195, 23);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 11;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Enabled = false;
            this.btnRemover.Location = new System.Drawing.Point(196, 66);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "DesPilha:";
            // 
            // lstDesPilha
            // 
            this.lstDesPilha.FormattingEnabled = true;
            this.lstDesPilha.Location = new System.Drawing.Point(289, 117);
            this.lstDesPilha.Name = "lstDesPilha";
            this.lstDesPilha.Size = new System.Drawing.Size(63, 212);
            this.lstDesPilha.TabIndex = 13;
            // 
            // btnDespilhar
            // 
            this.btnDespilhar.Enabled = false;
            this.btnDespilhar.Location = new System.Drawing.Point(277, 66);
            this.btnDespilhar.Name = "btnDespilhar";
            this.btnDespilhar.Size = new System.Drawing.Size(75, 23);
            this.btnDespilhar.TabIndex = 15;
            this.btnDespilhar.Text = "Despilhar";
            this.btnDespilhar.UseVisualStyleBackColor = true;
            this.btnDespilhar.Click += new System.EventHandler(this.btnDespilhar_Click);
            // 
            // btnAutomatizar
            // 
            this.btnAutomatizar.Location = new System.Drawing.Point(277, 23);
            this.btnAutomatizar.Name = "btnAutomatizar";
            this.btnAutomatizar.Size = new System.Drawing.Size(75, 23);
            this.btnAutomatizar.TabIndex = 16;
            this.btnAutomatizar.Text = "Automatizar";
            this.btnAutomatizar.UseVisualStyleBackColor = true;
            this.btnAutomatizar.Click += new System.EventHandler(this.btnAutomatizar_ClickAsync);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 339);
            this.Controls.Add(this.btnAutomatizar);
            this.Controls.Add(this.btnDespilhar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstDesPilha);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.txtTopo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCapacidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPilha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pilha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPilha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCapacidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTopo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstDesPilha;
        private System.Windows.Forms.Button btnDespilhar;
        private System.Windows.Forms.Button btnAutomatizar;
    }
}

