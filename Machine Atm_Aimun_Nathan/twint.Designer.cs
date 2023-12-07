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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.btnRecevoir = new System.Windows.Forms.Button();
            lblTwint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTwint
            // 
            lblTwint.AutoSize = true;
            lblTwint.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTwint.Location = new System.Drawing.Point(362, 39);
            lblTwint.Name = "lblTwint";
            lblTwint.Size = new System.Drawing.Size(133, 50);
            lblTwint.TabIndex = 0;
            lblTwint.Text = "TWINT";
            lblTwint.UseCompatibleTextRendering = true;
            lblTwint.Click += new System.EventHandler(this.lblTwint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Machine_Atm_Aimun_Nathan.Properties.Resources.twint_logo1;
            this.pictureBox1.Location = new System.Drawing.Point(302, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(534, 216);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.BackColor = System.Drawing.Color.RosyBrown;
            this.btnEnvoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyer.Location = new System.Drawing.Point(115, 164);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(183, 80);
            this.btnEnvoyer.TabIndex = 3;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = false;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // btnRecevoir
            // 
            this.btnRecevoir.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRecevoir.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecevoir.Location = new System.Drawing.Point(115, 298);
            this.btnRecevoir.Name = "btnRecevoir";
            this.btnRecevoir.Size = new System.Drawing.Size(183, 80);
            this.btnRecevoir.TabIndex = 4;
            this.btnRecevoir.Text = "Recevoir";
            this.btnRecevoir.UseVisualStyleBackColor = false;
            // 
            // frmTwint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecevoir);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(lblTwint);
            this.Name = "frmTwint";
            this.Text = "Twint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.Button btnRecevoir;
    }
}