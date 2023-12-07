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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblMaBank = new System.Windows.Forms.Label();
            this.btnTwint = new System.Windows.Forms.Button();
            this.btnCompte = new System.Windows.Forms.Button();
            this.lblCompte = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(318, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Retire de l\'argent";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(84, 82);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ajouter de l\'argent";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.lblMaBank.Location = new System.Drawing.Point(184, 18);
            this.lblMaBank.Name = "lblMaBank";
            this.lblMaBank.Size = new System.Drawing.Size(173, 42);
            this.lblMaBank.TabIndex = 5;
            this.lblMaBank.Text = "Ma Bank";
            // 
            // btnTwint
            // 
            this.btnTwint.BackColor = System.Drawing.Color.RosyBrown;
            this.btnTwint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTwint.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwint.Location = new System.Drawing.Point(84, 184);
            this.btnTwint.Margin = new System.Windows.Forms.Padding(2);
            this.btnTwint.Name = "btnTwint";
            this.btnTwint.Size = new System.Drawing.Size(133, 50);
            this.btnTwint.TabIndex = 6;
            this.btnTwint.Text = "TWINT";
            this.btnTwint.UseVisualStyleBackColor = false;
            this.btnTwint.Click += new System.EventHandler(this.btnTwint_Click);
            // 
            // btnCompte
            // 
            this.btnCompte.BackgroundImage = global::Machine_Atm_Aimun_Nathan.Properties.Resources.compte;
            this.btnCompte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCompte.Location = new System.Drawing.Point(12, 12);
            this.btnCompte.Name = "btnCompte";
            this.btnCompte.Size = new System.Drawing.Size(27, 26);
            this.btnCompte.TabIndex = 7;
            this.btnCompte.UseVisualStyleBackColor = true;
            this.btnCompte.Click += new System.EventHandler(this.btnCompte_Click);
            // 
            // lblCompte
            // 
            this.lblCompte.AutoSize = true;
            this.lblCompte.Location = new System.Drawing.Point(45, 19);
            this.lblCompte.Name = "lblCompte";
            this.lblCompte.Size = new System.Drawing.Size(67, 13);
            this.lblCompte.TabIndex = 9;
            this.lblCompte.Text = "Mon Compte";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RosyBrown;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(318, 184);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 50);
            this.button5.TabIndex = 10;
            this.button5.Text = "LOTERIE";
            this.button5.UseVisualStyleBackColor = false;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(533, 315);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblCompte);
            this.Controls.Add(this.btnCompte);
            this.Controls.Add(this.btnTwint);
            this.Controls.Add(this.lblMaBank);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblMaBank;
        private System.Windows.Forms.Button btnTwint;
        private System.Windows.Forms.Button btnCompte;
        private System.Windows.Forms.Label lblCompte;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}

