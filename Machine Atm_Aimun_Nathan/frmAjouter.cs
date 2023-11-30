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
        static public List<double> listBalance = new List<double>();
        public frmAjouter()
        {
            InitializeComponent();
        }

        private void tbxMontant_TextChanged(object sender, EventArgs e)
        {
            //ajouter le montant dans une liste pour pouvoir l'utiliser apres
           double montant=Convert.ToDouble(tbxMontant.Text);
           listBalance.Add(montant);
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
    }
}
