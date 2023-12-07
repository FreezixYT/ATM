using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Machine_Atm_Aimun_Nathan
{
    public partial class frmMdp : Form
    {
        public frmMdp()
        {
            InitializeComponent();
        }

        private void tbxMdp_TextChanged(object sender, EventArgs e)
        {
            {
                tbxMdp.Text = "";
                
                tbxMdp.PasswordChar = '*';
                // cafait que la longu du mdp soit a 14 mots.
                tbxMdp.MaxLength = 30;
                if (tbxMdp.Text.Length < 5)
                {
                    MessageBox.Show("password too short");
                    tbxMdp.Focus();
                }
            }
        }
    }
}
