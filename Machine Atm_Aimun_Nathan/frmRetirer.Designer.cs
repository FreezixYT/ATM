namespace Machine_Atm_Aimun_Nathan
{
    partial class frmRetirer
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
            System.Windows.Forms.Label lblRetirerArgent;
            this.btnRetirer = new System.Windows.Forms.Button();
            this.lblDemandeRetirer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRetirer = new System.Windows.Forms.TextBox();
            this.tbxMontantReste = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            lblRetirerArgent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRetirer
            // 
            this.btnRetirer.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRetirer.Location = new System.Drawing.Point(240, 275);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(245, 37);
            this.btnRetirer.TabIndex = 0;
            this.btnRetirer.Text = "RETIRER";
            this.btnRetirer.UseVisualStyleBackColor = false;
            this.btnRetirer.Click += new System.EventHandler(this.btnRetirer_Click);
            // 
            // lblDemandeRetirer
            // 
            this.lblDemandeRetirer.AutoSize = true;
            this.lblDemandeRetirer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemandeRetirer.Location = new System.Drawing.Point(235, 118);
            this.lblDemandeRetirer.Name = "lblDemandeRetirer";
            this.lblDemandeRetirer.Size = new System.Drawing.Size(184, 29);
            this.lblDemandeRetirer.TabIndex = 2;
            this.lblDemandeRetirer.Text = "Argent à retirer :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "il vous reste :";
            // 
            // tbxRetirer
            // 
            this.tbxRetirer.Location = new System.Drawing.Point(425, 127);
            this.tbxRetirer.Name = "tbxRetirer";
            this.tbxRetirer.Size = new System.Drawing.Size(60, 20);
            this.tbxRetirer.TabIndex = 1;
            // 
            // tbxMontantReste
            // 
            this.tbxMontantReste.Location = new System.Drawing.Point(176, 410);
            this.tbxMontantReste.Name = "tbxMontantReste";
            this.tbxMontantReste.Size = new System.Drawing.Size(53, 20);
            this.tbxMontantReste.TabIndex = 4;
            this.tbxMontantReste.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.RosyBrown;
            this.btnReturn.Location = new System.Drawing.Point(673, 401);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 37);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Retourner";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblRetirerArgent
            // 
            lblRetirerArgent.AutoSize = true;
            lblRetirerArgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRetirerArgent.Location = new System.Drawing.Point(184, 24);
            lblRetirerArgent.Name = "lblRetirerArgent";
            lblRetirerArgent.Size = new System.Drawing.Size(441, 50);
            lblRetirerArgent.TabIndex = 6;
            lblRetirerArgent.Text = "RETIRER DE L\'ARGENT";
            lblRetirerArgent.UseCompatibleTextRendering = true;
            // 
            // frmRetirer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(lblRetirerArgent);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tbxMontantReste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDemandeRetirer);
            this.Controls.Add(this.tbxRetirer);
            this.Controls.Add(this.btnRetirer);
            this.Name = "frmRetirer";
            this.Text = "frmRetier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetirer;
        private System.Windows.Forms.Label lblDemandeRetirer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRetirer;
        private System.Windows.Forms.TextBox tbxMontantReste;
        private System.Windows.Forms.Button btnReturn;
    }
}