namespace Machine_Atm_Aimun_Nathan
{
    partial class Form2
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
            this.lblEnvoyer = new System.Windows.Forms.Label();
            this.Michelle = new System.Windows.Forms.CheckedListBox();
            this.btnEnvoyerArgent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxArgentAEnvoyer = new System.Windows.Forms.TextBox();
            this.lblContacte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnvoyer
            // 
            this.lblEnvoyer.AutoSize = true;
            this.lblEnvoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnvoyer.Location = new System.Drawing.Point(250, 21);
            this.lblEnvoyer.Name = "lblEnvoyer";
            this.lblEnvoyer.Size = new System.Drawing.Size(314, 39);
            this.lblEnvoyer.TabIndex = 0;
            this.lblEnvoyer.Text = "Envoyer de l\'argent";
            // 
            // Michelle
            // 
            this.Michelle.BackColor = System.Drawing.Color.RosyBrown;
            this.Michelle.FormattingEnabled = true;
            this.Michelle.Items.AddRange(new object[] {
            "Nathan",
            "Emun",
            "Michel",
            "Fred",
            "Eric",
            "Autre..."});
            this.Michelle.Location = new System.Drawing.Point(535, 174);
            this.Michelle.Name = "Michelle";
            this.Michelle.Size = new System.Drawing.Size(111, 94);
            this.Michelle.TabIndex = 1;
            // 
            // btnEnvoyerArgent
            // 
            this.btnEnvoyerArgent.BackColor = System.Drawing.Color.RosyBrown;
            this.btnEnvoyerArgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyerArgent.Location = new System.Drawing.Point(223, 321);
            this.btnEnvoyerArgent.Name = "btnEnvoyerArgent";
            this.btnEnvoyerArgent.Size = new System.Drawing.Size(314, 97);
            this.btnEnvoyerArgent.TabIndex = 2;
            this.btnEnvoyerArgent.Text = "Envoyer";
            this.btnEnvoyerArgent.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chosiser la somme\r\n a envoyer :";
            // 
            // tbxArgentAEnvoyer
            // 
            this.tbxArgentAEnvoyer.Location = new System.Drawing.Point(223, 163);
            this.tbxArgentAEnvoyer.Name = "tbxArgentAEnvoyer";
            this.tbxArgentAEnvoyer.Size = new System.Drawing.Size(63, 20);
            this.tbxArgentAEnvoyer.TabIndex = 4;
            this.tbxArgentAEnvoyer.TextChanged += new System.EventHandler(this.tbxArgentAEnvoyer_TextChanged);
            // 
            // lblContacte
            // 
            this.lblContacte.AutoSize = true;
            this.lblContacte.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContacte.Location = new System.Drawing.Point(529, 129);
            this.lblContacte.Name = "lblContacte";
            this.lblContacte.Size = new System.Drawing.Size(139, 31);
            this.lblContacte.TabIndex = 5;
            this.lblContacte.Text = "Contacte :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblContacte);
            this.Controls.Add(this.tbxArgentAEnvoyer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnvoyerArgent);
            this.Controls.Add(this.Michelle);
            this.Controls.Add(this.lblEnvoyer);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnvoyer;
        private System.Windows.Forms.CheckedListBox Michelle;
        private System.Windows.Forms.Button btnEnvoyerArgent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxArgentAEnvoyer;
        private System.Windows.Forms.Label lblContacte;
    }
}