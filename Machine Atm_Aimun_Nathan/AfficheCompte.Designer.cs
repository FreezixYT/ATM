﻿namespace Machine_Atm_Aimun_Nathan
{
    partial class AfficheCompte
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
            this.btnReturner = new System.Windows.Forms.Button();
            this.pnlCompte = new System.Windows.Forms.Panel();
            this.lblCarteN = new System.Windows.Forms.Label();
            this.lblUtilisateur = new System.Windows.Forms.Label();
            this.lblCompte = new System.Windows.Forms.Label();
            this.lblCarteNbr = new System.Windows.Forms.Label();
            this.lblCNom = new System.Windows.Forms.Label();
            this.pictureBoxAccouont = new System.Windows.Forms.PictureBox();
            this.pnlCompte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccouont)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturner
            // 
            this.btnReturner.Location = new System.Drawing.Point(437, 577);
            this.btnReturner.Name = "btnReturner";
            this.btnReturner.Size = new System.Drawing.Size(113, 40);
            this.btnReturner.TabIndex = 2;
            this.btnReturner.Text = "Retourner";
            this.btnReturner.UseVisualStyleBackColor = true;
            this.btnReturner.Click += new System.EventHandler(this.btnReturner_Click);
            // 
            // pnlCompte
            // 
            this.pnlCompte.BackColor = System.Drawing.Color.Azure;
            this.pnlCompte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCompte.Controls.Add(this.lblCarteN);
            this.pnlCompte.Controls.Add(this.lblUtilisateur);
            this.pnlCompte.Controls.Add(this.lblCompte);
            this.pnlCompte.Controls.Add(this.lblCarteNbr);
            this.pnlCompte.Controls.Add(this.lblCNom);
            this.pnlCompte.ForeColor = System.Drawing.Color.RoyalBlue;
            this.pnlCompte.Location = new System.Drawing.Point(55, 167);
            this.pnlCompte.Name = "pnlCompte";
            this.pnlCompte.Size = new System.Drawing.Size(452, 381);
            this.pnlCompte.TabIndex = 1;
            // 
            // lblCarteN
            // 
            this.lblCarteN.AutoSize = true;
            this.lblCarteN.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarteN.ForeColor = System.Drawing.Color.Black;
            this.lblCarteN.Location = new System.Drawing.Point(176, 129);
            this.lblCarteN.Name = "lblCarteN";
            this.lblCarteN.Size = new System.Drawing.Size(17, 24);
            this.lblCarteN.TabIndex = 4;
            this.lblCarteN.Text = "-";
            // 
            // lblUtilisateur
            // 
            this.lblUtilisateur.AutoSize = true;
            this.lblUtilisateur.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilisateur.ForeColor = System.Drawing.Color.Black;
            this.lblUtilisateur.Location = new System.Drawing.Point(176, 78);
            this.lblUtilisateur.Name = "lblUtilisateur";
            this.lblUtilisateur.Size = new System.Drawing.Size(17, 24);
            this.lblUtilisateur.TabIndex = 3;
            this.lblUtilisateur.Text = "-";
            this.lblUtilisateur.Click += new System.EventHandler(this.lblUtilisateur_Click);
            // 
            // lblCompte
            // 
            this.lblCompte.AutoSize = true;
            this.lblCompte.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompte.ForeColor = System.Drawing.Color.Black;
            this.lblCompte.Location = new System.Drawing.Point(164, 17);
            this.lblCompte.Name = "lblCompte";
            this.lblCompte.Size = new System.Drawing.Size(70, 24);
            this.lblCompte.TabIndex = 2;
            this.lblCompte.Text = "Compte";
            // 
            // lblCarteNbr
            // 
            this.lblCarteNbr.AutoSize = true;
            this.lblCarteNbr.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarteNbr.ForeColor = System.Drawing.Color.Black;
            this.lblCarteNbr.Location = new System.Drawing.Point(7, 129);
            this.lblCarteNbr.Name = "lblCarteNbr";
            this.lblCarteNbr.Size = new System.Drawing.Size(130, 24);
            this.lblCarteNbr.TabIndex = 1;
            this.lblCarteNbr.Text = "Carte Nombre:";
            // 
            // lblCNom
            // 
            this.lblCNom.AutoSize = true;
            this.lblCNom.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNom.ForeColor = System.Drawing.Color.Black;
            this.lblCNom.Location = new System.Drawing.Point(82, 78);
            this.lblCNom.Name = "lblCNom";
            this.lblCNom.Size = new System.Drawing.Size(55, 24);
            this.lblCNom.TabIndex = 0;
            this.lblCNom.Text = "Nom:";
            // 
            // pictureBoxAccouont
            // 
            this.pictureBoxAccouont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAccouont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAccouont.Image = global::Machine_Atm_Aimun_Nathan.Properties.Resources.Sans_titre;
            this.pictureBoxAccouont.Location = new System.Drawing.Point(201, 29);
            this.pictureBoxAccouont.Name = "pictureBoxAccouont";
            this.pictureBoxAccouont.Size = new System.Drawing.Size(149, 132);
            this.pictureBoxAccouont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAccouont.TabIndex = 0;
            this.pictureBoxAccouont.TabStop = false;
            // 
            // AfficheCompte
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(602, 629);
            this.Controls.Add(this.pictureBoxAccouont);
            this.Controls.Add(this.btnReturner);
            this.Controls.Add(this.pnlCompte);
            this.Name = "AfficheCompte";
            this.Text = "AfficheCompte";
            this.pnlCompte.ResumeLayout(false);
            this.pnlCompte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccouont)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAccouont;
        private System.Windows.Forms.Panel pnlCompte;
        private System.Windows.Forms.Button btnReturner;
        private System.Windows.Forms.Label lblCompte;
        private System.Windows.Forms.Label lblCarteNbr;
        private System.Windows.Forms.Label lblCNom;
        private System.Windows.Forms.Label lblCarteN;
        private System.Windows.Forms.Label lblUtilisateur;
    }
}