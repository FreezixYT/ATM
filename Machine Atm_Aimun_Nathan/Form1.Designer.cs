namespace Machine_Atm_Aimun_Nathan
{
    partial class frmLoterie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoterie));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbx_nb_1 = new System.Windows.Forms.TextBox();
            this.tbx_nb_2 = new System.Windows.Forms.TextBox();
            this.tbx_nb_3 = new System.Windows.Forms.TextBox();
            lblTwint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTwint
            // 
            lblTwint.AutoSize = true;
            lblTwint.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTwint.Location = new System.Drawing.Point(289, 24);
            lblTwint.Name = "lblTwint";
            lblTwint.Size = new System.Drawing.Size(176, 50);
            lblTwint.TabIndex = 1;
            lblTwint.Text = "LOTERIE";
            lblTwint.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Machine_Atm_Aimun_Nathan.Properties.Resources.istockphoto_921475382_170x170_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(237, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Location = new System.Drawing.Point(308, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "LANCER = 5 chf";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tbx_nb_1
            // 
            this.tbx_nb_1.Location = new System.Drawing.Point(321, 200);
            this.tbx_nb_1.Multiline = true;
            this.tbx_nb_1.Name = "tbx_nb_1";
            this.tbx_nb_1.Size = new System.Drawing.Size(37, 43);
            this.tbx_nb_1.TabIndex = 5;
            this.tbx_nb_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbx_nb_2
            // 
            this.tbx_nb_2.Location = new System.Drawing.Point(364, 200);
            this.tbx_nb_2.Multiline = true;
            this.tbx_nb_2.Name = "tbx_nb_2";
            this.tbx_nb_2.Size = new System.Drawing.Size(37, 43);
            this.tbx_nb_2.TabIndex = 6;
            this.tbx_nb_2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbx_nb_3
            // 
            this.tbx_nb_3.Location = new System.Drawing.Point(407, 200);
            this.tbx_nb_3.Multiline = true;
            this.tbx_nb_3.Name = "tbx_nb_3";
            this.tbx_nb_3.Size = new System.Drawing.Size(37, 43);
            this.tbx_nb_3.TabIndex = 7;
            // 
            // frmLoterie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbx_nb_3);
            this.Controls.Add(this.tbx_nb_2);
            this.Controls.Add(this.tbx_nb_1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(lblTwint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoterie";
            this.Text = "Loterie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbx_nb_1;
        private System.Windows.Forms.TextBox tbx_nb_2;
        private System.Windows.Forms.TextBox tbx_nb_3;
    }
}