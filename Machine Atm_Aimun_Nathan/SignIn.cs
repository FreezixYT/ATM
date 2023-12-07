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
            if (tbxMdp.PasswordChar < 8)
            {
                MessageBox.Show("votre mot de passe est trop court");


                {
                    if (SignIn.mdp < 8)
                    {   //faire un meesage box avec 2 bouttons.
                        //un qui dit recommencer pour recommencer et l'aure pour quitter
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

            }
        }
    }
}
