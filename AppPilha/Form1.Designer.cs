namespace AppPilha
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
            this.txtCapacidade = new System.Windows.Forms.TextBox();
            this.txtTopo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lstPilha = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnDesempilhar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstAux = new System.Windows.Forms.ListBox();
            this.btnRemoverAux = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capacidade:";
            // 
            // txtCapacidade
            // 
            this.txtCapacidade.Location = new System.Drawing.Point(12, 25);
            this.txtCapacidade.Name = "txtCapacidade";
            this.txtCapacidade.Size = new System.Drawing.Size(100, 20);
            this.txtCapacidade.TabIndex = 1;
            // 
            // txtTopo
            // 
            this.txtTopo.Location = new System.Drawing.Point(118, 25);
            this.txtTopo.Name = "txtTopo";
            this.txtTopo.Size = new System.Drawing.Size(58, 20);
            this.txtTopo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Topo:";
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(182, 23);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 5;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 72);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 7;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 56);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 6;
            this.lblValor.Text = "Valor:";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(121, 70);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(202, 70);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lstPilha
            // 
            this.lstPilha.FormattingEnabled = true;
            this.lstPilha.Location = new System.Drawing.Point(159, 177);
            this.lstPilha.Name = "lstPilha";
            this.lstPilha.Size = new System.Drawing.Size(67, 225);
            this.lstPilha.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pilha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Log:";
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(12, 177);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(141, 225);
            this.lstLog.TabIndex = 12;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(93, 109);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnDesempilhar
            // 
            this.btnDesempilhar.Location = new System.Drawing.Point(12, 109);
            this.btnDesempilhar.Name = "btnDesempilhar";
            this.btnDesempilhar.Size = new System.Drawing.Size(75, 23);
            this.btnDesempilhar.TabIndex = 14;
            this.btnDesempilhar.Text = "Desempilhar";
            this.btnDesempilhar.UseVisualStyleBackColor = true;
            this.btnDesempilhar.Click += new System.EventHandler(this.btnDesempilhar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Aux:";
            // 
            // lstAux
            // 
            this.lstAux.FormattingEnabled = true;
            this.lstAux.Location = new System.Drawing.Point(232, 177);
            this.lstAux.Name = "lstAux";
            this.lstAux.Size = new System.Drawing.Size(67, 225);
            this.lstAux.TabIndex = 16;
            // 
            // btnRemoverAux
            // 
            this.btnRemoverAux.Location = new System.Drawing.Point(174, 109);
            this.btnRemoverAux.Name = "btnRemoverAux";
            this.btnRemoverAux.Size = new System.Drawing.Size(103, 23);
            this.btnRemoverAux.TabIndex = 18;
            this.btnRemoverAux.Text = "Remover Aux";
            this.btnRemoverAux.UseVisualStyleBackColor = true;
            this.btnRemoverAux.Click += new System.EventHandler(this.btnRemoverAux_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 414);
            this.Controls.Add(this.btnRemoverAux);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstAux);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnDesempilhar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPilha);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.txtTopo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCapacidade);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCapacidade;
        private System.Windows.Forms.TextBox txtTopo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListBox lstPilha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnDesempilhar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstAux;
        private System.Windows.Forms.Button btnRemoverAux;
    }
}

