namespace SisOrganizador
{
    partial class FormOrganizador
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalvarConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.carregarConfiguraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tópicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoConfigurarPastasEFormatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mskExtensao = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbIntervalo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btDestino = new System.Windows.Forms.Button();
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btOrigem = new System.Windows.Forms.Button();
            this.tbOrigem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalvarConfig,
            this.carregarConfiguraçõesToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // mnuSalvarConfig
            // 
            this.mnuSalvarConfig.Name = "mnuSalvarConfig";
            this.mnuSalvarConfig.Size = new System.Drawing.Size(192, 22);
            this.mnuSalvarConfig.Text = "Salvar configuração";
            this.mnuSalvarConfig.Click += new System.EventHandler(this.mnuSalvarConfig_Click);
            // 
            // carregarConfiguraçõesToolStripMenuItem
            // 
            this.carregarConfiguraçõesToolStripMenuItem.Name = "carregarConfiguraçõesToolStripMenuItem";
            this.carregarConfiguraçõesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.carregarConfiguraçõesToolStripMenuItem.Text = "Carregar configuração";
            this.carregarConfiguraçõesToolStripMenuItem.Click += new System.EventHandler(this.carregarConfiguraçõesToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.tópicosToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // tópicosToolStripMenuItem
            // 
            this.tópicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoConfigurarPastasEFormatosToolStripMenuItem});
            this.tópicosToolStripMenuItem.Name = "tópicosToolStripMenuItem";
            this.tópicosToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.tópicosToolStripMenuItem.Text = "Tópicos";
            // 
            // comoConfigurarPastasEFormatosToolStripMenuItem
            // 
            this.comoConfigurarPastasEFormatosToolStripMenuItem.Name = "comoConfigurarPastasEFormatosToolStripMenuItem";
            this.comoConfigurarPastasEFormatosToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.comoConfigurarPastasEFormatosToolStripMenuItem.Text = "Como configurar pastas e formatos";
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progressBar,
            this.toolStripStatusLabel2,
            this.lblStatus});
            this.statusBar.Location = new System.Drawing.Point(0, 261);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(579, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusBar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskExtensao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbIntervalo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btDestino);
            this.groupBox1.Controls.Add(this.tbDestino);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btOrigem);
            this.groupBox1.Controls.Add(this.tbOrigem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 197);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definições";
            // 
            // mskExtensao
            // 
            this.mskExtensao.Location = new System.Drawing.Point(129, 157);
            this.mskExtensao.Name = "mskExtensao";
            this.mskExtensao.Size = new System.Drawing.Size(237, 20);
            this.mskExtensao.TabIndex = 10;
            this.mskExtensao.Text = "*.dav";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Extensão do arquivo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "&Organizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbIntervalo
            // 
            this.tbIntervalo.Location = new System.Drawing.Point(35, 159);
            this.tbIntervalo.Name = "tbIntervalo";
            this.tbIntervalo.Size = new System.Drawing.Size(63, 20);
            this.tbIntervalo.TabIndex = 7;
            this.tbIntervalo.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Intervalo";
            // 
            // btDestino
            // 
            this.btDestino.Location = new System.Drawing.Point(372, 99);
            this.btDestino.Name = "btDestino";
            this.btDestino.Size = new System.Drawing.Size(114, 29);
            this.btDestino.TabIndex = 5;
            this.btDestino.Text = "Pasta de destino";
            this.btDestino.UseVisualStyleBackColor = true;
            this.btDestino.Click += new System.EventHandler(this.btDestino_Click);
            // 
            // tbDestino
            // 
            this.tbDestino.Location = new System.Drawing.Point(32, 104);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(334, 20);
            this.tbDestino.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pasta de destino:";
            // 
            // btOrigem
            // 
            this.btOrigem.Location = new System.Drawing.Point(372, 49);
            this.btOrigem.Name = "btOrigem";
            this.btOrigem.Size = new System.Drawing.Size(114, 29);
            this.btOrigem.TabIndex = 2;
            this.btOrigem.Text = "Pasta de origem";
            this.btOrigem.UseVisualStyleBackColor = true;
            this.btOrigem.Click += new System.EventHandler(this.btOrigem_Click);
            // 
            // tbOrigem
            // 
            this.tbOrigem.Location = new System.Drawing.Point(32, 54);
            this.tbOrigem.Name = "tbOrigem";
            this.tbOrigem.Size = new System.Drawing.Size(334, 20);
            this.tbOrigem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origem dos arquivos:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // progressBar
            // 
            this.progressBar.AutoSize = false;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Step = 1;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel2.Text = "Mensagem:";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // FormOrganizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 283);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormOrganizador";
            this.Text = "Sistema Organizador de Pastas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSalvarConfig;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tópicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoConfigurarPastasEFormatosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btDestino;
        private System.Windows.Forms.TextBox tbDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btOrigem;
        private System.Windows.Forms.TextBox tbOrigem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIntervalo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem carregarConfiguraçõesToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mskExtensao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

