/*nom:Yeamne
 * prenom:Aimun
 * nom:Pache
 * prenom:Nathan
 * classe:p1a
 */

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
    
    public partial class frmAjouter : Form
    {
        public frmAjouter()
        {
            InitializeComponent();
            this.tbxMontant.KeyPress += new KeyPressEventHandler(tbxMontant_KeyPress);
            this.tbxAjouter.KeyPress += new KeyPressEventHandler(tbxAjouter_KeyPress);
        }

        private void tbxMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ajouter le montant dans une liste pour pouvoir l'utiliser apres
            //faire en sorte qu'omn peut mettre que des chiffres
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void btnEntrer_Click(object sender, EventArgs e)
        {
            //additionner les deux
             SignIn.montant =Convert.ToDouble(tbxAjouter.Text)+Convert.ToDouble(tbxMontant.Text);
            //affichage de resultat final en message box
            string title = "Felicitations";
            string message = "le montant total: " + SignIn.montant;
            MessageBoxButtons button=MessageBoxButtons.OK;
            MessageBox.Show(message, title, button);
            SignIn.listBalance.Add(SignIn.montant);
        }


        private void tbxAjouter_KeyPress(object sender, KeyPressEventArgs e)
        {
            //faire en sorte qu'omn peut mettre que des chiffres
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

<<<<<<< HEAD
        private void btnRetourner_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.ShowDialog();
=======
        private void frmAjouter_Load(object sender, EventArgs e)
        {

>>>>>>> 2e234c0b8070dc548bfb440e99285ca4aa23222d
        }
    }
}