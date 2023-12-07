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
            this.lblMontant = new System.Windows.Forms.Label();
            this.tbxMontant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAjouter = new System.Windows.Forms.TextBox();
            this.btnEntrer = new System.Windows.Forms.Button();
            this.btnRetourner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(79, 33);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(77, 13);
            this.lblMontant.TabIndex = 0;
            this.lblMontant.Text = "entrez balance";
            // 
            // tbxMontant
            // 
            this.tbxMontant.Location = new System.Drawing.Point(197, 33);
            this.tbxMontant.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMontant.Name = "tbxMontant";
            this.tbxMontant.Size = new System.Drawing.Size(68, 20);
            this.tbxMontant.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "entrez l\'argent que vous voulez ajouter";
            // 
            // tbxAjouter
            // 
            this.tbxAjouter.Location = new System.Drawing.Point(231, 100);
            this.tbxAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAjouter.Name = "tbxAjouter";
            this.tbxAjouter.Size = new System.Drawing.Size(68, 20);
            this.tbxAjouter.TabIndex = 3;
            // 
            // btnEntrer
            // 
            this.btnEntrer.Location = new System.Drawing.Point(185, 164);
            this.btnEntrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrer.Name = "btnEntrer";
            this.btnEntrer.Size = new System.Drawing.Size(79, 22);
            this.btnEntrer.TabIndex = 4;
            this.btnEntrer.Text = "Entrer";
            this.btnEntrer.UseVisualStyleBackColor = true;
            // 
            // btnRetourner
            // 
            this.btnRetourner.Location = new System.Drawing.Point(427, 263);
            this.btnRetourner.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetourner.Name = "btnRetourner";
            this.btnRetourner.Size = new System.Drawing.Size(79, 22);
            this.btnRetourner.TabIndex = 5;
            this.btnRetourner.Text = "retourner";
            this.btnRetourner.UseVisualStyleBackColor = true;
            this.btnRetourner.Click += new System.EventHandler(this.btnRetourner_Click);
            // 
            // frmAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnRetourner);
            this.Controls.Add(this.btnEntrer);
            this.Controls.Add(this.tbxAjouter);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAjouter;
        private System.Windows.Forms.Button btnEntrer;
        private System.Windows.Forms.Button btnRetourner;
    }
}