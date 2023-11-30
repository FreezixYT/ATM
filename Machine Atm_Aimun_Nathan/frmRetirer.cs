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
    public partial class frmRetirer : Form
    {
        static public double demandeRetire;
        public frmRetirer()
        {
            InitializeComponent();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //afficher le montantqui reste (retirer-montant)
        }

        private void tbxRetirer_TextChanged(object sender, EventArgs e)
        {
            //afficher un message box qui dis de recommencer si l'argent retirer est plus grnd que le montant
            demandeRetire = Convert.ToDouble(tbxRetirer.Text);
        }


        private void btnRetirer_Click(object sender, EventArgs e)
        {
            //afficher dans le tbxMontantReste le reste montant apres avoir retirer de 'argent

            if (frmRetirer.demandeRetire > frmAjouter.montant)
            {   //faire un meesage box avec 2 bouttons.
                //un qui dit recommencer pour recommencer et l'aure pour quitter
                string title = "ERROR";
                string message = "Le montant que vous voulez retirer depasse votre montant: ";
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
                else
                {
                    double total = frmAjouter.montant + demandeRetire;
                    string title1 = "felicitations!vous avez reussi a retirer de l'argent.";
                    string message1 = "il vous reste: " + total;
                    MessageBoxButtons button1 = MessageBoxButtons.OK;
                    DialogResult result1 = MessageBox.Show(message1, title1, button1);
                }
            }
        }
    }
}
