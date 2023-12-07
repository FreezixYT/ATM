namespace Machine_Atm_Aimun_Nathan
{
    partial class frmMdp
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
            this.lblUtilisateur = new System.Windows.Forms.Label();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.tbxUtilisateur = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxMdp = new System.Windows.Forms.TextBox();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUtilisateur
            // 
            this.lblUtilisateur.AutoSize = true;
            this.lblUtilisateur.Location = new System.Drawing.Point(202, 105);
            this.lblUtilisateur.Name = "lblUtilisateur";
            this.lblUtilisateur.Size = new System.Drawing.Size(56, 13);
            this.lblUtilisateur.TabIndex = 0;
            this.lblUtilisateur.Text = "Utilisateur:";
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(351, 291);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.btnEnvoyer.TabIndex = 1;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            // 
            // tbxUtilisateur
            // 
            this.tbxUtilisateur.Location = new System.Drawing.Point(270, 98);
            this.tbxUtilisateur.Name = "tbxUtilisateur";
            this.tbxUtilisateur.Size = new System.Drawing.Size(254, 20);
            this.tbxUtilisateur.TabIndex = 2;
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Location = new System.Drawing.Point(183, 149);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(75, 13);
            this.lblMdp.TabIndex = 3;
            this.lblMdp.Text = "Mot de Passe:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(202, 202);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(53, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Votre age";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(202, 29);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(59, 13);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "votre Nom:";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(270, 22);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(254, 20);
            this.tbxNom.TabIndex = 6;
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(270, 195);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(254, 20);
            this.tbxAge.TabIndex = 7;
            // 
            // tbxMdp
            // 
            this.tbxMdp.Location = new System.Drawing.Point(270, 146);
            this.tbxMdp.Name = "tbxMdp";
            this.tbxMdp.Size = new System.Drawing.Size(254, 20);
            this.tbxMdp.TabIndex = 8;
            this.tbxMdp.TextChanged += new System.EventHandler(this.tbxMdp_TextChanged);
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(270, 62);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(254, 20);
            this.tbxPrenom.TabIndex = 9;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(196, 65);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(73, 13);
            this.lblPrenom.TabIndex = 10;
            this.lblPrenom.Text = "votre Prénom:";
            // 
            // frmMdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.tbxMdp);
            this.Controls.Add(this.tbxAge);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.tbxUtilisateur);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.lblUtilisateur);
            this.Name = "frmMdp";
            this.Text = "Compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUtilisateur;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.TextBox tbxUtilisateur;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxMdp;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.Label lblPrenom;
    }
}