namespace CondoFrame
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCondôminoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarSindicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPorterioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadernoDigitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correspondênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1187, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(41, 20);
            this.lblData.Text = "Data";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.cadernoDigitalToolStripMenuItem,
            this.reclamaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1187, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarCondôminoToolStripMenuItem,
            this.cadastrarSindicoToolStripMenuItem,
            this.cadastrarPorterioToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrarCondôminoToolStripMenuItem
            // 
            this.cadastrarCondôminoToolStripMenuItem.Name = "cadastrarCondôminoToolStripMenuItem";
            this.cadastrarCondôminoToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.cadastrarCondôminoToolStripMenuItem.Text = "Cadastrar Condômino";
            this.cadastrarCondôminoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarCondôminoToolStripMenuItem_Click);
            // 
            // cadastrarSindicoToolStripMenuItem
            // 
            this.cadastrarSindicoToolStripMenuItem.Name = "cadastrarSindicoToolStripMenuItem";
            this.cadastrarSindicoToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.cadastrarSindicoToolStripMenuItem.Text = "Cadastrar Sindico";
            this.cadastrarSindicoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarSindicoToolStripMenuItem_Click);
            // 
            // cadastrarPorterioToolStripMenuItem
            // 
            this.cadastrarPorterioToolStripMenuItem.Name = "cadastrarPorterioToolStripMenuItem";
            this.cadastrarPorterioToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.cadastrarPorterioToolStripMenuItem.Text = "Cadastrar Porterio";
            this.cadastrarPorterioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarPorterioToolStripMenuItem_Click);
            // 
            // cadernoDigitalToolStripMenuItem
            // 
            this.cadernoDigitalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem,
            this.correspondênciaToolStripMenuItem});
            this.cadernoDigitalToolStripMenuItem.Name = "cadernoDigitalToolStripMenuItem";
            this.cadernoDigitalToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.cadernoDigitalToolStripMenuItem.Text = "Caderno Digital";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // correspondênciaToolStripMenuItem
            // 
            this.correspondênciaToolStripMenuItem.Name = "correspondênciaToolStripMenuItem";
            this.correspondênciaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.correspondênciaToolStripMenuItem.Text = "Correspondência";
            this.correspondênciaToolStripMenuItem.Click += new System.EventHandler(this.correspondênciaToolStripMenuItem_Click);
            // 
            // reclamaçõesToolStripMenuItem
            // 
            this.reclamaçõesToolStripMenuItem.Name = "reclamaçõesToolStripMenuItem";
            this.reclamaçõesToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.reclamaçõesToolStripMenuItem.Text = "Reclamações";
            this.reclamaçõesToolStripMenuItem.Click += new System.EventHandler(this.reclamaçõesToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 460);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 18);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Acesse o Gmail aqui";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 513);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CondoFrame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCondôminoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarSindicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPorterioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadernoDigitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correspondênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reclamaçõesToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

