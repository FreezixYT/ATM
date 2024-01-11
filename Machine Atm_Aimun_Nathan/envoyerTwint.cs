using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_Atm_Aimun_Nathan
{
    public partial class envoyerTwint : Form
    {
        public envoyerTwint()
        {
            InitializeComponent();
        }

        private void tbxArgentAEnvoyer_TextChanged(object sender, EventArgs e)
        {
            string somme = Convert.ToString(tbxArgentAEnvoyer);
        }

        private void btnEnvoyerArgent_Click(object sender, EventArgs e)
        {
       
            if (double.TryParse(tbxArgentAEnvoyer.Text, out double sommeEnvoyer))
            {
        
                SignIn.balance -= sommeEnvoyer;

             
                MessageBox.Show($"Vous avez envoyé {sommeEnvoyer}$ avec succès.", "Confirmation", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Veuillez entrer un montant valide.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void envoyerTwint_Load(object sender, EventArgs e)
        {

        }
    }
}
