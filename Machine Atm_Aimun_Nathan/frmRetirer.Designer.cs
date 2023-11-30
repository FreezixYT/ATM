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
            this.btnRetirer = new System.Windows.Forms.Button();
            this.lblDemandeRetirer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRetirer = new System.Windows.Forms.TextBox();
            this.tbxMontantReste = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRetirer
            // 
            this.btnRetirer.Location = new System.Drawing.Point(249, 176);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(100, 37);
            this.btnRetirer.TabIndex = 0;
            this.btnRetirer.Text = "RETIRER";
            this.btnRetirer.UseVisualStyleBackColor = true;
            this.btnRetirer.Click += new System.EventHandler(this.btnRetirer_Click);
            // 
            // lblDemandeRetirer
            // 
            this.lblDemandeRetirer.AutoSize = true;
            this.lblDemandeRetirer.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemandeRetirer.Location = new System.Drawing.Point(12, 57);
            this.lblDemandeRetirer.Name = "lblDemandeRetirer";
            this.lblDemandeRetirer.Size = new System.Drawing.Size(160, 42);
            this.lblDemandeRetirer.TabIndex = 2;
            this.lblDemandeRetirer.Text = "Combien d\'argent \r\nvoulez vous retirer?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "il vous reste";
            // 
            // tbxRetirer
            // 
            this.tbxRetirer.Location = new System.Drawing.Point(206, 69);
            this.tbxRetirer.Name = "tbxRetirer";
            this.tbxRetirer.Size = new System.Drawing.Size(189, 20);
            this.tbxRetirer.TabIndex = 1;
            this.tbxRetirer.TextChanged += new System.EventHandler(this.tbxRetirer_TextChanged);
            // 
            // tbxMontantReste
            // 
            this.tbxMontantReste.Location = new System.Drawing.Point(206, 119);
            this.tbxMontantReste.Name = "tbxMontantReste";
            this.tbxMontantReste.Size = new System.Drawing.Size(189, 20);
            this.tbxMontantReste.TabIndex = 4;
            this.tbxMontantReste.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // frmRetirer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxMontantReste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDemandeRetirer);
            this.Controls.Add(this.tbxRetirer);
            this.Controls.Add(this.btnRetirer);
            this.Name = "frmRetirer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetirer;
        private System.Windows.Forms.Label lblDemandeRetirer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRetirer;
        private System.Windows.Forms.TextBox tbxMontantReste;
    }
}