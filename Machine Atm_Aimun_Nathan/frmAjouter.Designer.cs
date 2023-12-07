namespace Machine_Atm_Aimun_Nathan
{
    partial class frmAjouter
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
            System.Windows.Forms.Label lblAjouter;
            this.lblMontant = new System.Windows.Forms.Label();
            this.tbxMontant = new System.Windows.Forms.TextBox();
            this.lblArgentAjouter = new System.Windows.Forms.Label();
            this.tbxAjouter = new System.Windows.Forms.TextBox();
            this.btnEntrer = new System.Windows.Forms.Button();
            this.btnRetourner = new System.Windows.Forms.Button();
            lblAjouter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(127, 81);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(116, 20);
            this.lblMontant.TabIndex = 0;
            this.lblMontant.Text = "Entrez balance";
            // 
            // tbxMontant
            // 
            this.tbxMontant.Location = new System.Drawing.Point(269, 83);
            this.tbxMontant.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMontant.Name = "tbxMontant";
            this.tbxMontant.Size = new System.Drawing.Size(68, 20);
            this.tbxMontant.TabIndex = 1;
            // 
            // lblArgentAjouter
            // 
            this.lblArgentAjouter.AutoSize = true;
            this.lblArgentAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArgentAjouter.Location = new System.Drawing.Point(127, 117);
            this.lblArgentAjouter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArgentAjouter.Name = "lblArgentAjouter";
            this.lblArgentAjouter.Size = new System.Drawing.Size(123, 20);
            this.lblArgentAjouter.TabIndex = 2;
            this.lblArgentAjouter.Text = "Argent à ajouter";
            // 
            // tbxAjouter
            // 
            this.tbxAjouter.Location = new System.Drawing.Point(269, 117);
            this.tbxAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAjouter.Name = "tbxAjouter";
            this.tbxAjouter.Size = new System.Drawing.Size(68, 20);
            this.tbxAjouter.TabIndex = 3;
            // 
            // btnEntrer
            // 
            this.btnEntrer.BackColor = System.Drawing.Color.RosyBrown;
            this.btnEntrer.Location = new System.Drawing.Point(131, 179);
            this.btnEntrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrer.Name = "btnEntrer";
            this.btnEntrer.Size = new System.Drawing.Size(79, 22);
            this.btnEntrer.TabIndex = 4;

            this.btnEntrer.Text = "Entrer";
            this.btnEntrer.UseVisualStyleBackColor = true;

            this.btnEntrer.Text = "btnEnter";
            this.btnEntrer.UseVisualStyleBackColor = false;

            // 
            // btnRetourner
            // 
            this.btnRetourner.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRetourner.Text = "Exit";
            this.btnRetourner.UseVisualStyleBackColor = false;
            // 
            // lblAjouter
            // 
            lblAjouter.AutoSize = true;
            lblAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblAjouter.Location = new System.Drawing.Point(168, 5);
            lblAjouter.Name = "lblAjouter";
            lblAjouter.Size = new System.Drawing.Size(191, 50);
            lblAjouter.TabIndex = 6;
            lblAjouter.Text = "AJOUTER";
            lblAjouter.UseCompatibleTextRendering = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(lblAjouter);
            this.Controls.Add(this.btnRetourner);
            this.Controls.Add(this.btnEntrer);
            this.Controls.Add(this.tbxAjouter);
            this.Controls.Add(this.lblArgentAjouter);
            this.Controls.Add(this.tbxMontant);
            this.Controls.Add(this.lblMontant);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAjouter";
            this.Text = "frmAjouter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.TextBox tbxMontant;
        private System.Windows.Forms.Label lblArgentAjouter;
        private System.Windows.Forms.TextBox tbxAjouter;
        private System.Windows.Forms.Button btnEntrer;
        private System.Windows.Forms.Button btnRetourner;
    }
}