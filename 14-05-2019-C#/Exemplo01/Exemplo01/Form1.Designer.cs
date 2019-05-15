namespace Exemplo01
{
    partial class Exemplo01
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.datas = new System.Windows.Forms.TabPage();
            this.lstData = new System.Windows.Forms.ListBox();
            this.lstEvento = new System.Windows.Forms.ListBox();
            this.lblData = new System.Windows.Forms.Label();
            this.mskData = new System.Windows.Forms.MaskedTextBox();
            this.lblEvento = new System.Windows.Forms.Label();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.votacao = new System.Windows.Forms.TabPage();
            this.grpResultado = new System.Windows.Forms.GroupBox();
            this.lblQtdCandidato03 = new System.Windows.Forms.Label();
            this.lblQtdCandidato02 = new System.Windows.Forms.Label();
            this.lblQtdCandidato01 = new System.Windows.Forms.Label();
            this.lblCandidato03 = new System.Windows.Forms.Label();
            this.lblCandidato02 = new System.Windows.Forms.Label();
            this.lblCandidato01 = new System.Windows.Forms.Label();
            this.grpCandidatos = new System.Windows.Forms.GroupBox();
            this.btnVotar = new System.Windows.Forms.Button();
            this.lstCandidatos = new System.Windows.Forms.ListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.datas.SuspendLayout();
            this.votacao.SuspendLayout();
            this.grpResultado.SuspendLayout();
            this.grpCandidatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.datas);
            this.tabControl1.Controls.Add(this.votacao);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // datas
            // 
            this.datas.Controls.Add(this.lstData);
            this.datas.Controls.Add(this.lstEvento);
            this.datas.Controls.Add(this.lblData);
            this.datas.Controls.Add(this.mskData);
            this.datas.Controls.Add(this.lblEvento);
            this.datas.Controls.Add(this.txtEvento);
            this.datas.Location = new System.Drawing.Point(4, 22);
            this.datas.Name = "datas";
            this.datas.Padding = new System.Windows.Forms.Padding(3);
            this.datas.Size = new System.Drawing.Size(385, 322);
            this.datas.TabIndex = 0;
            this.datas.Text = "Datas";
            this.datas.UseVisualStyleBackColor = true;
            // 
            // lstData
            // 
            this.lstData.FormattingEnabled = true;
            this.lstData.Location = new System.Drawing.Point(227, 62);
            this.lstData.Name = "lstData";
            this.lstData.Size = new System.Drawing.Size(152, 251);
            this.lstData.TabIndex = 5;
            this.lstData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstData_MouseClick);
            // 
            // lstEvento
            // 
            this.lstEvento.FormattingEnabled = true;
            this.lstEvento.Location = new System.Drawing.Point(3, 62);
            this.lstEvento.Name = "lstEvento";
            this.lstEvento.Size = new System.Drawing.Size(218, 251);
            this.lstEvento.TabIndex = 4;
            this.lstEvento.Click += new System.EventHandler(this.lstEvento_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(0, 39);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data:";
            // 
            // mskData
            // 
            this.mskData.Location = new System.Drawing.Point(56, 36);
            this.mskData.Mask = "00/00/0000";
            this.mskData.Name = "mskData";
            this.mskData.Size = new System.Drawing.Size(67, 20);
            this.mskData.TabIndex = 0;
            this.mskData.ValidatingType = typeof(System.DateTime);
            this.mskData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskData_KeyPress);
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(0, 13);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(44, 13);
            this.lblEvento.TabIndex = 2;
            this.lblEvento.Text = "Evento:";
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(56, 10);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(323, 20);
            this.txtEvento.TabIndex = 1;
            this.txtEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEvento_KeyPress);
            // 
            // votacao
            // 
            this.votacao.Controls.Add(this.btnLimpar);
            this.votacao.Controls.Add(this.grpResultado);
            this.votacao.Controls.Add(this.grpCandidatos);
            this.votacao.Location = new System.Drawing.Point(4, 22);
            this.votacao.Name = "votacao";
            this.votacao.Padding = new System.Windows.Forms.Padding(3);
            this.votacao.Size = new System.Drawing.Size(385, 322);
            this.votacao.TabIndex = 1;
            this.votacao.Text = "Votação";
            this.votacao.UseVisualStyleBackColor = true;
            // 
            // grpResultado
            // 
            this.grpResultado.Controls.Add(this.lblQtdCandidato03);
            this.grpResultado.Controls.Add(this.lblQtdCandidato02);
            this.grpResultado.Controls.Add(this.lblQtdCandidato01);
            this.grpResultado.Controls.Add(this.lblCandidato03);
            this.grpResultado.Controls.Add(this.lblCandidato02);
            this.grpResultado.Controls.Add(this.lblCandidato01);
            this.grpResultado.Location = new System.Drawing.Point(6, 114);
            this.grpResultado.Name = "grpResultado";
            this.grpResultado.Size = new System.Drawing.Size(373, 68);
            this.grpResultado.TabIndex = 1;
            this.grpResultado.TabStop = false;
            this.grpResultado.Text = "Resultado";
            // 
            // lblQtdCandidato03
            // 
            this.lblQtdCandidato03.AutoSize = true;
            this.lblQtdCandidato03.Location = new System.Drawing.Point(86, 46);
            this.lblQtdCandidato03.Name = "lblQtdCandidato03";
            this.lblQtdCandidato03.Size = new System.Drawing.Size(13, 13);
            this.lblQtdCandidato03.TabIndex = 5;
            this.lblQtdCandidato03.Text = "0";
            // 
            // lblQtdCandidato02
            // 
            this.lblQtdCandidato02.AutoSize = true;
            this.lblQtdCandidato02.Location = new System.Drawing.Point(86, 33);
            this.lblQtdCandidato02.Name = "lblQtdCandidato02";
            this.lblQtdCandidato02.Size = new System.Drawing.Size(13, 13);
            this.lblQtdCandidato02.TabIndex = 4;
            this.lblQtdCandidato02.Text = "0";
            // 
            // lblQtdCandidato01
            // 
            this.lblQtdCandidato01.AutoSize = true;
            this.lblQtdCandidato01.Location = new System.Drawing.Point(86, 20);
            this.lblQtdCandidato01.Name = "lblQtdCandidato01";
            this.lblQtdCandidato01.Size = new System.Drawing.Size(13, 13);
            this.lblQtdCandidato01.TabIndex = 3;
            this.lblQtdCandidato01.Text = "0";
            // 
            // lblCandidato03
            // 
            this.lblCandidato03.AutoSize = true;
            this.lblCandidato03.Location = new System.Drawing.Point(7, 46);
            this.lblCandidato03.Name = "lblCandidato03";
            this.lblCandidato03.Size = new System.Drawing.Size(70, 13);
            this.lblCandidato03.TabIndex = 2;
            this.lblCandidato03.Text = "Candidato 03";
            // 
            // lblCandidato02
            // 
            this.lblCandidato02.AutoSize = true;
            this.lblCandidato02.Location = new System.Drawing.Point(7, 33);
            this.lblCandidato02.Name = "lblCandidato02";
            this.lblCandidato02.Size = new System.Drawing.Size(73, 13);
            this.lblCandidato02.TabIndex = 1;
            this.lblCandidato02.Text = "Candidato 02:";
            // 
            // lblCandidato01
            // 
            this.lblCandidato01.AutoSize = true;
            this.lblCandidato01.Location = new System.Drawing.Point(7, 20);
            this.lblCandidato01.Name = "lblCandidato01";
            this.lblCandidato01.Size = new System.Drawing.Size(73, 13);
            this.lblCandidato01.TabIndex = 0;
            this.lblCandidato01.Text = "Candidato 01:";
            // 
            // grpCandidatos
            // 
            this.grpCandidatos.Controls.Add(this.btnVotar);
            this.grpCandidatos.Controls.Add(this.lstCandidatos);
            this.grpCandidatos.Location = new System.Drawing.Point(6, 6);
            this.grpCandidatos.Name = "grpCandidatos";
            this.grpCandidatos.Size = new System.Drawing.Size(373, 102);
            this.grpCandidatos.TabIndex = 0;
            this.grpCandidatos.TabStop = false;
            this.grpCandidatos.Text = "Candidatos";
            // 
            // btnVotar
            // 
            this.btnVotar.Location = new System.Drawing.Point(7, 69);
            this.btnVotar.Name = "btnVotar";
            this.btnVotar.Size = new System.Drawing.Size(360, 23);
            this.btnVotar.TabIndex = 1;
            this.btnVotar.Text = "Votar";
            this.btnVotar.UseVisualStyleBackColor = true;
            this.btnVotar.Click += new System.EventHandler(this.btnVotar_Click);
            // 
            // lstCandidatos
            // 
            this.lstCandidatos.FormattingEnabled = true;
            this.lstCandidatos.Items.AddRange(new object[] {
            "Candidato 01",
            "Candidato 02",
            "Candidato 03"});
            this.lstCandidatos.Location = new System.Drawing.Point(7, 20);
            this.lstCandidatos.Name = "lstCandidatos";
            this.lstCandidatos.Size = new System.Drawing.Size(360, 43);
            this.lstCandidatos.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(6, 189);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(373, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Exemplo01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 372);
            this.Controls.Add(this.tabControl1);
            this.Name = "Exemplo01";
            this.Text = "Exemplo 001";
            this.Load += new System.EventHandler(this.Exemplo01_Load);
            this.tabControl1.ResumeLayout(false);
            this.datas.ResumeLayout(false);
            this.datas.PerformLayout();
            this.votacao.ResumeLayout(false);
            this.grpResultado.ResumeLayout(false);
            this.grpResultado.PerformLayout();
            this.grpCandidatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage datas;
        private System.Windows.Forms.ListBox lstData;
        private System.Windows.Forms.ListBox lstEvento;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.MaskedTextBox mskData;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.TabPage votacao;
        private System.Windows.Forms.GroupBox grpResultado;
        private System.Windows.Forms.Label lblQtdCandidato03;
        private System.Windows.Forms.Label lblQtdCandidato02;
        private System.Windows.Forms.Label lblQtdCandidato01;
        private System.Windows.Forms.Label lblCandidato03;
        private System.Windows.Forms.Label lblCandidato02;
        private System.Windows.Forms.Label lblCandidato01;
        private System.Windows.Forms.GroupBox grpCandidatos;
        private System.Windows.Forms.Button btnVotar;
        private System.Windows.Forms.ListBox lstCandidatos;
        private System.Windows.Forms.Button btnLimpar;
    }
}

