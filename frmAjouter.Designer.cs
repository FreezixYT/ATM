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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(118, 51);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(114, 20);
            this.lblMontant.TabIndex = 0;
            this.lblMontant.Text = "entrez balance";
            // 
            // tbxMontant
            // 
            this.tbxMontant.Location = new System.Drawing.Point(296, 51);
            this.tbxMontant.Name = "tbxMontant";
            this.tbxMontant.Size = new System.Drawing.Size(100, 26);
            this.tbxMontant.TabIndex = 1;
            this.tbxMontant.TextChanged += new System.EventHandler(this.tbxMontant_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "entrez l\'argent que vous voulez ajouter";
            // 
            // tbxAjouter
            // 
            this.tbxAjouter.Location = new System.Drawing.Point(347, 154);
            this.tbxAjouter.Name = "tbxAjouter";
            this.tbxAjouter.Size = new System.Drawing.Size(100, 26);
            this.tbxAjouter.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "btnEnter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(640, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "retourner";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxAjouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMontant);
            this.Controls.Add(this.lblMontant);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}