namespace Machine_Atm_Aimun_Nathan
{
    partial class frmTwint
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
            System.Windows.Forms.Label lblTwint;
            lblTwint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTwint
            // 
            lblTwint.AutoSize = true;
            lblTwint.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTwint.Location = new System.Drawing.Point(372, 117);
            lblTwint.Name = "lblTwint";
            lblTwint.Size = new System.Drawing.Size(125, 50);
            lblTwint.TabIndex = 0;
            lblTwint.Text = "label1";
            lblTwint.UseCompatibleTextRendering = true;
            // 
            // frmTwint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(lblTwint);
            this.Name = "frmTwint";
            this.Text = "Twint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}