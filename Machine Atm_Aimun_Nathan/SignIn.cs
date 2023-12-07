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
    public partial class SignIn : Form
    {
        static public char mdp;
        static public int age;
        static public char utilisateur;

        public SignIn()
        {
            InitializeComponent();
        }

        private void tbxMdp_TextChanged(object sender, EventArgs e)
        {
            mdp = Convert.ToChar(tbxMdp.PasswordChar);
            tbxMdp.Text = "";
            tbxMdp.PasswordChar = '*';
            tbxMdp.MaxLength = 14;
               if (SignIn.mdp < 8)
               {   
                  string title = "ERROR";
                  string message = "Le mot de passe est trop court ";
                  MessageBoxButtons button = MessageBoxButtons.YesNo;
                  DialogResult result = MessageBox.Show(message, title, button);
                  if (result == DialogResult.Yes)
                  {
                     frmRetirer frm = new frmRetirer();
                     frm.ShowDialog();
                  }
                  else if (result == DialogResult.No)
                  {
                   frmMain frm = new frmMain();
                       frm.Show();
                  }
               }

        }

        private void tbxAge_TextChanged(object sender, EventArgs e)
        {
            age=Convert.ToInt32(tbxAge.Text);
            if (age < 12)
            {
                string title = "ERROR";
                string message = "vous etes trop jeune ";
                MessageBoxButtons button = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, button);
                if (result == DialogResult.OK) 
                {
                    Application.Exit();
                }
            }
        }

        private void tbxUtilisateur_TextChanged(object sender, EventArgs e)
        {
            utilisateur = Convert.ToChar(tbxUtilisateur);
        }
    }
}
