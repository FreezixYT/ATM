namespace Machine_Atm_Aimun_Nathan
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnExit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblMaBank = new System.Windows.Forms.Label();
            this.btnCompte = new System.Windows.Forms.Button();
            this.lblCompte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retirerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauCompteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.voirMesComptesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.twintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lotterieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comptesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouveauCompteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirMesComptesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDemandeCompte = new System.Windows.Forms.Label();
            this.btnOui = new System.Windows.Forms.Button();
            this.btnNon = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(362, 273);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RosyBrown;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(29, 273);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Sécuriter";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblMaBank
            // 
            this.lblMaBank.AutoSize = true;
            this.lblMaBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaBank.Location = new System.Drawing.Point(183, 0);
            this.lblMaBank.Name = "lblMaBank";
            this.lblMaBank.Size = new System.Drawing.Size(173, 42);
            this.lblMaBank.TabIndex = 5;
            this.lblMaBank.Text = "Ma Bank";
            // 
            // btnCompte
            // 
            this.btnCompte.BackgroundImage = global::Machine_Atm_Aimun_Nathan.Properties.Resources.compte;
            this.btnCompte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCompte.Location = new System.Drawing.Point(0, 49);
            this.btnCompte.Name = "btnCompte";
            this.btnCompte.Size = new System.Drawing.Size(27, 26);
            this.btnCompte.TabIndex = 7;
            this.btnCompte.UseVisualStyleBackColor = true;
            // 
            // lblCompte
            // 
            this.lblCompte.AutoSize = true;
            this.lblCompte.Location = new System.Drawing.Point(33, 56);
            this.lblCompte.Name = "lblCompte";
            this.lblCompte.Size = new System.Drawing.Size(67, 13);
            this.lblCompte.TabIndex = 9;
            this.lblCompte.Text = "Mon Compte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "©2023-MaBank.ch";
            // 
            // menuStripMain
            // 
            this.menuStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.comptesToolStripMenuItem1});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStripMain.Size = new System.Drawing.Size(533, 24);
            this.menuStripMain.TabIndex = 12;
            this.menuStripMain.Text = "¨";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.retirerToolStripMenuItem,
            this.comptesToolStripMenuItem,
            this.twintToolStripMenuItem,
            this.lotterieToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.ajouterToolStripMenuItem.Text = "ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // retirerToolStripMenuItem
            // 
            this.retirerToolStripMenuItem.Name = "retirerToolStripMenuItem";
            this.retirerToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.retirerToolStripMenuItem.Text = "retirer";
            this.retirerToolStripMenuItem.Click += new System.EventHandler(this.retirerToolStripMenuItem_Click);
            // 
            // comptesToolStripMenuItem
            // 
            this.comptesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionToolStripMenuItem1,
            this.nouveauCompteToolStripMenuItem1,
            this.voirMesComptesToolStripMenuItem1});
            this.comptesToolStripMenuItem.Name = "comptesToolStripMenuItem";
            this.comptesToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.comptesToolStripMenuItem.Text = "comptes";
            // 
            // deconnexionToolStripMenuItem1
            // 
            this.deconnexionToolStripMenuItem1.Name = "deconnexionToolStripMenuItem1";
            this.deconnexionToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.deconnexionToolStripMenuItem1.Text = "deconnexion";
            // 
            // nouveauCompteToolStripMenuItem1
            // 
            this.nouveauCompteToolStripMenuItem1.Name = "nouveauCompteToolStripMenuItem1";
            this.nouveauCompteToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.nouveauCompteToolStripMenuItem1.Text = "nouveau compte";
            // 
            // voirMesComptesToolStripMenuItem1
            // 
            this.voirMesComptesToolStripMenuItem1.Name = "voirMesComptesToolStripMenuItem1";
            this.voirMesComptesToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.voirMesComptesToolStripMenuItem1.Text = "voir mes comptes";
            // 
            // twintToolStripMenuItem
            // 
            this.twintToolStripMenuItem.Name = "twintToolStripMenuItem";
            this.twintToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.twintToolStripMenuItem.Text = "twint ";
            this.twintToolStripMenuItem.Click += new System.EventHandler(this.twintToolStripMenuItem_Click);
            // 
            // lotterieToolStripMenuItem
            // 
            this.lotterieToolStripMenuItem.Name = "lotterieToolStripMenuItem";
            this.lotterieToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.lotterieToolStripMenuItem.Text = "lotterie";
            this.lotterieToolStripMenuItem.Click += new System.EventHandler(this.lotterieToolStripMenuItem_Click);
            // 
            // comptesToolStripMenuItem1
            // 
            this.comptesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionToolStripMenuItem,
            this.nouveauCompteToolStripMenuItem,
            this.voirMesComptesToolStripMenuItem});
            this.comptesToolStripMenuItem1.Name = "comptesToolStripMenuItem1";
            this.comptesToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.comptesToolStripMenuItem1.Text = "comptes";
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deconnexionToolStripMenuItem.Text = "deconnexion";
            // 
            // nouveauCompteToolStripMenuItem
            // 
            this.nouveauCompteToolStripMenuItem.Name = "nouveauCompteToolStripMenuItem";
            this.nouveauCompteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nouveauCompteToolStripMenuItem.Text = "nouveau compte";
            // 
            // voirMesComptesToolStripMenuItem
            // 
            this.voirMesComptesToolStripMenuItem.Name = "voirMesComptesToolStripMenuItem";
            this.voirMesComptesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.voirMesComptesToolStripMenuItem.Text = "voir mes comptes";
            // 
            // lblDemandeCompte
            // 
            this.lblDemandeCompte.AutoSize = true;
            this.lblDemandeCompte.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemandeCompte.Location = new System.Drawing.Point(170, 106);
            this.lblDemandeCompte.Name = "lblDemandeCompte";
            this.lblDemandeCompte.Size = new System.Drawing.Size(198, 21);
            this.lblDemandeCompte.TabIndex = 13;
            this.lblDemandeCompte.Text = "Avez vous un compte?";
            // 
            // btnOui
            // 
            this.btnOui.BackColor = System.Drawing.Color.RosyBrown;
            this.btnOui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOui.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOui.Location = new System.Drawing.Point(284, 169);
            this.btnOui.Margin = new System.Windows.Forms.Padding(2);
            this.btnOui.Name = "btnOui";
            this.btnOui.Size = new System.Drawing.Size(84, 43);
            this.btnOui.TabIndex = 16;
            this.btnOui.Text = "OUI";
            this.btnOui.UseVisualStyleBackColor = false;
            this.btnOui.Click += new System.EventHandler(this.btnOui_Click);
            // 
            // btnNon
            // 
            this.btnNon.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNon.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNon.Location = new System.Drawing.Point(157, 169);
            this.btnNon.Margin = new System.Windows.Forms.Padding(2);
            this.btnNon.Name = "btnNon";
            this.btnNon.Size = new System.Drawing.Size(84, 43);
            this.btnNon.TabIndex = 17;
            this.btnNon.Text = "NON";
            this.btnNon.UseVisualStyleBackColor = false;
            this.btnNon.Click += new System.EventHandler(this.btnNon_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(533, 315);
            this.Controls.Add(this.btnNon);
            this.Controls.Add(this.btnOui);
            this.Controls.Add(this.lblDemandeCompte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCompte);
            this.Controls.Add(this.btnCompte);
            this.Controls.Add(this.lblMaBank);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Main";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblMaBank;
        private System.Windows.Forms.Button btnCompte;
        private System.Windows.Forms.Label lblCompte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retirerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comptesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comptesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem twintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lotterieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouveauCompteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirMesComptesToolStripMenuItem;
        private System.Windows.Forms.Label lblDemandeCompte;
        private System.Windows.Forms.Button btnOui;
        private System.Windows.Forms.Button btnNon;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nouveauCompteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem voirMesComptesToolStripMenuItem1;
    }
}

