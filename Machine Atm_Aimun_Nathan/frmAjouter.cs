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
        static public double montant;
        public frmAjouter()
        {
            InitializeComponent();
            this.tbxMontant.KeyPress += new KeyPressEventHandler(tbxMontant_KeyPress);
            this.tbxAjouter.KeyPress += new KeyPressEventHandler(tbxAjouter_KeyPress);
        }

        private void tbxMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ajouter le montant dans une liste pour pouvoir l'utiliser apres
            montant=Convert.ToDouble(tbxMontant.Text);
            //faire en sorte qu'omn peut mettre que des chiffres
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {//additionner les deux
            double total =Convert.ToDouble(tbxAjouter.Text)+Convert.ToDouble(tbxMontant.Text);
            //affichage de resultat final en message box
            string title = "Felicitations";
            string message = "le montant total: " + total;
            MessageBoxButtons button=MessageBoxButtons.OK;
            MessageBox.Show(message, title, button);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }

        private void tbxAjouter_KeyPress(object sender, KeyPressEventArgs e)
        {
            //faire en sorte qu'omn peut mettre que des chiffres
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void frmAjouter_Load(object sender, EventArgs e)
        {

        }
    }
}