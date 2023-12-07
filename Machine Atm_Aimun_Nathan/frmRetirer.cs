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
        static public double montantR;
        public frmRetirer()
        {
            InitializeComponent();
            this.tbxRetirer.KeyPress += new KeyPressEventHandler(tbxRetirer_KeyPress);
        }

        private void tbxRetirer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //afficher un message box qui dis de recommencer si l'argent retirer est plus grnd que le montant

            //faire en sorte qu'omn peut mettre que des chiffres
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }


        private void btnRetirer_Click(object sender, EventArgs e)
        {
            //afficher dans le tbxMontantReste le reste montant apres avoir retirer de 'argent
            demandeRetire = Convert.ToDouble(tbxRetirer.Text);

            if (frmRetirer.demandeRetire > SignIn.montant)
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
                    double total = SignIn.montant + demandeRetire;
                    string title1 = "felicitations!vous avez reussi a retirer de l'argent.";
                    string message1 = "il vous reste: " + total;
                    MessageBoxButtons button1 = MessageBoxButtons.OK;
                    DialogResult result1 = MessageBox.Show(message1, title1, button1);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMain frm=new frmMain();
            frm.ShowDialog();
        }

        private void frmRetirer_Load(object sender, EventArgs e)
        {

        }
    }
}
