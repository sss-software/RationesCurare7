﻿namespace RationesCurare7.UI.Forms
{
    partial class fMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Gestione casse", 13, 13);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("(F9) Cassaforte", 6, 6);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("(F12) Salvadanaio", 21, 21);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("(F4) Portafoglio", 19, 19);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("(F1) Dare", 9, 9);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("(F2) Avere", 2, 2);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("(F5) Saldo", 20, 20);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Movimenti Periodici", 17, 17);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("(Alt +1) Casse", 5, 5, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("(F3) Cerca", 11, 11);
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("(F10) Torta", 18, 18);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("(F11) Grafico", 12, 12);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Grafico a linee", 25, 25);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("(F6) Calendario", 4, 4);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("(F7) Calcolatrice", 3, 3);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Macro aree", 14, 14);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Controlla movimenti periodici", 8, 8);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Controlla promemoria", 7, 7);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("(Alt + 2) Strumenti", 23, 23, new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("(F8) Opzioni DB", 10, 10);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Cosa ne pensi?", 15, 15);
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Novità", 22, 22);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("About", 0, 0);
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("(Alt + 3) Opzioni", 16, 16, new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.pLeft = new System.Windows.Forms.Panel();
            this.cAlbero = new System.Windows.Forms.TreeView();
            this.ilAlbero = new System.Windows.Forms.ImageList(this.components);
            this.cUtente1 = new RationesCurare7.UI.Controlli.cUtente();
            this.tcSchede = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilTabs = new System.Windows.Forms.ImageList(this.components);
            this.pQuickInserimento = new System.Windows.Forms.Panel();
            this.bNuovoGiroconto = new System.Windows.Forms.Button();
            this.bNuovoMovimento = new System.Windows.Forms.Button();
            this.pLeft.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.pQuickInserimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // pLeft
            // 
            this.pLeft.Controls.Add(this.cAlbero);
            this.pLeft.Controls.Add(this.cUtente1);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeft.Location = new System.Drawing.Point(0, 0);
            this.pLeft.Name = "pLeft";
            this.pLeft.Size = new System.Drawing.Size(300, 661);
            this.pLeft.TabIndex = 5;
            // 
            // cAlbero
            // 
            this.cAlbero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cAlbero.FullRowSelect = true;
            this.cAlbero.HideSelection = false;
            this.cAlbero.ImageIndex = 0;
            this.cAlbero.ImageList = this.ilAlbero;
            this.cAlbero.Location = new System.Drawing.Point(0, 70);
            this.cAlbero.Name = "cAlbero";
            treeNode1.ImageIndex = 13;
            treeNode1.Name = "nGestioneCasse";
            treeNode1.SelectedImageIndex = 13;
            treeNode1.Text = "Gestione casse";
            treeNode2.ImageIndex = 6;
            treeNode2.Name = "nCassaforte";
            treeNode2.SelectedImageIndex = 6;
            treeNode2.Tag = "Cassaforte";
            treeNode2.Text = "(F9) Cassaforte";
            treeNode3.ImageIndex = 21;
            treeNode3.Name = "nSalvadanaio";
            treeNode3.SelectedImageIndex = 21;
            treeNode3.Tag = "Salvadanaio";
            treeNode3.Text = "(F12) Salvadanaio";
            treeNode4.ImageIndex = 19;
            treeNode4.Name = "nPortafoglio";
            treeNode4.SelectedImageIndex = 19;
            treeNode4.Tag = "Portafogli";
            treeNode4.Text = "(F4) Portafoglio";
            treeNode5.ImageIndex = 9;
            treeNode5.Name = "nDare";
            treeNode5.SelectedImageIndex = 9;
            treeNode5.Tag = "Dare";
            treeNode5.Text = "(F1) Dare";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "nAvere";
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Tag = "Avere";
            treeNode6.Text = "(F2) Avere";
            treeNode7.ImageIndex = 20;
            treeNode7.Name = "nSaldo";
            treeNode7.SelectedImageIndex = 20;
            treeNode7.Tag = "Saldo";
            treeNode7.Text = "(F5) Saldo";
            treeNode8.ImageIndex = 17;
            treeNode8.Name = "nMovimentiPeriodici";
            treeNode8.SelectedImageIndex = 17;
            treeNode8.Text = "Movimenti Periodici";
            treeNode9.ImageIndex = 5;
            treeNode9.Name = "nCasse";
            treeNode9.SelectedImageIndex = 5;
            treeNode9.Text = "(Alt +1) Casse";
            treeNode10.ImageIndex = 11;
            treeNode10.Name = "nCerca";
            treeNode10.SelectedImageIndex = 11;
            treeNode10.Text = "(F3) Cerca";
            treeNode11.ImageIndex = 18;
            treeNode11.Name = "nTorta";
            treeNode11.SelectedImageIndex = 18;
            treeNode11.Text = "(F10) Torta";
            treeNode12.ImageIndex = 12;
            treeNode12.Name = "nGrafico";
            treeNode12.SelectedImageIndex = 12;
            treeNode12.Text = "(F11) Grafico";
            treeNode13.ImageIndex = 25;
            treeNode13.Name = "nGraficoSpline";
            treeNode13.SelectedImageIndex = 25;
            treeNode13.Text = "Grafico a linee";
            treeNode14.ImageIndex = 4;
            treeNode14.Name = "nCalendario";
            treeNode14.SelectedImageIndex = 4;
            treeNode14.Text = "(F6) Calendario";
            treeNode15.ImageIndex = 3;
            treeNode15.Name = "nCalcolatrice";
            treeNode15.SelectedImageIndex = 3;
            treeNode15.Text = "(F7) Calcolatrice";
            treeNode16.ImageIndex = 14;
            treeNode16.Name = "nMacroAree";
            treeNode16.SelectedImageIndex = 14;
            treeNode16.Text = "Macro aree";
            treeNode17.ImageIndex = 8;
            treeNode17.Name = "nControllaMovimentiPeriodici";
            treeNode17.SelectedImageIndex = 8;
            treeNode17.Text = "Controlla movimenti periodici";
            treeNode18.ImageIndex = 7;
            treeNode18.Name = "nControllaPromemoria";
            treeNode18.SelectedImageIndex = 7;
            treeNode18.Text = "Controlla promemoria";
            treeNode19.ImageIndex = 23;
            treeNode19.Name = "nStrumenti";
            treeNode19.SelectedImageIndex = 23;
            treeNode19.Text = "(Alt + 2) Strumenti";
            treeNode20.ImageIndex = 10;
            treeNode20.Name = "nOpzioniDB";
            treeNode20.SelectedImageIndex = 10;
            treeNode20.Text = "(F8) Opzioni DB";
            treeNode21.ImageIndex = 15;
            treeNode21.Name = "nCosaNePensi";
            treeNode21.SelectedImageIndex = 15;
            treeNode21.Text = "Cosa ne pensi?";
            treeNode22.ImageIndex = 22;
            treeNode22.Name = "nNovita";
            treeNode22.SelectedImageIndex = 22;
            treeNode22.Text = "Novità";
            treeNode23.ImageIndex = 0;
            treeNode23.Name = "nAbout";
            treeNode23.SelectedImageIndex = 0;
            treeNode23.Text = "About";
            treeNode24.ImageIndex = 16;
            treeNode24.Name = "nOpzioni";
            treeNode24.SelectedImageIndex = 16;
            treeNode24.Text = "(Alt + 3) Opzioni";
            this.cAlbero.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode19,
            treeNode24});
            this.cAlbero.SelectedImageIndex = 0;
            this.cAlbero.Size = new System.Drawing.Size(300, 591);
            this.cAlbero.TabIndex = 7;
            this.cAlbero.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.advTree1_NodeMouseClick);
            // 
            // ilAlbero
            // 
            this.ilAlbero.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilAlbero.ImageStream")));
            this.ilAlbero.TransparentColor = System.Drawing.Color.Transparent;
            this.ilAlbero.Images.SetKeyName(0, "about32.png");
            this.ilAlbero.Images.SetKeyName(1, "Aggiornamenti32.png");
            this.ilAlbero.Images.SetKeyName(2, "Avere32.png");
            this.ilAlbero.Images.SetKeyName(3, "calcolatrice32.png");
            this.ilAlbero.Images.SetKeyName(4, "calendario32.png");
            this.ilAlbero.Images.SetKeyName(5, "cash-register-icon32.png");
            this.ilAlbero.Images.SetKeyName(6, "cassaforte32.png");
            this.ilAlbero.Images.SetKeyName(7, "controllaAlert32.png");
            this.ilAlbero.Images.SetKeyName(8, "controllaperiodici32.png");
            this.ilAlbero.Images.SetKeyName(9, "dare32.png");
            this.ilAlbero.Images.SetKeyName(10, "db32.png");
            this.ilAlbero.Images.SetKeyName(11, "find321.png");
            this.ilAlbero.Images.SetKeyName(12, "grafico32.png");
            this.ilAlbero.Images.SetKeyName(13, "ingranaggio32.png");
            this.ilAlbero.Images.SetKeyName(14, "MacroAree.png");
            this.ilAlbero.Images.SetKeyName(15, "mail32.png");
            this.ilAlbero.Images.SetKeyName(16, "opzioni.png");
            this.ilAlbero.Images.SetKeyName(17, "perdioci32.png");
            this.ilAlbero.Images.SetKeyName(18, "PieChart.png");
            this.ilAlbero.Images.SetKeyName(19, "portafoglio32.png");
            this.ilAlbero.Images.SetKeyName(20, "saldo32.png");
            this.ilAlbero.Images.SetKeyName(21, "salvadanaio32.png");
            this.ilAlbero.Images.SetKeyName(22, "star32.png");
            this.ilAlbero.Images.SetKeyName(23, "Strumenti32.png");
            this.ilAlbero.Images.SetKeyName(24, "sync32.png");
            this.ilAlbero.Images.SetKeyName(25, "chart_line.png");
            // 
            // cUtente1
            // 
            this.cUtente1.BackColor = System.Drawing.Color.White;
            this.cUtente1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cUtente1.Location = new System.Drawing.Point(0, 0);
            this.cUtente1.Name = "cUtente1";
            this.cUtente1.Size = new System.Drawing.Size(300, 70);
            this.cUtente1.TabIndex = 6;
            // 
            // tcSchede
            // 
            this.tcSchede.ContextMenuStrip = this.contextMenuStrip1;
            this.tcSchede.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSchede.ImageList = this.ilTabs;
            this.tcSchede.Location = new System.Drawing.Point(300, 0);
            this.tcSchede.Name = "tcSchede";
            this.tcSchede.SelectedIndex = 0;
            this.tcSchede.Size = new System.Drawing.Size(684, 624);
            this.tcSchede.TabIndex = 6;
            this.tcSchede.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tcSchede_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiudiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 26);
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.Image = global::RationesCurare7.Properties.Resources.application_delete;
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.chiudiToolStripMenuItem.Text = "Chiudi scheda corrente";
            this.chiudiToolStripMenuItem.Click += new System.EventHandler(this.chiudiToolStripMenuItem_Click);
            // 
            // ilTabs
            // 
            this.ilTabs.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilTabs.ImageSize = new System.Drawing.Size(16, 16);
            this.ilTabs.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pQuickInserimento
            // 
            this.pQuickInserimento.Controls.Add(this.bNuovoGiroconto);
            this.pQuickInserimento.Controls.Add(this.bNuovoMovimento);
            this.pQuickInserimento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pQuickInserimento.Location = new System.Drawing.Point(300, 624);
            this.pQuickInserimento.Name = "pQuickInserimento";
            this.pQuickInserimento.Size = new System.Drawing.Size(684, 37);
            this.pQuickInserimento.TabIndex = 7;
            // 
            // bNuovoGiroconto
            // 
            this.bNuovoGiroconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bNuovoGiroconto.Image = global::RationesCurare7.Properties.Resources.giroconto;
            this.bNuovoGiroconto.Location = new System.Drawing.Point(552, 6);
            this.bNuovoGiroconto.Name = "bNuovoGiroconto";
            this.bNuovoGiroconto.Size = new System.Drawing.Size(120, 25);
            this.bNuovoGiroconto.TabIndex = 1;
            this.bNuovoGiroconto.Text = "Nuovo &giroconto";
            this.bNuovoGiroconto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bNuovoGiroconto.UseVisualStyleBackColor = true;
            this.bNuovoGiroconto.Click += new System.EventHandler(this.bNuovoGiroconto_Click);
            // 
            // bNuovoMovimento
            // 
            this.bNuovoMovimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bNuovoMovimento.Image = global::RationesCurare7.Properties.Resources.Add32;
            this.bNuovoMovimento.Location = new System.Drawing.Point(426, 6);
            this.bNuovoMovimento.Name = "bNuovoMovimento";
            this.bNuovoMovimento.Size = new System.Drawing.Size(120, 25);
            this.bNuovoMovimento.TabIndex = 0;
            this.bNuovoMovimento.Text = "Nuovo &movimento";
            this.bNuovoMovimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bNuovoMovimento.UseVisualStyleBackColor = true;
            this.bNuovoMovimento.Click += new System.EventHandler(this.bNuovoMovimento_Click);
            // 
            // fMain
            // 
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tcSchede);
            this.Controls.Add(this.pQuickInserimento);
            this.Controls.Add(this.pLeft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1000, 678);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RationesCurare7 - [MAIONE MIKY]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fMain_KeyDown);
            this.pLeft.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.pQuickInserimento.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pLeft;
        private UI.Controlli.cUtente cUtente1;
        public System.Windows.Forms.TabControl tcSchede;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
        private System.Windows.Forms.ImageList ilTabs;
        private System.Windows.Forms.TreeView cAlbero;
        private System.Windows.Forms.ImageList ilAlbero;
        private System.Windows.Forms.Panel pQuickInserimento;
        private System.Windows.Forms.Button bNuovoGiroconto;
        private System.Windows.Forms.Button bNuovoMovimento;
    }
}